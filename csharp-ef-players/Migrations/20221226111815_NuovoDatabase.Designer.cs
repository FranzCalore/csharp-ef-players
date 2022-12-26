﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_ef_players;

#nullable disable

namespace csharpefplayers.Migrations
{
    [DbContext(typeof(EfPlayersContext))]
    [Migration("20221226111815_NuovoDatabase")]
    partial class NuovoDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("csharp_ef_players.Allenatore", b =>
                {
                    b.Property<int>("AllenatoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllenatoreId"));

                    b.Property<int>("GameNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("WinNumber")
                        .HasColumnType("int");

                    b.HasKey("AllenatoreId");

                    b.HasIndex("AllenatoreId");

                    b.HasIndex("TeamId")
                        .IsUnique()
                        .HasFilter("[TeamId] IS NOT NULL");

                    b.ToTable("Allenatore");
                });

            modelBuilder.Entity("csharp_ef_players.FootballPlayer", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"));

                    b.Property<int>("GameNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<double>("Vote")
                        .HasColumnType("float");

                    b.Property<int>("WinNumber")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("FootballPlayer");
                });

            modelBuilder.Entity("csharp_ef_players.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"));

                    b.Property<string>("Città")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colori")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("csharp_ef_players.Allenatore", b =>
                {
                    b.HasOne("csharp_ef_players.Team", "Team")
                        .WithOne("Allenatore")
                        .HasForeignKey("csharp_ef_players.Allenatore", "TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("csharp_ef_players.FootballPlayer", b =>
                {
                    b.HasOne("csharp_ef_players.Team", "Team")
                        .WithMany("ListaGiocatori")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("csharp_ef_players.Team", b =>
                {
                    b.Navigation("Allenatore")
                        .IsRequired();

                    b.Navigation("ListaGiocatori");
                });
#pragma warning restore 612, 618
        }
    }
}