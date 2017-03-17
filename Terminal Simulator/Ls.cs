using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Ls: IExecuter
    {
        public void Execute(string input, Directory curDir, FileSystemReader file)
        {
            if(input != null)
                Console.Write("Error: command doesn't accept parameters");
            
            else{
                for(int i=0; i<curDir.children.Count; i++){
                    Console.WriteLine("{0}\n",curDir.children[i].name);
                }
            }
        }
    }
}