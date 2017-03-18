using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalSimulator
{
    public class Echo: IExecuter
    {
        public void Execute(string input, FileSystemReader file)
        {
            int index = input.IndexOf(">");
            if(index != -1){
                int verifier = 0;

                string text = input.Substring(0,index);
                text = text.TrimEnd(' ');
                text = text.TrimEnd('"');

                string fileName = input.Substring(index, input.Length-index);
                fileName = fileName.Trim('>');
                fileName = fileName.TrimStart(' ');
                
                foreach(var child in file.curentDirectory.children){
                    if(child.name.Equals(fileName))
                    {
                        verifier = 1;
                        
                        for(int i=0; i<file.numberOfFiles; i++){
                            if(file.AllFiles[i].name.Equals(child.name)){
                                file.AllFiles[i].content = text;
                            }
                        }
                    }
                }

                if(verifier == 0){
                    Touch newFile = new Touch();
                    newFile.Execute(fileName, file);
                    int i = file.numberOfFiles - 1;
                    file.AllFiles[i].content = text;
                    }
            }

            else
                Console.WriteLine("{0}",input);
        }
    }
}
