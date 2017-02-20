using System;
using System.Collections.Generic;

namespace Inheritace{
    
    public class Student{}
    public class Rockstar{}
    public class Hacker{}

    public class InstanceOF{
        public static string count(List<object> mylist){
            int a = 0,b = 0,c = 0;
            for(int i = 0; i < mylist.Count; i++){
                object element = mylist[i];
                if(element.GetType() == typeof(Student))
                    a++;
                if(element.GetType() == typeof(Rockstar))
                    b++;
                if(element.GetType() == typeof(Hacker))
                    c++;
            }
            string ret = a.ToString()+" "+ b.ToString()+" "+ c.ToString();
            return ret;
        }

        public static void Main(string []args){
            List<object> mylist = new List<object>();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++){
                string s = Console.ReadLine();
                if(s.Equals("Student"))mylist.Add(new Student());
                if(s.Equals("Rockstar"))mylist.Add(new Rockstar());
                if(s.Equals("Hacker"))mylist.Add(new Hacker());
            }
            Console.WriteLine(count(mylist));
        }
    }
}