using System;
using System.Reflection;
using System.Collections.Generic;
namespace TerminalSimulator
{
    public class FileSystemReader: Entity
    {         
            public Directory curentDirectory = new Directory();
            public List<Directory>  AllDirectories = new List<Directory>(10);
            public List<File> AllFiles = new List<File>(10);

            public int numberOfDirectories = new int();
            public int numberOfFiles = new int();

           // System.IO.StreamReader file =  new System.IO.StreamReader(".input");
            //Due to some tehnical dificutlies, this part will be hard-codded for test purposes
            public FileSystemReader(){
                numberOfDirectories = 8;
                numberOfFiles = 5;

                for(int i = 0 ; i < numberOfDirectories ;i++){
                    AllDirectories.Add(new Directory());
                }
                 for(int i = 0 ; i < numberOfFiles ;i++){
                    AllFiles.Add(new File());
                }
               
               AllDirectories[0].name = "/";
               this.AllDirectories[0].parent = null;
               this.AllDirectories[0].AddChild ( this.AllDirectories[1]);

               curentDirectory = AllDirectories[0];
               
               this.AllDirectories[1].name = "Home";
               this.AllDirectories[1].parent = this.AllDirectories[0];
               this.AllDirectories[1].AddChild ( this.AllDirectories[2]);
               this.AllDirectories[1].AddChild ( this.AllDirectories[3]);
               this.AllDirectories[1].AddChild ( this.AllDirectories[4]);
               
               this.AllDirectories[2].name = "Desktop";
               this.AllDirectories[2].parent = this.AllDirectories[1];
               this.AllDirectories[2].AddChild ( this.AllDirectories[5]);
               this.AllDirectories[2].AddChild ( this.AllDirectories[6]);

               this.AllDirectories[3].name = "Downloads";
               this.AllDirectories[3].parent = this.AllDirectories[1];
               this.AllDirectories[3].AddChild ( this.AllFiles[0]);

               this.AllDirectories[4].name = "Documents";
               this.AllDirectories[4].parent = this.AllDirectories[1];
               this.AllDirectories[4].AddChild ( this.AllFiles[1]);
               this.AllDirectories[4].AddChild ( this.AllFiles[2]);

               this.AllFiles[0].name = "Lena.jpg";
               this.AllFiles[0].content = "http://tech.velmont.net/files/2009/04/len_full.jpg";
               this.AllFiles[0].parent = this.AllDirectories[3];

               this.AllFiles[1].name = "CV.pdf";
               this.AllFiles[1].content = "Sarac. Pls give job.";
               this.AllFiles[1].parent = this.AllDirectories[4];

               this.AllFiles[2].name = "ShoppingList.pdf";
               this.AllFiles[2].content = "Săpun";
               this.AllFiles[2].parent = this.AllDirectories[4];

               this.AllDirectories[5].name = "Music";
               this.AllDirectories[5].parent = this.AllDirectories[2];
               this.AllDirectories[5].AddChild ( this.AllDirectories[7]);
               
               this.AllDirectories[6].name = "OOP";
               this.AllDirectories[6].parent = this.AllDirectories[2];
               this.AllDirectories[6].AddChild ( this.AllFiles[3]);

               this.AllDirectories[7].name = "Bon Jovi";
               this.AllDirectories[7].parent = this.AllDirectories[5];
               this.AllDirectories[7].AddChild ( this.AllFiles[4]);
               
               this.AllFiles[3].name = "HelloWorld.cs";
               this.AllFiles[3].content = "public class HelloWorld\n{public static void Main(){\nSystem.Console.WriteLine(Hello, World!);\n}\n}\n";
               this.AllFiles[3].parent = this.AllDirectories[6];

               this.AllFiles[4].name = "Livin' On A Prayer.mp3";
               this.AllFiles[4].content ="Whoa, we're half way there \nWhoa, livin' on a prayer \nTake my hand and we'll make it - I swear \nWhoa, livin' on a prayer";
               this.AllFiles[4].parent = this.AllDirectories[7];
            }

            public void AddFile(string name, string content, FileSystemReader file){
                file.numberOfFiles = file.numberOfFiles + 1;
                int i = file.numberOfFiles - 1;
                
                AllFiles.Add(new File());
                file.AllFiles[i].name = name;
                file.AllFiles[i].parent = file.curentDirectory;
                file.AllFiles[i].content = content;
                file.curentDirectory.AddChild(file.AllFiles[i]);
            }

            public void AddDirectory(string name, FileSystemReader file){
                file.numberOfDirectories = file.numberOfDirectories + 1;
                int i = file.numberOfDirectories - 1;

                AllDirectories.Add(new Directory());
                file.AllDirectories[i].name = name;
                file.AllDirectories[i].parent = file.curentDirectory;
                file.AllDirectories[i].children = null;
                file.curentDirectory.AddChild(file.AllDirectories[i]);
            }


    }
}
      