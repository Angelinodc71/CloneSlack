﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210831075751_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Domain.Channel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Channels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba2dd387-db75-4be9-8cb0-9b51c279d802"),
                            Description = "Channel dedicated to development in ASP.NET Core 5",
                            Name = "DotNetCore"
                        },
                        new
                        {
                            Id = new Guid("ac7fc5b7-3b6b-46a4-9ea2-cf1ed8337cbc"),
                            Description = "Channel dedicated to development in Angular",
                            Name = "Angular"
                        },
                        new
                        {
                            Id = new Guid("800092b8-91bf-4df0-ab48-df89d741b154"),
                            Description = "Channel dedicated to development in React.js",
                            Name = "React.js"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
