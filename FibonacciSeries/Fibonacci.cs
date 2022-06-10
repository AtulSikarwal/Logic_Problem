using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Problems
{
    internal class Fibonacci
    {
        public void Fib()
        {
            Console.WriteLine("Enter the Number");
            int Number=Convert.ToInt32(Console.ReadLine());
            int Number1 = 0;
            int Number2 = 1;
            int Number3;
            for(int i=2; i<Number; ++i)
            {
                Number3 = Number1 + Number2;
                Console.WriteLine(Number3 + " ");
                Number1= Number2;
                Number2=Number3;
            }
        }
    }
}
