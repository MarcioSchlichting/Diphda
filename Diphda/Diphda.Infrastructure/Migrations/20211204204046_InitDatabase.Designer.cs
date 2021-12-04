﻿// <auto-generated />
using Diphda.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Diphda.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211204204046_InitDatabase")]
    partial class InitDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("DIPHDA_PUBLIC")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Diphda.Domain.Account.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("BIT")
                        .HasColumnName("ACTIVE");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("USERNAME");

                    b.HasKey("Id");

                    b.ToTable("USER");
                });
#pragma warning restore 612, 618
        }
    }
}