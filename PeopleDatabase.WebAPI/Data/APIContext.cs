using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PeopleDatabase.WebAPI.Models;

namespace PeopleDatabase.WebAPI.Data
{
  public class APIContext : DbContext
  {
    public APIContext(DbContextOptions<APIContext> options): base(options) {}
    public DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Person>()
        .HasData(new List<Person>(){
          new Person(
            1, 
            "Marta", 
            "Kent", 
            "33225555",
            "marta@email.com", 
            DateTime.Parse("01/28/1984")
          ),
          new Person(
            2, 
            "Paula", 
            "Isabela", 
            "3354288",
            "paula@email.com", 
            DateTime.Parse("05/27/1992")
          ),
          new Person(
            3, 
            "Laura", 
            "Antonia", 
            "55668899",
            "laura@email.com", 
            DateTime.Parse("03/17/1977")
          ),
          new Person(
            4, 
            "Luiza", 
            "Maria", 
            "6565659",
            "luiza@email.com", 
            DateTime.Parse("12/01/1957")
          ),
          new Person(
            5, 
            "Lucas", 
            "Machado", 
            "565685415",
            "lucas@email.com", 
            DateTime.Parse("08/30/2000")
          ),
          new Person(
            6, 
            "Pedro", 
            "Alvares", 
            "456454545",
            "pedro@email.com", 
            DateTime.Parse("07/21/2005")
          ),
          new Person(
            7, 
            "Paulo", 
            "José", 
            "9874512",
            "paulo@email.com", 
            DateTime.Parse("02/10/1988")
          )
        });
    }
  }
}
 