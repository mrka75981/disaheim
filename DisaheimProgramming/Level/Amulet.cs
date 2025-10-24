using System;
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
        public Level? Quality { get; set; }
        static double LowQualityValue { get; set; } = 12.5;
        static double MediumQualityValue { get; set; } = 20.0;
        static double HighQualityValue { get; set; } = 27.5;

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

    
        public override double GetValue()
        {
            double value = 0;
            switch (Quality)
            {
                case Level.Low:
                    value = LowQualityValue;
                    return value;
                case Level.Medium:
                    value = MediumQualityValue;
                    return value;
                case Level.High:
                    value = HighQualityValue;
                    return value;


            }

            return value;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
    
}
