﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoGameApi.Data;

#nullable disable

namespace VideoGameApi.Migrations
{
    [DbContext(typeof(VideoGameDbContext))]
    [Migration("20250405131655_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VideoGameApi.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Developer = "Insomiac Games",
                            Platform = "PS5",
                            Publisher = "Sony Interactive Media",
                            Title = "Spider-Man 2"
                        },
                        new
                        {
                            Id = 2,
                            Developer = "Nintendo EPD",
                            Platform = "Nintendo Switch",
                            Publisher = "Nintedo",
                            Title = "The Legend of Zelda: Breath of the Wild"
                        },
                        new
                        {
                            Id = 3,
                            Developer = "CD Projekt Red",
                            Platform = "PC",
                            Publisher = "CD Projekt",
                            Title = "Cyberpunk 2077"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
