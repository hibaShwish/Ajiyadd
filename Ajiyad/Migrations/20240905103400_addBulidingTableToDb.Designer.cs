﻿// <auto-generated />
using Ajiyad.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ajiyad.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240905103400_addBulidingTableToDb")]
    partial class addBulidingTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.7.24405.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ajiyad.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("client")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consultant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cost")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BuildingDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
