using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace BookShoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BookShoop Management");
            
           
            Book[] book = new Book[1];
            for(int i  = 0; i < book.Length; i++)
            {
                book[i] = Controller();
            }

            foreach(Book book1 in book)
            {
                book1.ShowBook();
            }

            Console.WriteLine();
;        }
        static Book Controller( )
        {
            Book result = new Book();

            result.AddBook();

            return result;
        }

       
    }
}