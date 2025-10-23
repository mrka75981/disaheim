//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DisaHeim
//{
//    public class AmuletRepository
//    {
//        private List<Amulet> amulets = new List<Amulet>();



//        public void AddAmulet(Amulet amulet)
//        {
//            amulets.Add(amulet);
//        }

//        public Amulet GetAmulet(string itemId)
//        {
//            Amulet checkamulet = new Amulet(itemId);

//            foreach (Amulet amulet in amulets)
//            {
//                if (amulet.ItemId == checkamulet.ItemId)
//                {
//                    return amulet;
//                }
//            }
//            return null;
//        }

//        public double GetTotalValue()
//        {
//            double totalvalue = 0;
//            Utility utiltiy = new Utility();
//            foreach (Amulet amulet in amulets)
//            {
//                totalvalue += utiltiy.GetValueOfAmulet(amulet);
//            }
//            return totalvalue;
//        }
//    }
//}
