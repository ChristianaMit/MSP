using System;

namespace TerminalSimulator
{
    public class Program 
    {
        
        public static void Main(string[] args)
        {
            Console.Write("Username:");
            string name= Console.ReadLine();
            Console.Write("Password:");
            string pass= Console.ReadLine();
            Console.WriteLine("\n   Welcome back {0}!\n", name);
            
            Directory currentDirectory = new Directory();
            
            Reader read = new Reader();
            read.InputReader(name, currentDirectory);

        }
    }
}