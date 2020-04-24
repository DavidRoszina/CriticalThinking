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
        public string name;
        public int i;
        //Constructor

        public ForLoop(string name)
        {
            i = 0;
        }


        //Methods
        public void RunForLoop()
        {
            for (int i = 0; i < 5;)
            {
                while (i < 5)
                {
                    Console.WriteLine(("") + i) ;
                    i++;
                }
            }
        }
    }   
}
