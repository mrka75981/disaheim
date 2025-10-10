using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public abstract class Merchandise
    {
        public string ItemId; 

        //public Merchandise(string itemid)
        //{
        //    this.ItemId = itemid;
        //}


        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }

    }
}
