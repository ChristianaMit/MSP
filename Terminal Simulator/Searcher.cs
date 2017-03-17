using System;

namespace TerminalSimulator
{
    public class CommandSearcher
    {
        
        public static string [] commands = new string [] {"echo", "cd", "ls", "touch", "mkdir", "tree", "pwd", "rm", "rmdir"};
        
        public Directory CmdSearch(string name, string input, FileSystemReader file){
            
            int verifier=0;

            string inputCommand = input;
            string parameter = input;

            if(input.Contains(" ")){
                inputCommand = input.Substring(0, input.IndexOf(" "));
                parameter = input.Trim('"');
                parameter = parameter.Replace(inputCommand, "");
                parameter = parameter.TrimStart(' ');
                parameter = parameter.TrimStart('"');
            }
            else{
                parameter = null;
            }

            for(int i = 0; i < commands.Length; i++ ){
                    if( inputCommand.Equals(commands[i])){
                        verifier=1;

                        string caseSw = commands[i];
                        switch (caseSw){
                                
                            case "pwd":
                                Pwd showPath = new Pwd();
                                showPath.Execute(parameter, file);
                                break;
                                
                            case "ls":
                                Ls showContent = new Ls();
                                showContent.Execute(parameter, file);
                                break;
                                
                            case "mkdir":
                                Mkdir addDirectory = new Mkdir();
                                addDirectory.Execute(parameter, file);
                                break;
                                
                            case "touch":
                                Touch addFile = new Touch();
                                addFile.Execute(parameter, file);
                                break;
                                
                            case "cd":
                                Cd newDir = new Cd();
                                newDir.Execute(parameter, file);
                                break;
                            
                            case "rmdir":
                                Rmdir removeDir = new Rmdir();
                                removeDir.Execute(parameter, file);     
                                break;
                                
                            case "rm":
                                Rm removeFile = new Rm();
                                removeFile.Execute(parameter, file);  
                                break;
                                
                            case "tree":
                                Tree showTree = new Tree();
                                showTree.Execute(parameter, file);  
                                break;
                                
                            case "echo":
                                Echo text = new Echo();
                                text.Execute(parameter, file);
                                break;
                            } 
                        }
                }

                if(verifier == 0){
                    Console.Write("Command not found");
                }

                return file.curentDirectory;

        }
    
    
    
    }
}