using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Mkdir: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            file.AddDirectory(input, file);
        }
    }
}