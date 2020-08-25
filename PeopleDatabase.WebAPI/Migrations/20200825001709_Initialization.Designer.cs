﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleDatabase.WebAPI.Data;

namespace CadastroPessoas.WebAPI.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20200825001709_Initialization")]
    partial class Initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PeopleDatabase.WebAPI.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1984, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marta@email.com",
                            FirstName = "Marta",
                            IsActive = true,
                            LastName = "Kent",
                            PhoneNumber = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1992, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "paula@email.com",
                            FirstName = "Paula",
                            IsActive = true,
                            LastName = "Isabela",
                            PhoneNumber = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1977, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "laura@email.com",
                            FirstName = "Laura",
                            IsActive = true,
                            LastName = "Antonia",
                            PhoneNumber = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1957, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luiza@email.com",
                            FirstName = "Luiza",
                            IsActive = true,
                            LastName = "Maria",
                            PhoneNumber = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2000, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lucas@email.com",
                            FirstName = "Lucas",
                            IsActive = true,
                            LastName = "Machado",
                            PhoneNumber = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2005, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pedro@email.com",
                            FirstName = "Pedro",
                            IsActive = true,
                            LastName = "Alvares",
                            PhoneNumber = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1988, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "paulo@email.com",
                            FirstName = "Paulo",
                            IsActive = true,
                            LastName = "José",
                            PhoneNumber = "9874512"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
