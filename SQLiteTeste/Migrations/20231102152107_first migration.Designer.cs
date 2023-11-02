﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLiteTeste.Models;

#nullable disable

namespace SQLiteTeste.Migrations
{
    [DbContext(typeof(DogTreatmentDbContext))]
    [Migration("20231102152107_first migration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("SQLiteTeste.Models.DogTreatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Food")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MissingFood")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MissingWater")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Water")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("tbDogTreatments", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
