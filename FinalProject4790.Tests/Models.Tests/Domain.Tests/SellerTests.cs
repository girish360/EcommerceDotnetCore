using System;
using NUnit.Framework;
using FinalProject4790.Controllers;
using FinalProject4790.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace FinalProject4790.Tests.Models.Domain.Tests
{
    public class SellerTests
    { 
        private Seller seller;
        [SetUp]
        public void Setup()
        {
            // Arrange
            seller = new Seller();
        }

        [Test]
        public void SellerSetGetId()
        {
            seller.SellerId = 100;

            Assert.AreEqual(seller.SellerId, 100);
        }

        [Test]
        public void SellerSetGetSellerName()
        {
            seller.SellerName = "TestName";

            Assert.AreEqual(seller.SellerName, "TestName");
        }

        [Test]
        public void SellerSetGetSellerDecription()
        {
            seller.SellerDescription = "TestName";

            Assert.AreEqual(seller.SellerDescription, "TestName");
        }

        [Test]
        public void SellerSetGetProducts()
        {
            var product = new Product();
            var products = new List<Product>();
            
            products.Add(product);

            seller.Products = products;
            Assert.AreEqual(1, seller.Products.Count);
        }
    }
}