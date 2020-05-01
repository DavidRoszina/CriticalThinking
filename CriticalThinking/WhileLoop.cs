using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class WhileLoop
    {
        //member variables
        public int counter;
        //constructor
        public WhileLoop()
        {

        }
        //methods
        public void RunWhileLoop1()
        {
            Console.WriteLine("Please enter a number 42:\n");
            string enteredNumber = Console.ReadLine();
            double counter = Double.Parse(enteredNumber);
            if (counter == 42)
            {
                while (counter != 42)
                {
                    Console.WriteLine("You entered the correct number!");
                }
            }
            else
            {
                Console.WriteLine("Wrong value entered.");
                RunWhileLoop1();
            }
            

        }
    }
}
