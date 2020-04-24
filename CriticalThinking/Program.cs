using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Program
    {
        static void Main(string[] args)
        {
            Scenarios thing = new Scenarios();
            thing.RunScenarios();
            Console.ReadLine();
        }
    }
}
