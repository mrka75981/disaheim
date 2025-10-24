//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DisaHeim
//{
//    public class Utility
//    {
//        public double GetValueOfBook(Book book)
//        {

//            return book.Price;
//        }

//        public double GetValueOfAmulet(Amulet amulet)
//        {
//            double value = 0;
//            if (amulet.Quality == Level.Low)
//            {
//                value = 12.5;
//            }
//            else if (amulet.Quality == Level.Medium)
//            {
//                value = 20.0;
//            }
//            else if (amulet.Quality == Level.High)
//            {
//                value = 27.5;
//            }

//            return value;
//        }

//        public double GetValueOfCourse(Course course)
//        {
//            int WholeHour = course.DurationInMinutes / 60;
//            int RemainingMinutes = course.DurationInMinutes % 60;

//            if (RemainingMinutes > 0)
//            {
//                WholeHour++;
//            }


//            return WholeHour * 875.00;
//        }

//        public double? GetValueOfMerchandise(Merchandise merchandise)
//        {
//            double sum = 0;
//            Utility utility = new Utility();
//            switch (merchandise)
//            {
//                case Book book:
//                    return sum += utility.GetValueOfBook(book);
//                case Amulet amulet:
//                    return sum += utility.GetValueOfAmulet(amulet);
//            } 

//            return sum;
            

//        }
//    }
//}
