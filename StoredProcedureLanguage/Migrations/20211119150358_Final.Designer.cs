﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoredProcedureLanguage.Data;

namespace StoredProcedureLanguage.Migrations
{
    [DbContext(typeof(StoredProcedureDBContext))]
    [Migration("20211119150358_Final")]
    partial class Final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoredProcedureLanguage.Models.Language", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainAreal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speakers")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("Language");
                });
#pragma warning restore 612, 618
        }
    }
}