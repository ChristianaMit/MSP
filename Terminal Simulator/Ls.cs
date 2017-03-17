using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Ls: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            if(input != null)
                Console.Write("Error: command doesn't accept parameters");
            
            else{
                for(int i=0; i<file.curentDirectory.children.Count; i++){
                    Console.WriteLine("{0}",file.curentDirectory.children[i].name);
                }
            }
        }
    }
}