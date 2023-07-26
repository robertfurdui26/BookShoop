using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShoop
{
    internal class Book
    {
        public  int Id;
        public  string name;
        public string authorName;
        public string description;
        public int year;
        public int price;

        
        public void ShowBook()
        {
            Console.WriteLine(
                $"{Id}\n"+
                $"{name}\n" +
                $"{authorName}\n" +
                $"{description}\n" +
                $"{year}\n" +
                $"{price}");
        }

        public void AddBook()
        {
            Console.WriteLine("Book ID;");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Book Name;");
            name = Console.ReadLine();

            Console.WriteLine("Book AuthorName;");
            authorName = Console.ReadLine();

            Console.WriteLine("Book Description;");
            description = Console.ReadLine();

            Console.WriteLine("Book Year;");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Book price;");
            price = int.Parse(Console.ReadLine());
        }

    }
}
