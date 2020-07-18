using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Book
    {
        //private int bookId;

        //public void setBookId(int bookId)
        //{
        //    this.bookId = bookId;
        //}

        //public int getBookId()
        //{
        //    return bookId;
        //}
        public int a;

        public int BookId { get; set; }

        public  string BookName { get; set; }
        public  string  AutherName { get; set; }
        public string  Category { get; set; }
        public int Price { get; set; }

        

    }





    class Learning
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Console.WriteLine("Enter Book NAme");
            b1.BookName = Console.ReadLine();
            Console.WriteLine("Enter book price");
            b1.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter auther name");
            b1.AutherName = Console.ReadLine();

            // b1.tax= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t\t\t\tOutput\n\n\n");
            Console.WriteLine("BookName      "+b1.BookName);
            Console.WriteLine("Auther     " + b1.AutherName);
            Console.WriteLine("Price         "+b1.Price);


        }
    }
}
