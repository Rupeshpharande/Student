using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Product
    {
        int Code;
        string Name;
        double Price;
        double Dis;
        
        public Product(int code, string name,double p)
        {
            Code = code;
            Name = name;
             Price = p;
        }

        public void Discount()
        {
            if(Price>1000)
            {
                Dis = Price * 0.10;
                Price = Price - Dis;

            }
        }
        public string Display()
        {
            return $"code ={Code},name={Name} price={Price}";
        }

    }
}
