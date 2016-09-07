using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BartenderApp.Models;

namespace BartenderApp.ViewModels
{
    public class RandomDrinksViewModel
    {
        public Drinks Drinks { get; set; }
        public List<Customer>Customer { get; set; }
    }
    
}