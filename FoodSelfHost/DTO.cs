﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSelfhost
{
    public class clsPlace
    {
        public string PlaceName { get; set; }
        public string Code { get; set; }
        public List<clsAllProduct> ProductsList { get; set; }
    }

    public class clsOrder
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string PlaceName { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public string Contact { get; set; }

        public DateTime Date { get; set; }
        public List<clsOrder> OrderList { get; set; }

        public override string ToString()
        {
            return OrderId.ToString() + "\t" + ProductName + "\t" + PlaceName + "\t" + Price.ToString() + "\t" + Quantity + "\t" + Contact + "\t" + Date.ToString();
        }
    }

    public class clsAllProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Instock { get; set; }
        public string PlaceName { get; set; }
        public string Category { get; set; }

        public string Freshness { get; set; }
        public string Quality { get; set; }
        public string Amount { get; set; }

        public DateTime Date { get; set; }
        
        public override string ToString()
        {
            return ProductName + "\t" + Price.ToString() + "\t" + Date.ToString();
        }

        //public static readonly string FACTORY_PROMPT = "Enter P for Painting, S for Sculpture and H for Photograph";

        public static clsAllProduct NewProduct(char prChoice)
        {
            return new clsAllProduct()
            {
                Category = char.ToUpper(prChoice).ToString()
            };
        }
    }
}
