using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject4790.Models.Domain;
 

namespace FinalProject4790.Views.ViewModels
{
    public class ProductListViewModel
    {
       public string Title { get; set; }
       public List<Product> Products { get; set; }
    }
}