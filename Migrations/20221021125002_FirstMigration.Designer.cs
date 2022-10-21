﻿// <auto-generated />
using ForumWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForumWebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221021125002_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ForumWebAPI.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("categoria")
                        .HasColumnType("int");

                    b.Property<string>("threadId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("threadId");

                    b.ToTable("Posts", (string)null);
                });

            modelBuilder.Entity("ForumWebAPI.Models.Thread", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Threads", (string)null);
                });

            modelBuilder.Entity("ForumWebAPI.Models.Post", b =>
                {
                    b.HasOne("ForumWebAPI.Models.Thread", "thread")
                        .WithMany()
                        .HasForeignKey("threadId");

                    b.Navigation("thread");
                });
#pragma warning restore 612, 618
        }
    }
}