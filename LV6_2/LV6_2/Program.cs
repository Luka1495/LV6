using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.AddProduct(new Product("Rumenko", 2.50));
            box.AddProduct(new Product("King", 6.00));
            box.AddProduct(new Product("Njofra", 4.00));

            BoxIterator iterator = new BoxIterator(box);
            
            while (iterator.isDone == false)
            {
                Console.WriteLine(iterator.Current.ToString());
                iterator.Next();
            }
        }
    }
}
