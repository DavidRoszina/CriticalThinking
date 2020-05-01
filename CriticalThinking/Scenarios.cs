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
        public WhileLoop whileLoop;
        
        //Constructor
        public Scenarios()
        {
            forLoop = new ForLoop();
            whileLoop = new WhileLoop();
        }
        //Methods
        public void RunScenarios()
        {
            Console.WriteLine("David Roszina's Critical Thinking Worksheet");
            //forLoop.RunForLoop5();
            //forLoop.RunForLoop8();
            whileLoop.RunWhileLoop1();

        }
    }
}
