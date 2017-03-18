using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Tree: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            if( input != null)
                Console.WriteLine("Command doesn't accept parameters");
            
            else
                buildTree(file);
        }


        public void buildTree (FileSystemReader file){
            
            string tree = file.AllDirectories[0].name;
            string brench = "\n" + "|" + "\n" + " " + "---" + " ";

            Directory tempDirectory = new Directory();

            for(int i=0; i<(file.numberOfDirectories); i++){
                tempDirectory = file.AllDirectories[i];
                tree = findChildren (tree, brench, tempDirectory);
                brench = "  "+brench;
            }

            Console.WriteLine(tree);
        }

        public string findChildren (string tree,string brench, Directory curentDirectory){
            
            if(curentDirectory.children != null){
                foreach(var child in curentDirectory.children){
                    tree = tree+ brench + child.name; 
                }
            }

            return tree;
        }
    }
}