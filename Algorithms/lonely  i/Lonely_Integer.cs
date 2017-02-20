using System;

namespace Hackerrank

{
    class Program{
        
        static int lonelyInteger(int[] a) {
        int i, j, aux=0;
        int [] ok= new int[a.Length]; 
        for(i = 0; i <a.Length; i++) { 
            ok[i]=0;
        }
        for(i = 0; i <a.Length; i++){
            for(j=0; j<a.Length; j++){   
                 if(a[i]== a[j] && i!=j)
                      ok[j]=1;         
                }
            }
            
        for(i = 0; i <a.Length; i++)  
            if(ok[i]==0)
               aux=a[i];
       return aux;
    }
        
        
        static void Main(string[] args)
        {
            int n=9, aux=0;
            //n=Convert.ToInt32(Console.ReadLine());
            int [] v = new[] {7,3,2,2,3,4,4,5,5};
         
            //for(i = 0; i < n; i++) { 
                //v[i]=Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(string.Join(",", v));       
            //Console.WriteLine("for {0} element ok= {1}",j, ok);
            //Console.WriteLine(string.Join(",", ok));


            aux=lonelyInteger(v);
            Console.WriteLine("{0}", aux);
        }
    }
}
