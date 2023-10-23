using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Notebook : Product
    {

        public string _brand;
        public string Model;
        public int _ram;
        public int _storage;

        

        public Notebook(int count, int price, string model) : base(count, price)
        {
            this.Model = model;
        }

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (value.Length < 3 && value.Length > 30)
                {
                    Console.WriteLine("This Name is not acceptable");
                }
                else
                {

                    _brand = value;
                    Console.WriteLine(value);

                }

            }
        }

        public int RAM
        {
            get { return _ram; }
            set
            {
                if(value<0 && value > 128)
                {
                    Console.WriteLine("RAM is not acceptable");
                }
                else
                {
                    value = _ram;
                    Console.WriteLine(value);
                }

            }
        }

        public int Storage
        {
            get { return _storage; }
            set
            {
                if( value < 0)
                {
                    Console.WriteLine("Storage is not True");
                }
                else
                {
                    value = _storage;
                    Console.WriteLine(value);
                }
            }
        }

        public string getBrand()
        {
            return _brand;
        }
        public int getRAM()
        {
            return _ram;
        }
        public int getStorage()
        {
            return _storage;
        }
    }
}
