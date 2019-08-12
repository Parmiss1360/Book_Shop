﻿// <auto-generated />
using System;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookShop.Migrations
{
    [DbContext(typeof(BookShopContext))]
    [Migration("20180918144343_Add_PublisherTB")]
    partial class Add_PublisherTB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookShop.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookShop.Models.Author_Book", b =>
                {
                    b.Property<int>("BookID");

                    b.Property<int>("AuthorID");

                    b.HasKey("BookID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Author_Books");
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("File");

                    b.Property<string>("ISBN");

                    b.Property<byte[]>("Image")
                        .HasColumnType("image");

                    b.Property<int>("LanguageID");

                    b.Property<int>("NumOfPages");

                    b.Property<int>("Price");

                    b.Property<int?>("PublisherID");

                    b.Property<int>("SCategoryID");

                    b.Property<int>("Stock");

                    b.Property<string>("Summary");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<short>("Weight");

                    b.HasKey("BookID");

                    b.HasIndex("LanguageID");

                    b.HasIndex("PublisherID");

                    b.HasIndex("SCategoryID");

                    b.ToTable("BookInfo");
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookShop.Models.City", b =>
                {
                    b.Property<int>("CityID");

                    b.Property<string>("CityName");

                    b.Property<int?>("ProviceProvinceID");

                    b.HasKey("CityID");

                    b.HasIndex("ProviceProvinceID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BookShop.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<int>("Age");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("CityID1");

                    b.Property<int>("CityID2");

                    b.Property<string>("FirstName");

                    b.Property<string>("Image");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<string>("Tell");

                    b.HasKey("CustomerID");

                    b.HasIndex("CityID1");

                    b.HasIndex("CityID2");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookShop.Models.Discount", b =>
                {
                    b.Property<int>("BookID");

                    b.Property<DateTime?>("EndDate");

                    b.Property<byte>("Percent");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("BookID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("BookShop.Models.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName");

                    b.HasKey("LanguageID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("BookShop.Models.Order", b =>
                {
                    b.Property<string>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AmountPaid");

                    b.Property<DateTime>("BuyDate");

                    b.Property<string>("CustomerID");

                    b.Property<string>("DispatchNumber");

                    b.Property<int?>("OrderStatusID");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("OrderStatusID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookShop.Models.Order_Book", b =>
                {
                    b.Property<string>("OrderID");

                    b.Property<int>("BookID");

                    b.HasKey("OrderID", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("Order_Books");
                });

            modelBuilder.Entity("BookShop.Models.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderStatusName");

                    b.HasKey("OrderStatusID");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("BookShop.Models.Provice", b =>
                {
                    b.Property<int>("ProvinceID");

                    b.Property<string>("ProvinceName");

                    b.HasKey("ProvinceID");

                    b.ToTable("Provices");
                });

            modelBuilder.Entity("BookShop.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PublisherName");

                    b.HasKey("PublisherID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("BookShop.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID");

                    b.Property<string>("SubCategoryName");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("BookShop.Models.Author_Book", b =>
                {
                    b.HasOne("BookShop.Models.Author", "Author")
                        .WithMany("Author_Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookShop.Models.Book", "Book")
                        .WithMany("Author_Books")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.HasOne("BookShop.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookShop.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");

                    b.HasOne("BookShop.Models.SubCategory", "SubCategory")
                        .WithMany("Books")
                        .HasForeignKey("SCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookShop.Models.City", b =>
                {
                    b.HasOne("BookShop.Models.Provice", "Provice")
                        .WithMany("City")
                        .HasForeignKey("ProviceProvinceID");
                });

            modelBuilder.Entity("BookShop.Models.Customer", b =>
                {
                    b.HasOne("BookShop.Models.City", "city1")
                        .WithMany("Customers1")
                        .HasForeignKey("CityID1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookShop.Models.City", "city2")
                        .WithMany("Customers2")
                        .HasForeignKey("CityID2")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BookShop.Models.Discount", b =>
                {
                    b.HasOne("BookShop.Models.Book", "Book")
                        .WithOne("Discount")
                        .HasForeignKey("BookShop.Models.Discount", "BookID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookShop.Models.Order", b =>
                {
                    b.HasOne("BookShop.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");

                    b.HasOne("BookShop.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusID");
                });

            modelBuilder.Entity("BookShop.Models.Order_Book", b =>
                {
                    b.HasOne("BookShop.Models.Book", "Book")
                        .WithMany("Order_Books")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookShop.Models.Order", "Order")
                        .WithMany("Order_Books")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookShop.Models.SubCategory", b =>
                {
                    b.HasOne("BookShop.Models.Category", "Category")
                        .WithMany("SubCategory")
                        .HasForeignKey("CategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
