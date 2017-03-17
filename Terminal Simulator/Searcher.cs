using System;

namespace TerminalSimulator
{
    public class CommandSearcher
    {
        
        public static string [] commands = new string [] {"echo", "cd", "ls", "touch", "mkdir", "tree", "pwd", "rm", "rmdir"};
        
        public void CmdSearch(string name, string input, Directory curDir, FileSystemReader file){
            
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

            for(int i = 0; i < commands.Length; i++ ){
                    if( inputCommand.Equals(commands[i])){
                        verifier=1;

                        string caseSw = commands[i];
                        switch (caseSw){
                                
                            case "pwd":
                                Pwd showPath = new Pwd();
                                showPath.Execute(parameter, curDir, file);
                                break;
                                
                            case "ls":
                                Ls showContent = new Ls();
                                showContent.Execute(parameter, curDir, file);
                                break;
                                
                            case "mkdir":
                                Mkdir addDirectory = new Mkdir();
                                addDirectory.Execute(parameter, curDir, file);
                                break;
                                
                            case "touch":
                                Touch addFile = new Touch();
                                addFile.Execute(parameter, curDir, file);
                                break;
                                
                            case "cd":
                                Cd newDir = new Cd();
                                newDir.Execute(parameter, curDir, file);
                                break;
                            
                            case "rmdir":
                                Rmdir removeDir = new Rmdir();
                                removeDir.Execute(parameter, curDir, file);     
                                break;
                                
                            case "rm":
                                Rm removeFile = new Rm();
                                removeFile.Execute(parameter, curDir, file);  
                                break;
                                
                            case "tree":
                                Tree showTree = new Tree();
                                showTree.Execute(parameter, curDir, file);  
                                break;
                                
                            case "echo":
                                Echo text = new Echo();
                                text.Execute(parameter, curDir, file);
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