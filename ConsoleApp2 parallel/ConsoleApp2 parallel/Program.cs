using System.Threading.Tasks;
namespace ConsoleApp2_parallel
{
    using System;

    class Program
    {
        static void Main()
        {
            DateTime StartDateTime = DateTime.Now;
           
            Parallel.For(0, 10, i =>
            {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            });
            DateTime EndDateTime = DateTime.Now;
          
            TimeSpan span = EndDateTime - StartDateTime;
            int ms = (int)span.TotalMilliseconds;
            Console.WriteLine(@"Time Taken to Execute the Loop in miliseconds {0}", ms);


        }
        static long DoSomeIndependentTask()
        {
            
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
