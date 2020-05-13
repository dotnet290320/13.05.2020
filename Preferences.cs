using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon1305_console
{
    class Program
    {
        // preferences
        // later will be in configuration file
        const int START_NUMBER_OF_PRINTING = 1;
        const int END_NUMBER_OF_PRINTING = 100;
        const string FINISH_STRING = "Finished...";

        static void Main(string[] args)
        {

            for (int i = START_NUMBER_OF_PRINTING; i <= END_NUMBER_OF_PRINTING; i++)
            {
                Console.Write(" " + i + " ");
            }

            Console.WriteLine();

            Console.WriteLine(FINISH_STRING);
        }
    }
}
