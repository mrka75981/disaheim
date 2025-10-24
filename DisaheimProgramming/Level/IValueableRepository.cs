using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DisaHeim
{
    public class IValueableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValueable(IValuable valuable)
        {
            valuables.Add(valuable);
        } 

        public IValuable GetValuable(string itemid)
        {
            foreach (IValuable valueable in valuables)
            {
                if (valueable is Merchandise merch && merch.ItemId == itemid)
                {
                    return valueable;
                }

                if (valueable is Course course && course.Name == itemid)
                {
                    return valueable;
                }

            }

            return null;
        } 

        public double GetTotalValue()
        {
            double totalvalue = 0;
            foreach (IValuable valuable in valuables)
            {
                totalvalue += valuable.GetValue();
            }
            return totalvalue;
        } 

        public int Count()
        {
            return valuables.Count();
        }

        public void Save()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\ValuableRepository.txt");
                sw.WriteLine("Book;Id3;Spirits in the Night;123.55");
                sw.Close();
            } 
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Save(string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter($"C:\\{fileName}" + ".txt");
                sw.WriteLine("Book;Id4;Spirits in the Morning;124.55");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Load()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\ValuableRepository.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    string cut = line.Trim(';');

                    IValuable iv = GetValuable(cut);
                    valuables.Add(iv);

                    line = sr.ReadLine();
                }

                
                sr.Close();
            } 
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            

            
        }

        public void Load(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
