using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.CalculatorService1Client calc = new ServiceReference1.CalculatorService1Client();

            Console.WriteLine(calc.Add(3, 3));
        }
    }
}
