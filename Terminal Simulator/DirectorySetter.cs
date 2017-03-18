using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class DirectorySetter
    {
        public void SetCurentDirectory(string name, FileSystemReader file){
            while(name.Equals(file.curentDirectory.name) == false){
                foreach(var child in file.curentDirectory.children){
                    for(int i=0; i<file.numberOfDirectories; i++)
                        if(file.AllDirectories[i].name.Equals(child.name))
                            file.curentDirectory=file.AllDirectories[i];
                    if(child.name == name)
                        break;
                    else
                        SetCurentDirectory(name, file);
                }   
            }
            
        }
    }
}

//can be used as an alternative to cd