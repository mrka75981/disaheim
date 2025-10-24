﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Book : Merchandise
    {
        //private string _ItemId;
        
        //public override string ItemId { get => _ItemId; set => _ItemId = value; }
        
        public string Title;
        
        public double Price { get; set; }

        public Book(string itemid, string title, double price)
        {
            this.ItemId = itemid;
            this.Title = title;
            this.Price = price;

        }

        public Book(string itemid, string title): 
            this(itemid,title,0)
        {}
        public Book(string itemid): 
            this(itemid, null, 0)
        {}

        public override double GetValue()
        {
            return Price;  
        }
        

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }



    }
}
