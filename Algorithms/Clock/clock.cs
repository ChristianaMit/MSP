using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Time {

    static void Main(String[] args) {
        string time = "12:05:45PM";
        String searchString = "PM";
        int startIndex = 8;
        int startIndexHour= 0;
        int length = 2;
        int startIndexMS = 2;
        int length2= 6;
        string hour = time.Substring(startIndexHour,length);
        string minsec = time.Substring(startIndexMS,length2);
        string daynight = time.Substring(startIndex,length);
        string newString="";
        int x=Convert.ToInt32(hour);
        if(daynight == searchString){
            if(x==12){
                newString = x + minsec;
            }
            else{
                x+=12;
                newString = x + minsec;
            }
        }
        else {
            if(x==12)
                newString = "00" + minsec;
            else 
                newString = hour + minsec;
        }
        Console.WriteLine("{0}", newString);
        //Console.WriteLine("{0}", daynight);
        //Console.WriteLine("{0}", hour);
        //Console.WriteLine("{0}", minsec);

    }
}

