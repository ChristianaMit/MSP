using System;

namespace TerminalSimulator
{
    public class CommandSearcher
    {
        
        public static string [] commands = new string [] {"echo", "cd", "ls", "touch", "mkdir", "tree", "pwd", "rm", "rmdir"};
        
        public void CmdSearch(string name, string input, Directory curDir){
            
            int verifier=0;
            Console.WriteLine("A ajuns aici");

            string inputCommand = input.Substring(0, input.IndexOf(" "));
            string parameters = input.TrimStart('"');
            Console.WriteLine(parameters);

                for(int i = 0; i < commands.Length; i++ ){
                    if( inputCommand.Equals(commands[i])){
                        
                        Console.Write("\nInput command was: {0}\n", inputCommand);
                        verifier=1;

                        string caseSw = commands[i];
                        switch (caseSw){
                                
                            case "pwd":
                                break;
                                
                            case "ls":

                                break;
                                
                            case "mkdir":

                                break;
                                
                            case "touch":

                                break;
                                
                            case "cd":
                                Cd newDir = new Cd();
                                newDir.Execute(parameters, curDir);
                                break;
                            
                            case "rmdir":
                                        
                                break;
                                
                            case "rm":
                                break;
                                
                            case "tree":
                                break;
                                
                            case "echo":
                                Echo text = new Echo();
                                text.Execute(parameters, curDir);
                                break;
                            } 
                        }
                }

                if(verifier == 0){
                    Console.Write("Command not found");
                    Console.Write("\n{0}: {1} {0}$ ", name, curDir.Name);
                    input = Console.ReadLine();
                }

        }
    
    
    
    }
}