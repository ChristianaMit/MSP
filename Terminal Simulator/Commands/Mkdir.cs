using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Mkdir: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            int verifier = 0;
            if( input == null)
                Console.WriteLine("Invalid directory name.");
            
            else{
                if(file.curentDirectory.children != null)
                    foreach(var child in file.curentDirectory.children)
                        if(input.Equals(child.name)){
                            Console.WriteLine("File already exists!");
                            verifier = 1;
                            break;
                        }
                if(verifier == 0)
                    file.AddDirectory(input, file);
            }                
        }
    }
}