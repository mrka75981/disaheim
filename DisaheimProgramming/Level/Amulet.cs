﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Amulet: Merchandise
    {
        //private string _ItemId;
        //public override string ItemId 
        //{ get => _ItemId; set => _ItemId = value; }
        
        
        public string Design;
        public Level? Quality;

        public Amulet(string itemid, Level? quality, string design)
        {
            this.ItemId = itemid;
            this.Quality = quality;
            this.Design = design;
        }

        public Amulet(string itemid, Level? quality): 
            this(itemid,quality,null)
        {}

        public Amulet(string itemid):
            this(itemid,Level.Medium,null)
       
        {}

    


        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
    
}
