﻿// <auto-generated />
using System;
using Application_GS_ecole.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApplicationGSecole.Migrations
{
    [DbContext(typeof(Mvcecolecontext))]
    [Migration("20231210182344_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Application_GS_ecole.Models.Admin", b =>
                {
                    b.Property<Guid>("Id_Admin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Admin");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Application_GS_ecole.Models.Cours", b =>
                {
                    b.Property<Guid>("Id_cours")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_cours");

                    b.ToTable("Cours");
                });

            modelBuilder.Entity("Application_GS_ecole.Models.Etudiant", b =>
                {
                    b.Property<Guid>("Id_Etudiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GroupeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("GroupeId_Groupe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Note1")
                        .HasColumnType("float");

                    b.Property<double>("Note2")
                        .HasColumnType("float");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Etudiant");

                    b.HasIndex("GroupeId_Groupe");

                    b.ToTable("Etudiants");
                });

            modelBuilder.Entity("Application_GS_ecole.Models.Groupe", b =>
                {
                    b.Property<Guid>("Id_Groupe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CoursId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroDeGroupe")
                        .HasColumnType("int");

                    b.HasKey("Id_Groupe");

                    b.ToTable("Groupes");
                });

            modelBuilder.Entity("Application_GS_ecole.Models.Prof", b =>
                {
                    b.Property<Guid>("Id_Prof")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CoursId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Prof");

                    b.ToTable("Profs");
                });

            modelBuilder.Entity("Application_GS_ecole.Models.Etudiant", b =>
                {
                    b.HasOne("Application_GS_ecole.Models.Groupe", null)
                        .WithMany("Etudiants")
                        .HasForeignKey("GroupeId_Groupe");
                });

            modelBuilder.Entity("Application_GS_ecole.Models.Groupe", b =>
                {
                    b.Navigation("Etudiants");
                });
#pragma warning restore 612, 618
        }
    }
}
