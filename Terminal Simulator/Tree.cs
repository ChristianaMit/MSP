using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Tree: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            Console.WriteLine("{0}",input);
        }
    }
}