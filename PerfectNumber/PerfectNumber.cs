using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Problems
{
    internal class PerfectNumber
    {
        public bool Factors(int Number, int Potential_Factor)
        {
            if(Number % Potential_Factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PerfectNum()
        {
            int Check=0;
            Console.WriteLine("Enter the Number You want to cheak : ");
            int Number=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=Number/2;i++)
            {
                if(Factors(Number,i))
                {
                    Check += i;
                }
            }
            if (Check == Number)
            {
                Console.WriteLine(Number + "  is a perfect number");
            }
            else
            {
                Console.WriteLine(Number + " is a not perfect number");

            }
        }
    }
}
