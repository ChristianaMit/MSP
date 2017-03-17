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
            string parameter = input.Trim().Trim('"');
            Console.WriteLine(parameter);

                for(int i = 0; i < commands.Length; i++ ){
                    if( inputCommand.Equals(commands[i])){
                        
                        Console.Write("\nInput command was: {0}\n", inputCommand);
                        verifier=1;

                        string caseSw = commands[i];
                        switch (caseSw){
                                
                            case "pwd":
                                Pwd showPath = new Pwd();
                                showPath.Execute(parameter, curDir);
                                break;
                                
                            case "ls":
                                Ls showContent = new Ls();
                                showContent.Execute(parameter, curDir);
                                break;
                                
                            case "mkdir":
                                Mkdir addDirectory = new Mkdir();
                                addDirectory.Execute(parameter, curDir);
                                break;
                                
                            case "touch":
                                Touch addFile = new Touch();
                                addFile.Execute(parameter, curDir);
                                break;
                                
                            case "cd":
                                Cd newDir = new Cd();
                                newDir.Execute(parameter, curDir);
                                break;
                            
                            case "rmdir":
                                Rmdir removeDir = new Rmdir();
                                removeDir.Execute(parameter, curDir);     
                                break;
                                
                            case "rm":
                                Rm removeFile = new Rm();
                                removeFile.Execute(parameter, curDir);  
                                break;
                                
                            case "tree":
                                Tree showTree = new Tree();
                                showTree.Execute(parameter, curDir);  
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
                }

        }
    
    
    
    }
}