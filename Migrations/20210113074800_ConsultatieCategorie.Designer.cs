﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pop_Simona_Proiect1.Data;

namespace Pop_Simona_Proiect1.Migrations
{
    [DbContext(typeof(Pop_Simona_Proiect1Context))]
    [Migration("20210113074800_ConsultatieCategorie")]
    partial class ConsultatieCategorie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pop_Simona_Proiect1.Models.ProgramareMedic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataConsult")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeMedic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PretConsult")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<string>("Specializare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpitalID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SpitalID");

                    b.ToTable("ProgramareMedic");
                });

            modelBuilder.Entity("Pop_Simona_Proiect1.Models.Spital", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeSpital")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Spital");
                });

            modelBuilder.Entity("Pop_Simona_Proiect1.Models.ProgramareMedic", b =>
                {
                    b.HasOne("Pop_Simona_Proiect1.Models.Spital", "Spital")
                        .WithMany("Programari")
                        .HasForeignKey("SpitalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
