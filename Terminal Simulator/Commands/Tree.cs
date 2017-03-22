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
            
            string tree = "\n" + file.curentDirectory.name;
            string brench = "\n" + "    |" + "\n" + " " + "    ---" + " ";
            
            tree = findChildren (tree, brench, file);
            Console.WriteLine(tree);
        }


        public string findChildren (string tree,string brench, FileSystemReader file){
            
            if(file.curentDirectory.children != null){
                int cDNrChildrn=0;
                while(cDNrChildrn <= file.curentDirectory.children.Count){
                    foreach(var child in file.curentDirectory.children){
                        cDNrChildrn++;
                        tree = tree+ brench + child.name;
                        Console.WriteLine(tree);
                        DirectorySetter changeDir = new DirectorySetter();
                        if(child is TerminalSimulator.Directory){
                            changeDir.SetCurentDirectory(child.name, file);
                            findChildren(tree, brench, file);
                        }
                        else
                            tree = tree + brench + child.name; 
                    }
                }
                DirectorySetter changeDirBackwords = new DirectorySetter();
                changeDirBackwords.SetCurentDirectory(file.curentDirectory.parent.name, file);
            }

            if(file.curentDirectory.children == null){
                DirectorySetter changeDir = new DirectorySetter();
                changeDir.SetCurentDirectory(file.curentDirectory.parent.name, file);
            }

            return tree;
        }
    }
}


/*
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

 */

/*
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
 */