﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PptNemocnice.api.Data;

#nullable disable

namespace PptNemocnice.api.Migrations
{
    [DbContext(typeof(NemocniceDbContext))]
    [Migration("20220426145423_pridani dat")]
    partial class pridanidat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("PptNemocnice.api.Data.Revize", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VybaveniId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("VybaveniId");

                    b.ToTable("Revizes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("01631c28-10e9-4a04-bcd1-91cbececad23"),
                            DateTime = new DateTime(2019, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AAA",
                            VybaveniId = new Guid("5a3ed44c-ad9a-4b9d-a1ea-b0deabeb815a")
                        },
                        new
                        {
                            Id = new Guid("aa7a1c28-10e9-4a04-bcd1-91cbececad23"),
                            DateTime = new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "BBB",
                            VybaveniId = new Guid("5a3ed44c-ad9a-4b9d-a1ea-b0deabeb815a")
                        },
                        new
                        {
                            Id = new Guid("bb0b1c28-10e9-4a04-bcd1-91cbececad23"),
                            DateTime = new DateTime(1999, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "CCC",
                            VybaveniId = new Guid("5a3ed44c-ad9a-4b9d-a1ea-b0deabeb815a")
                        });
                });

            modelBuilder.Entity("PptNemocnice.api.Data.Vybaveni", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BoughtDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vybavenis");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a3ed44c-ad9a-4b9d-a1ea-b0deabeb815a"),
                            BoughtDate = new DateTime(2018, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "XXX",
                            Price = 555
                        },
                        new
                        {
                            Id = new Guid("b88f888d-b16a-4ffc-9bd5-7f6f5cb607b9"),
                            BoughtDate = new DateTime(2018, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AZU",
                            Price = 555
                        },
                        new
                        {
                            Id = new Guid("39d4018a-ba22-4ab6-b582-0d1c35e79e45"),
                            BoughtDate = new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "JQW",
                            Price = 999
                        });
                });

            modelBuilder.Entity("PptNemocnice.api.Data.Revize", b =>
                {
                    b.HasOne("PptNemocnice.api.Data.Vybaveni", "Vybaveni")
                        .WithMany("Revizes")
                        .HasForeignKey("VybaveniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vybaveni");
                });

            modelBuilder.Entity("PptNemocnice.api.Data.Vybaveni", b =>
                {
                    b.Navigation("Revizes");
                });
#pragma warning restore 612, 618
        }
    }
}
