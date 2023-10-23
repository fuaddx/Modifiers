using ConsoleApp3.Models;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter brand: ");
            string inputBrand = Console.ReadLine();
            Notebook notebook = new Notebook(2, 122, "Zenbook");
            notebook._brand = inputBrand;



           
           



        }
    }
}