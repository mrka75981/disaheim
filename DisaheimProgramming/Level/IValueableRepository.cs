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

        public void Save(string fileName = "ValuableRepository.txt")
        {
            try
            {
                using StreamWriter sw = new StreamWriter(fileName, false);
                foreach (IValuable valuable in valuables)
                {
                    switch (valuable)
                    {
                        case Book book:
                            sw.WriteLine($"Book;{book.ItemId};{book.Title};{book.Price}");
                            break;
                        case Amulet amulet:
                            sw.WriteLine($"Amulet;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                            break;
                        case Course course:
                            sw.WriteLine($"Course;{course.Name};{course.DurationInMinutes}");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Save()
        {
            Save("ValuableRepository.txt");
        }

        public void Load(string fileName = "ValuableRepository.txt")
        {
            valuables.Clear();
            try
            {
                using StreamReader sr = new StreamReader(fileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 0) continue;

                    switch (parts[0])
                    {
                        case "Book":
                            // Book;ItemId;Title;Price
                            valuables.Add(new Book(parts[1], parts[2], double.Parse(parts[3])));
                            break;
                        case "Amulet":
                            // Amulet;ItemId;Level;Design
                            valuables.Add(new Amulet(parts[1], Enum.Parse<Level>(parts[2]), parts[3]));
                            break;
                        case "Course":
                            // Course;Name;DurationInMinutes
                            valuables.Add(new Course(parts[1], int.Parse(parts[2])));
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Load()
        {
            Load("ValuableRepository.txt");
        }
    }
}
