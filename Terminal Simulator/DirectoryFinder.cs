using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class DirectoryFinder: Entity
    {
        public void RecursiveSearch(string name, FileSystemReader file){
            //file.curentDirectory.SetCurrentDirectory();
            if(file.curentDirectory.children != null){
                foreach(var child in file.curentDirectory.children){
                    RecursiveSearch(child.name, file);
                }
            }

        }
    }
}