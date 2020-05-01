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
        
        public int i;
        public string phrase;
        public int l;

        //Constructor

        public ForLoop()
        {
            i = 0;
            l = 0;
            
        }


        //Methods
        public void RunForLoop5()
        {
            string words = "Hello World";
            int count = 0;
            foreach (char c in words)
            {
                count++;
                Console.WriteLine(("") + (count - 1)); 
            }
        }
        public void RunForLoop8()
        {
            Console.WriteLine("Please enter a phrase:\n");
            string phrase = Console.ReadLine();
            
            Console.WriteLine("The Characters in the string are : \n");
            while  (l >= 0 && l < phrase.Length)
            {
                Console.WriteLine("{0}", phrase[l]);
                l++;
            }
            
        }
    }   
}
