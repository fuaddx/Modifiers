using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Product 
    {
        //field
        public int _count;
        public int _price;

        
        public Product(int count,int price) { 
            this._count = count;
            this._price = price;
        }
        //modifiers
        public int Count { get { return _count;}
        
            set { 
                   if(value< 0)
                {
                    Console.WriteLine("Count is not acceptable");
                }
                else
                {
                    _count = value;
                    Console.WriteLine(value);
                }
            }
        }

        public int Price
        {
            get { return _price; }
            set {; }
        }

        public int getCount()
        {
            return _count;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
