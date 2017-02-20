using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
    
    int var=n-1;
    while(var>-1){
        string a="";
        for(int j=0; j<var; j++)
            a=" "+a;
        for(int j=var; j<n; j++)
           a=a+"#";
        Console.WriteLine("{0}", a);
        var--;
    }

    }    
}  


