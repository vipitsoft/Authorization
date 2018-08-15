﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Authorization.Migrations
{
    [DbContext(typeof(AuthorizationDBContext))]
    [Migration("20180802064319_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasMaxLength(100);

                    b.Property<string>("UserName")
                        .HasColumnName("user_name")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}