using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = null;
            Product product = null;
            creater = new ConcreteCreater();
            product = creater.FactoryMethod();
            creater.AnOperation();
            Console.ReadKey();
        }
    }
}
