//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DisaHeim
//{
//    public class BookRepository
//    {
//        private List<Book> books = new List<Book>(); 



//        public void AddBook(Book book)
//        {
//            books.Add(book);
//        } 

//        public Book GetBook(string itemId)
//        {
//            Book checkbook = new Book(itemId);

//            foreach (Book book in books)
//            {
//                if (book.ItemId == checkbook.ItemId)
//                {
//                    return book;
//                }
//            }
//            return null;
//        } 

//        public double GetTotalValue()
//        {
//            double totalvalue = 0;
//            Utility utiltiy = new Utility();
//            foreach(Book book in books)
//            {
//                totalvalue += utiltiy.GetValueOfBook(book);
//            }
//            return totalvalue;
//        }


//    }
//}
