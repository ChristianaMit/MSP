using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Cd: Directory, IExecuter
    {
        public void Execute(string inputDir, Directory currentDir, FileSystemReader file)
        {

            foreach(var child in currentDir.children)
            {
                

            }
        }

    }
}
