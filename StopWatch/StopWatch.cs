using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Problems
{
    internal class StopWatch
    {
        public void Stop()
        {
            Console.WriteLine("Please Enter to Start");
            Console.ReadLine();
            DateTime Start=DateTime.Now;
            Console.WriteLine("Please Enter to Stop");
            Console.ReadLine();
            DateTime End=DateTime.Now;
            Console.WriteLine("Time Diffrance "+ (End-Start));

        }
    }
}
