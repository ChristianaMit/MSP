using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Touch: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            int verifier = 0;
            if(input == null){
                Console.WriteLine("Invalide command.");
                verifier = 1;
            }

            else{
                foreach(var child in file.curentDirectory.children)
                    if(input.Equals(child.name)){
                        Console.WriteLine("File already exists!");
                        verifier = 1;
                        break;
                    }
                if(verifier == 0)
                    file.AddFile(input, "\n", file);
            }
        }
    }
}