using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Dersi_17_10_2025
{
    internal class Liblary
    {
        private string Name;
        public Book[] Books = [];
        public Liblary(string name)
        {
            Name = name;

        }
        public Liblary()
        {
            Name = "Unknown";

        }
        public void AddBook(Book book)
        {
            foreach (Book item in Books)
            {
                if (item.Id == book.Id)
                {
                    Console.WriteLine("Bu  kitab artiq movcuddur");
                    return;
                }
            }
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public void ShowBooks()
        {
            if (Books.Length > 0)
            {
                foreach (Book item in Books)
                {
                    item.GetInfo();
                }
            }
            else
            {
                Console.WriteLine("Kitab Yoxdur");
            }
        }
        public void RemoveBook(int id)
        {
            int index = Array.FindIndex(Books, b => b.Id == id);
            if (index != -1)
            {
                for (int i = index; i < Books.Length - 1; i++)
                {
                    Books[i] = Books[i + 1];
                }
                Array.Resize(ref Books, Books.Length - 1);
            }
        }
    }
}
