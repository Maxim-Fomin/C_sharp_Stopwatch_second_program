using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_SimpleCode_OtherMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

            sw.Stop();

            Console.WriteLine($"Time Spend: {sw.ElapsedMilliseconds}");

            sw.Restart();

            System.Threading.Thread.Sleep(555);

            sw.Stop();

            Console.WriteLine($"Time Spend: {sw.Elapsed}");

            Console.ReadLine();
        }
    }
}
"# C_sharp_Stopwatch_second_program" 
"# C_sharp_Stopwatch_second_program" 
