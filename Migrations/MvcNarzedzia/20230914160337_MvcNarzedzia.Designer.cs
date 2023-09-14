﻿// <auto-generated />
using AdvancedProgramming_Lesson1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvancedProgramming_Lesson1.Migrations.MvcNarzedzia
{
    [DbContext(typeof(MvcNarzedziaContext))]
    [Migration("20230914160337_MvcNarzedzia")]
    partial class MvcNarzedzia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvancedProgramming_Lesson1.Models.Narzedzia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<int>("Dlugosc")
                        .HasColumnType("int");

                    b.Property<string>("Material_wykonania")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typ_narzedzia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Waga")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Narzedzia");
                });
#pragma warning restore 612, 618
        }
    }
}
