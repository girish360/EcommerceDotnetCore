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
    [Migration("20180409195306_RenamedCartLineITem")]
    partial class RenamedCartLineITem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("FinalProject4790.Models.Domain.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CartItemProductId");

                    b.Property<int>("CartItemQuantity");

                    b.Property<string>("CartShoppingCartId");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartItemProductId");

                    b.ToTable("CartItems");
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

            modelBuilder.Entity("FinalProject4790.Models.Domain.CartItem", b =>
                {
                    b.HasOne("FinalProject4790.Models.Domain.Product", "CartItemProduct")
                        .WithMany()
                        .HasForeignKey("CartItemProductId")
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
