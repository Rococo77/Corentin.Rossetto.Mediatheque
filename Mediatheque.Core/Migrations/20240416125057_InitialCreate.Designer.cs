﻿// <auto-generated />
using Mediatheque.Core.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mediatheque.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240416125057_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Mediatheque.Core.Model.CD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Emprunteur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Groupe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TitreDeLObjet")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CDs");
                });

            modelBuilder.Entity("Mediatheque.Core.Model.JeuxDeSociete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgeMaximum")
                        .HasColumnType("int");

                    b.Property<int>("AgeMinimum")
                        .HasColumnType("int");

                    b.Property<string>("Editeur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Emprunteur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TitreDeLObjet")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TypeJeux")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Jeux");
                });
#pragma warning restore 612, 618
        }
    }
}
