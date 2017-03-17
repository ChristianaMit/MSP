using System;

namespace TerminalSimulator
{
    public class Reader 
    {
        
        public void InputReader(string name, FileSystemReader file){
            
            Console.Write("\n{0}: {1} {0}$ ", name,file.curentDirectory.name);
            string input = Console.ReadLine();
            string end = "exit";
            
            while( input != end){
                
                while( input.Equals("\n")){
                    Console.Write("\n{0}: {1} {0}$ ", name,file.curentDirectory.name);
                    input = Console.ReadLine();
                }
                
                CommandSearcher searcher = new CommandSearcher();
                searcher.CmdSearch(name, input, file);
                
                Console.Write("{0}: {1} {0}$ ", name,file.curentDirectory.name);
                input = Console.ReadLine();
 
            }
        }

    }
}