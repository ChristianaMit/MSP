using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Echo: IExecuter
    {
        public void Execute(string input, Directory curDir, FileSystemReader file)
        {
            Console.WriteLine("{0}",input);
        }
        
    }
}
