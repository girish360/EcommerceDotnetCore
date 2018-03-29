using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using final_project_ethanbrown3.Models;
using final_project_ethanbrown3.ViewModels;

namespace final_project_ethanbrown3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly IProductRepository _productRepository;


        public HomeController(ISellerRepository sellerRepository, IProductRepository productRepository)  // Constructor Injection
        {
            _sellerRepository = sellerRepository; 
            _productRepository = productRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var sellers = _sellerRepository.GetAllSellers().OrderBy(s => s.SellerName);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome",
                Sellers = sellers.ToList()
            };
            
            return View(homeViewModel);
        }

        public IActionResult ProductList(int id)
        {
            var products = _productRepository.GetProductsBySellerId(id).OrderBy(p => p.ProductName );
            Console.Write(id);
            if (products == null)
                return NotFound();

            var productListViewModel = new ProductListViewModel()
            {
                Title = "Products",
                Products = products.ToList()
            };
            
            return View(productListViewModel);
        }
    }
}