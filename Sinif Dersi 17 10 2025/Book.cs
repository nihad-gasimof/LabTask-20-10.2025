using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Dersi_17_10_2025
{
    internal class Book
    {
        private int _id;
        public string Title;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }
        public string Author;
        public int PublishYear;


        public Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            PublishYear = year;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Id: {Id}, Title: {Title}, Author: {Author}, PublishYear: {PublishYear}");

        }
    }
}
