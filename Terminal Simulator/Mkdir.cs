using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Mkdir: IExecuter
    {
        public void Execute(string input, Directory curDir)
        {
            Console.WriteLine("{0}",input);
        }
        
    }
}