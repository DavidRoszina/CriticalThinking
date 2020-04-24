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
        public int wordLength;
        public string words;
        public int i;
        //Constructor

        public ForLoop()
        {
            i = 0;
            
            
        }


        //Methods
        public void RunForLoop()
        {
            string words = "Hello World";
            int count = 0;
            foreach (char c in words)
            {
                count++;
                Console.WriteLine(("") + (count - 1)); 
            }
        }
    }   
}
