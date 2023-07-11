﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientPortal_API.Context;

#nullable disable

namespace PatientPortal_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230710122312_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PatientPortal_API.Models.AllergiesDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AllergyId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AllergyId");

                    b.HasIndex("PatientId");

                    b.ToTable("AllergiesDetails");
                });

            modelBuilder.Entity("PatientPortal_API.Models.Allergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("PatientPortal_API.Models.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("PatientPortal_API.Models.Ncd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ncd");
                });

            modelBuilder.Entity("PatientPortal_API.Models.NcdDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("NCDId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NCDId");

                    b.HasIndex("PatientId");

                    b.ToTable("NcdDetails");
                });

            modelBuilder.Entity("PatientPortal_API.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DiseaseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DiseaseId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PatientPortal_API.Models.AllergiesDetails", b =>
                {
                    b.HasOne("PatientPortal_API.Models.Allergy", "Allergy")
                        .WithMany("AllergiesDetails")
                        .HasForeignKey("AllergyId");

                    b.HasOne("PatientPortal_API.Models.Patient", "Patient")
                        .WithMany("AllergiesDetails")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Allergy");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PatientPortal_API.Models.NcdDetails", b =>
                {
                    b.HasOne("PatientPortal_API.Models.Ncd", "NCD")
                        .WithMany("NcdDetails")
                        .HasForeignKey("NCDId");

                    b.HasOne("PatientPortal_API.Models.Patient", "Patient")
                        .WithMany("NcdDetails")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NCD");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PatientPortal_API.Models.Patient", b =>
                {
                    b.HasOne("PatientPortal_API.Models.Disease", "Disease")
                        .WithMany()
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");
                });

            modelBuilder.Entity("PatientPortal_API.Models.Allergy", b =>
                {
                    b.Navigation("AllergiesDetails");
                });

            modelBuilder.Entity("PatientPortal_API.Models.Ncd", b =>
                {
                    b.Navigation("NcdDetails");
                });

            modelBuilder.Entity("PatientPortal_API.Models.Patient", b =>
                {
                    b.Navigation("AllergiesDetails");

                    b.Navigation("NcdDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
