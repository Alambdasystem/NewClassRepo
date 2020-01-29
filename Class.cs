using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 1;
            int freq = 0;
            int Dur = 0;
            string MyName = "James";
            while(true)
            {

                freq = +12;
                Dur = +3 * freq;
                Console.Beep(freq, Dur);

            }

        }
    }
}
