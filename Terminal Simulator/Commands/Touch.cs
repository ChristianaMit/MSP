using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Touch: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            file.AddFile(input, "\n", file);
        }
    }
}