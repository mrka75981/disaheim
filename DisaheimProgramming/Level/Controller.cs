﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Controller
    {
        public List<Book> Books { get; private set; } 
        public List<Amulet> Amulets { get; private set; }

        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
        }


        public void AddToList(Book book)
        {
            Books.Add(book);
        } 

        public void AddToList(Amulet amulet)
        {

            Amulets.Add(amulet);
        }

    }
}
