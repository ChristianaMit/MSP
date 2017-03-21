using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Rm: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            int verifier = 0;
            if(input == null){
                Console.WriteLine("Invalid parameter!");
                verifier = 1;
            }

            else{
                foreach(var child in file.curentDirectory.children){
                    if(input.Equals(child.name))
                    {
                        verifier = 2;
                        file.curentDirectory.RemoveChid(child);
                        
                        int index = 0;
                        for(int i = 0; i<file.numberOfFiles; i++)
                            if(child.name.Equals(file.AllFiles[i].name))
                                index = i;
                        file.AllFiles.RemoveAt(index);

                        file.numberOfFiles = file.numberOfFiles -1;
                        break;

                    }
                }
            }

            if(verifier == 0)
                Console.WriteLine("There is no such file.");

        }
    }
}