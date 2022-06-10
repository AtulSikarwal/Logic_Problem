using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Problems
{
    internal class Reverse
    {
        public void ReverseNumber()
        {
            Console.WriteLine("Enter the Number ");
            int Number=Convert.ToInt32(Console.ReadLine());
            int Reversed_Number = 0;

            string Digits=Convert.ToString(Number);

            for(int i=Digits.Length-1; i>=0; i--)
            {
                Reversed_Number += (Number % 10) * (int)Math.Pow(10, i);
                Number= Number / 10;
            }
            Console.WriteLine("The Reverse of  given number is "+Reversed_Number);
        }
    }
}
