using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution {

    static void Main(String[] args) {
        
        int n = 6;
        int k = 7;
        int q = 3;
        int[] a = new [] {1,2,3,4,5,6};
        while(k>n)
            k-=n;
        Console.WriteLine("{0}", k);
        int[] v = new int[n];
        int i;
            for(i=0; i<k; i++)
                v[i]=a[n-k+i];
            
            for(i=k; i<n; i++)
                v[i]=a[i-(k)];
            
            for(i=0; i<n; i++)
                a[i]=v[i];

            Console.WriteLine(string.Join(",", a)); 
       
        /*for(int a0 = 0; a0 < q; a0++){
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", a[m]);
        }*/
    }
}

/*while(k>0){
                    aux=a[n-1];
                    v[0]=aux;
                    for(int j=1; j<n; j++){
                       v[j+1]=a[j];
                    }
                    a[0]=aux;
                    for(int j=0; j<n; j++){
                        a[j+1]=v[j];
                    }
                     Console.WriteLine(string.Join(",", a)); 
                    k--;
                }
                */

            //Console.WriteLine(string.Join(",", v));