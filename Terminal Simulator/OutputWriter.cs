using System;

namespace TerminalSimulator
{
    //was supposed to write the final system in a output file but for some reason I need to install Mono to be able to write in files so nope
    //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"/Users/output.txt")){
    public class OutputWriter{
        public void WriteToScreen(FileSystemReader virtualFiles){

            for(int i=0; i < virtualFiles.numberOfDirectories; i++){
                Console.Write("{0}. ", i+1);
                Console.WriteLine(virtualFiles.AllDirectories[i].name);
                if(virtualFiles.AllDirectories[i].parent != null)
                    Console.WriteLine(virtualFiles.AllDirectories[i].parent.name);
                else
                    Console.WriteLine("/");
                if(virtualFiles.AllDirectories[i].children != null)
                    for(int j=0; j<virtualFiles.AllDirectories[i].children.Count; j++)
                        Console.Write(virtualFiles.AllDirectories[i].children[j].name+" ");                    Console.WriteLine("\n");
            }

            for(int i=0; i< virtualFiles.numberOfFiles; i++){
                Console.Write("{0}. ", i+1);
                Console.WriteLine(virtualFiles.AllFiles[i].name);
                Console.WriteLine(virtualFiles.AllFiles[i].parent.name);
                Console.WriteLine(virtualFiles.AllFiles[i].content);
                Console.WriteLine("\n");
            }

            Console.WriteLine("NUMBER OF DIRECTORIES: {0}\nNUMBER OF FILES: {1}\n\n", virtualFiles.numberOfDirectories, virtualFiles.numberOfFiles);                
        }
    }
}
