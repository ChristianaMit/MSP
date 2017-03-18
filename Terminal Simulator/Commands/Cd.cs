using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Cd: Directory, IExecuter
    {
        public void Execute(string inputDir, FileSystemReader file)
        {
            int verifier = 0;
            string goingBack = "..";
            
            if(inputDir == null){
                Console.WriteLine("Empty path is not valid!");
                verifier = 3;
            }
            
            else if(inputDir.Equals(goingBack)){
                if(file.curentDirectory != file.AllDirectories[0])
                    file.curentDirectory = file.curentDirectory.parent;
                verifier = 1;
            }

            else{
                foreach(var child in file.curentDirectory.children)
                {
                    if(child.name == inputDir){
                        verifier = 2;
                        foreach(var searchedDir in file.AllDirectories){
                            if(searchedDir.name == child.name)
                                file.curentDirectory = searchedDir;
                        }
                    }
                }
            }

            if(verifier == 0){
                Console.WriteLine("Invalid path!");
            }
        }

    }
}
