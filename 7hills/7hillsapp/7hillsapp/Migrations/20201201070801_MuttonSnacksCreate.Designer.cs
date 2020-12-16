﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _7hillsapp.Models;

namespace _7hillsapp.Migrations
{
    [DbContext(typeof(_7HillsDBContext))]
    [Migration("20201201070801_MuttonSnacksCreate")]
    partial class MuttonSnacksCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_7hillsapp.Models.BiryaniModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("biryaniModels");
                });

            modelBuilder.Entity("_7hillsapp.Models.ChickenSnacksModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("chickenSnacks");
                });

            modelBuilder.Entity("_7hillsapp.Models.DB7Hills", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("DB7Hills");
                });

            modelBuilder.Entity("_7hillsapp.Models.DB7HillsInsertItems", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.ToTable("DB7HillsInsertItems");
                });

            modelBuilder.Entity("_7hillsapp.Models.DB7HillsItems", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("item_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("item_name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("DB7HillsItems");
                });

            modelBuilder.Entity("_7hillsapp.Models.DB7HillsItemsNew", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("DB7HillsItemsNews");
                });

            modelBuilder.Entity("_7hillsapp.Models.MenuModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("_7hillsapp.Models.MuttonSnacksModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("muttonSnacks");
                });

            modelBuilder.Entity("_7hillsapp.Models.OwnerDetailsModel", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OwnerAdress")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerEmail")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerPassword")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerUserName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("OwnerId");

                    b.ToTable("OwnerDetailsModels");
                });

            modelBuilder.Entity("_7hillsapp.Models.SignupModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.Property<string>("PassWord")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("signupModels");
                });

            modelBuilder.Entity("_7hillsapp.Models.VegCurries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("vegCurries");
                });

            modelBuilder.Entity("_7hillsapp.Models.VegSnacksModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("vegSnacks");
                });
#pragma warning restore 612, 618
        }
    }
}
