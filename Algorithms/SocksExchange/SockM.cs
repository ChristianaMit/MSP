using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = 20;
        
        int[] c = new int[] {4, 5, 5, 5, 6, 6, 4, 1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5};
        int i=0, j=0, p, k=0, aux=-1;
        do{
        aux=0;
        for(i=0; i<n; i++){
            
            for(j=i+1; j<n; j++)
                
                
                if(c[i]==c[j]){
                    k++;
                    for(p=i; p<n-1; p++)
                        c[p]=c[p+1];
                    c[n-1]=0;
                    n--;
                
                    Console.WriteLine("{0} {1}", n, k);
                    Console.WriteLine("{0} {1}", i, j);
                    Console.WriteLine(string.Join(" ",c));

                    for(p=j-1; p<n-1; p++)
                        c[p]=c[p+1];
                    c[n-1]=0;
                    n--;

                    Console.WriteLine(string.Join(" ",c));
                    Console.WriteLine("\n");
                }
                for(int m1=0; m1<n; m1++)
                    for(int m2=m1+1; m2<n; m2++)
                        if(c[m1]==c[m2])
                            aux=1;
            
        }
        }while(aux!=0);        

        Console.WriteLine("{0}",k);
        }
    }


/*

while(i<n)
            {   j=i+1;
                while(j<n){
                if(c[i] == c[j])
                {
                    k++;
                    for(p=i; p<n-1; p++)
                        c[p]=c[p+1];
                    c[n-1]=0;
                    n--;
                
                    Console.WriteLine("{0} {1}", n, k);
                    Console.WriteLine(string.Join(" ",c));

                    for(p=j-1; p<n-1; p++)
                        c[p]=c[p+1];
                    c[n-1]=0;
                    n--;
                
                    Console.WriteLine("{0} {1}", n, k);
                    Console.WriteLine(string.Join(" ",c));
                    Console.WriteLine("\n");
                }
                else j++;
                }
                for(j=0; j<n; j++)
                    if(c[j]==c[i])
                        aux=1;
                if(aux==0)
                    i++;
            }

*/

//0