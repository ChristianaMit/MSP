using System;

namespace TerminalSimulator
{
    public class Program 
    {  
        public static void Main(string[] args)
        {
            /*Console.Write("Username:");
            string name= Console.ReadLine();
            Console.Write("Password:");
            string pass= Console.ReadLine();
            Console.WriteLine("\n   Welcome back {0}!\n", name);*/
            
            string name= "Kitty";
            FileSystemReader allDirectories = new FileSystemReader();

            Reader read = new Reader();
            read.InputReader(name, allDirectories);                  //Reads from a file sysem model
            
            Console.WriteLine("Do you want to see the file system before exiting? (y/n)");
            string answer = Console.ReadLine();
            if(answer == "y"){
                OutputWriter printerOnScreen = new OutputWriter();
                printerOnScreen.WriteToScreen(allDirectories);
            }
            
        }
    }
}



//To implement: 
            //1. Class Users with list of accepted users and passwords
            //2. Methode that doesn't show characters when you read from console
            //3. Can't add/remove " " file/directories