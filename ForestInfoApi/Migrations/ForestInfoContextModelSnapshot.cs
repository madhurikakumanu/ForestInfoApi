﻿// <auto-generated />
using System;
using ForestInfoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForestInfoApi.Migrations
{
    [DbContext(typeof(ForestInfoContext))]
    partial class ForestInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForestInfoApi.Models.Beat", b =>
                {
                    b.Property<int>("BeatNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BeatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("DivisionCode")
                        .HasColumnType("int");

                    b.Property<decimal>("GrossArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NetArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RangeCode")
                        .HasColumnType("int");

                    b.Property<int?>("SectionNumber")
                        .HasColumnType("int");

                    b.HasKey("BeatNumber");

                    b.HasIndex("DivisionCode");

                    b.HasIndex("RangeCode");

                    b.HasIndex("SectionNumber");

                    b.ToTable("Beat");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Block", b =>
                {
                    b.Property<int>("BlockCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlockDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("DivisionCode")
                        .HasColumnType("int");

                    b.Property<decimal>("ForestArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrossArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RangeCode")
                        .HasColumnType("int");

                    b.HasKey("BlockCode");

                    b.HasIndex("DivisionCode");

                    b.HasIndex("RangeCode");

                    b.ToTable("Block");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Compartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlockCode")
                        .HasColumnType("int");

                    b.Property<string>("CompartmentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("DivisionCode")
                        .HasColumnType("int");

                    b.Property<decimal>("GrossForestArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NetForestArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RangeCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlockCode");

                    b.HasIndex("DivisionCode");

                    b.HasIndex("RangeCode");

                    b.ToTable("Compartment");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Division", b =>
                {
                    b.Property<int>("DivisionCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DivisionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("ForestArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrossArea")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DivisionCode");

                    b.ToTable("Division");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Range", b =>
                {
                    b.Property<int>("RangeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DivisionCode")
                        .HasColumnType("int");

                    b.Property<decimal>("ForestArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrossArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RangeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RangeCode");

                    b.HasIndex("DivisionCode");

                    b.ToTable("Range");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Section", b =>
                {
                    b.Property<int>("SectionNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DivisionCode")
                        .HasColumnType("int");

                    b.Property<decimal>("GrossArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NetArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RangeCode")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SectionNumber");

                    b.HasIndex("DivisionCode");

                    b.HasIndex("RangeCode");

                    b.ToTable("Section");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Beat", b =>
                {
                    b.HasOne("ForestInfoApi.Models.Division", "Division")
                        .WithMany("Beats")
                        .HasForeignKey("DivisionCode");

                    b.HasOne("ForestInfoApi.Models.Range", "Range")
                        .WithMany("Beats")
                        .HasForeignKey("RangeCode");

                    b.HasOne("ForestInfoApi.Models.Section", "Section")
                        .WithMany("Beats")
                        .HasForeignKey("SectionNumber");

                    b.Navigation("Division");

                    b.Navigation("Range");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Block", b =>
                {
                    b.HasOne("ForestInfoApi.Models.Division", "Division")
                        .WithMany("Blocks")
                        .HasForeignKey("DivisionCode");

                    b.HasOne("ForestInfoApi.Models.Range", "Range")
                        .WithMany("Blocks")
                        .HasForeignKey("RangeCode");

                    b.Navigation("Division");

                    b.Navigation("Range");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Compartment", b =>
                {
                    b.HasOne("ForestInfoApi.Models.Block", "Block")
                        .WithMany("Compartments")
                        .HasForeignKey("BlockCode");

                    b.HasOne("ForestInfoApi.Models.Division", "Division")
                        .WithMany("Compartments")
                        .HasForeignKey("DivisionCode");

                    b.HasOne("ForestInfoApi.Models.Range", "Range")
                        .WithMany("Compartments")
                        .HasForeignKey("RangeCode");

                    b.Navigation("Block");

                    b.Navigation("Division");

                    b.Navigation("Range");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Range", b =>
                {
                    b.HasOne("ForestInfoApi.Models.Division", "Division")
                        .WithMany("Ranges")
                        .HasForeignKey("DivisionCode");

                    b.Navigation("Division");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Section", b =>
                {
                    b.HasOne("ForestInfoApi.Models.Division", "Division")
                        .WithMany("Sections")
                        .HasForeignKey("DivisionCode");

                    b.HasOne("ForestInfoApi.Models.Range", "Range")
                        .WithMany("Sections")
                        .HasForeignKey("RangeCode");

                    b.Navigation("Division");

                    b.Navigation("Range");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Block", b =>
                {
                    b.Navigation("Compartments");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Division", b =>
                {
                    b.Navigation("Beats");

                    b.Navigation("Blocks");

                    b.Navigation("Compartments");

                    b.Navigation("Ranges");

                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Range", b =>
                {
                    b.Navigation("Beats");

                    b.Navigation("Blocks");

                    b.Navigation("Compartments");

                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ForestInfoApi.Models.Section", b =>
                {
                    b.Navigation("Beats");
                });
#pragma warning restore 612, 618
        }
    }
}
