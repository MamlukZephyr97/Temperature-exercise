using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Temperature
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature right now?");
            int temperature = Convert.ToInt32(Console.ReadLine());
            if (temperature < 20)
            {
                Console.WriteLine("It is cold!");
            }
            else if (temperature >= 20 & temperature <= 35)
            {
                Console.WriteLine("Nice day!");
            }
            else if (temperature > 35)
            {
                Console.WriteLine("It is hot!");
            }
            Console.ReadLine ();
        }
    }
}
