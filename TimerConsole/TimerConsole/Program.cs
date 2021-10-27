using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace TimerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)sw.ElapsedMilliseconds);
            sw.Start();
            Thread.Sleep(1000);
            int min = Convert.ToInt32(ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString());
            int seg = Convert.ToInt32(ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString());
            int mil = Convert.ToInt32(ts.Milliseconds.ToString());
            for (min = 0; min < 60; min++)
            {
                for (seg= 0; seg < 60; seg++)
                {
                    Console.Clear();
                    Console.WriteLine("Cronometro");
                    Console.WriteLine("Tiempo :"+ min + ":" + seg);
                    if (seg.Equals(15))
                    {
                        sw.Stop();
                        Console.Write(sw.Elapsed.Duration());
                        Console.ReadKey();
                    }
                }
            }

            
        }
    
    }
}
