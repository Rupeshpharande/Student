using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Book
    {
       int bid;
        string Name;
        double Price;
        String Author;

        public Book(int id, string name, double price, string author)
        {
            bid = id;
            Name = name;
            Price = price;
            Author = author;
            Console.WriteLine(Display());
        }

        public string Display()
        {
            return $" bid={bid},name={Name},Price={Price},Author={Author}";
        }



    }
}
