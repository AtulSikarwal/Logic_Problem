using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Problems
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter the Number ");
            int Num=Convert.ToInt32(Console.ReadLine());
            int Flag = 0;
            for(int i=2;i<Num;i++)
            {
                if(Num % i == 0)
                {
                    Console.WriteLine("Number is not Prime");
                    Flag= 1;
                    break;
                }
            }
            if (Flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
        }
    }
}
