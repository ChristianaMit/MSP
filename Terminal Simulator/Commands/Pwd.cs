using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{

    public class Pwd: IExecuter
    {
    
        public void Execute(string input, FileSystemReader file)
        {
            
            if(input != null)
                Console.Write("Error: command doesn't accept parameters");
            
            
            else{
                
                if( file.curentDirectory.Equals( file.AllDirectories[0] ) )
                    Console.WriteLine("/");
                
                else{
                    Directory temporaryDirectory = file.curentDirectory;
                    string absolutPath = "/" + temporaryDirectory.name;
                    
                    while( temporaryDirectory != file.AllDirectories[0] ){
                        Console.WriteLine(absolutPath);
                        temporaryDirectory = temporaryDirectory.parent;
                        if(temporaryDirectory != file.AllDirectories[0])
                            absolutPath = "/" + temporaryDirectory.name + absolutPath;
                    }
                    
                    Console.WriteLine(absolutPath);
                }
            
            }
        
        }
    
    }
}


//interesting tedious way to express the same thing: 
//temporaryDirectory.name.Equals(file.AllDirectories[0].name) == false