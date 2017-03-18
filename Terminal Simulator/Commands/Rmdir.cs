using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Rmdir: IExecuter
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
                        for(int i = 0; i<file.numberOfDirectories; i++)
                            if(child.name.Equals(file.AllDirectories[i].name))
                                index = i;
                        file.AllFiles.RemoveAt(index);

                        file.numberOfDirectories = file.numberOfDirectories --;
                        break;
                    }
                }
            }

            if(verifier == 0)
                Console.WriteLine("There is no such file.");

        }
    }
}