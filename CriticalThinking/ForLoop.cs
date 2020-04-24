using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class ForLoop
    {
        //Member Variables
        public int userNumber;
        public int i;
        //Constructor

        public ForLoop()
        {
            i = 0;
            userNumber = 0;
        }


        //Methods
        public void RunForLoop()
        {
            Console.WriteLine("Please input a positive number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            

            for (i = 0; i < (userNumber + 1); i++)
            {
                Console.WriteLine(("") + i); 
            }
        }
    }   
}
