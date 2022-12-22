﻿// <auto-generated />
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
    [Migration("20221222133708_PlayerDB")]
    partial class PlayerDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("csharp_ef_players.FootballPlayer", b =>
                {
                    b.Property<int>("player_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("player_Id"));

                    b.Property<int>("gameNumber")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vote")
                        .HasColumnType("int");

                    b.Property<int>("winNumber")
                        .HasColumnType("int");

                    b.HasKey("player_Id");

                    b.HasIndex("player_Id");

                    b.ToTable("FootballPlayer");
                });
#pragma warning restore 612, 618
        }
    }
}
