namespace Logic_Problems
{
    class Problem
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Choose a number  go to  the respective number");
            Console.WriteLine("1 is for Perfect Number");
            Console.WriteLine("2 is for Reverse Number");
            Console.WriteLine("3 is for Prime Number");
            Console.WriteLine("4 is for Fibonacci Series");
            Console.WriteLine("5 is for StopWatch");


            int Option=Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    PerfectNumber Perfect = new PerfectNumber();
                    Perfect.PerfectNum();
                    break;
                case 2:
                    Reverse Rev=new Reverse();
                    Rev.ReverseNumber();
                    break;
                case 3:
                    PrimeNumber Prime=new PrimeNumber();
                    Prime.Prime();
                    break;
                case 4:
                    Fibonacci Fibo=new Fibonacci();
                    Fibo.Fib();
                    break;
                case 5:
                    StopWatch StopWatch = new StopWatch();
                    StopWatch.Stop();
                    break;
            }
        }

    }
}