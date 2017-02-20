using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = 3;
        int[,] a = new int[3,3] {{11, 2, 4}, {4, 5, 6}, {10, 8, -12}};
        /*for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }*/
        int i, diag1=0, diag2=0, dif;
        for(i=0;i<n;i++)
            diag1+=a[i,i];
         for(i=0;i<n;i++)
             diag2+=a[n-1-i,i];
        dif=diag1-diag2;
        if(dif<0)
            dif=-dif;
        Console.WriteLine("{0}", diag1);
        Console.WriteLine("{0}", diag2);
        Console.WriteLine("{0}", dif);
        
    }
}

