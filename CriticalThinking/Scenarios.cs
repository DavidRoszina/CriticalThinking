using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Scenarios
    {
        //Member Variables
        public ForLoop forLoop;
        
        //Constructor
        public Scenarios()
        {
            forLoop = new ForLoop("Running Loop");
        }
        //Methods
        public void RunScenarios()
        {
            Console.WriteLine("David Roszina's Critical Thinking Worksheet");
            forLoop.RunForLoop();
            
        }
    }
}
