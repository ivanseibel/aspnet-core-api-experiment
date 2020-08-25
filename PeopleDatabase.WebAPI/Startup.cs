using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PeopleDatabase.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using FluentValidation.AspNetCore;
using FluentValidation;
using PeopleDatabase.WebAPI.Models;

namespace PeopleDatabase.WebAPI
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<APIContext>(
        context => context.UseSqlServer(
          Configuration.GetConnectionString("Default")
        )
      );
        
      services
        .AddControllers()
        .AddNewtonsoftJson(options => 
          options.SerializerSettings.ReferenceLoopHandling = 
          Newtonsoft.Json.ReferenceLoopHandling.Ignore
        );

      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

      services.AddScoped<IPeopleRepository, PeopleRepository>();

      services.AddMvc().AddFluentValidation();
      services.AddTransient<IValidator<Person>, PersonValidator>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      // app.UseHttpsRedirection();

      app.UseRouting();

      // app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
