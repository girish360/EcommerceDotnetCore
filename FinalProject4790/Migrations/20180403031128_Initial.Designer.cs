﻿// <auto-generated />
using FinalProject4790.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FinalProject4790.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180403031128_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("FinalProject4790.Models.Domain.LineItem", b =>
                {
                    b.Property<int>("LineItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LineItemQuantity");

                    b.Property<int>("ProductId");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("LineItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("LineItems");
                });

            modelBuilder.Entity("FinalProject4790.Models.Domain.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsEdible");

                    b.Property<int>("ProductCount");

                    b.Property<string>("ProductImgUrl");

                    b.Property<string>("ProductLongDescription");

                    b.Property<string>("ProductName");

                    b.Property<decimal>("ProductPrice");

                    b.Property<string>("ProductShortDescription");

                    b.Property<int>("SellerId");

                    b.HasKey("ProductId");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FinalProject4790.Models.Domain.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SellerDescription");

                    b.Property<string>("SellerName");

                    b.HasKey("SellerId");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("FinalProject4790.Models.Domain.LineItem", b =>
                {
                    b.HasOne("FinalProject4790.Models.Domain.Product", "LineItemProduct")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject4790.Models.Domain.Product", b =>
                {
                    b.HasOne("FinalProject4790.Models.Domain.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
