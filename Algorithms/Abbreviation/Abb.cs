using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        //int n = Convert.ToInt32(Console.ReadLine());
        int n=1, contor=0;
        for(int i=0; i<n; i++){
            string a= Console.ReadLine();
            string b= Console.ReadLine();
            //Console.WriteLine("{0}\n{1}\n",a,b);

            if(a.Length < b.Length)
                Console.WriteLine("NO");
            else
                if(a.Length == b.Length){
                    a=a.ToUpper();
                    if(a==b)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }            
            else{
                int m= a.Length;
                var c1= a.ToCharArray();

                for(int j=0; j<m; j++){
                    if(char.IsUpper(c1[j]) && contor==0)
                        if(b.IndexOf(c1[j]) == -1){
                            Console.WriteLine("NO");
                            contor = 1;
                    }
                }
                if(contor==0){
                    var c = a.ToCharArray();
                    string b2 = (string) b;
                    b2 = b2.ToLower();
                    var bb = b2.ToCharArray();
                    
                    for(int j=0; j<m; j++){
                        if(char.IsLower(c[j]) && b2.IndexOf(c1[j]) != -1){
                            c[j]=char.ToUpper(c[j]);
                            
                            for(int tg=0; tg< b2.Length; tg++){
                                if(bb[tg]==c[j]){
                                    for(int tm=tg; tm< (b2.Length-1); tm++)
                                        bb[tm]=bb[tm+1];
                                    int lenB = b2.Length-1;
                                
                                    char[] bb2= new char[lenB];
                                    for(int tp=0; tp< lenB; tp++)
                                        bb2[tp]=bb[tp];
                                    b2=new string(bb2);
                                }
                            }

                            //Console.WriteLine("{0}",c[j]);
                        }
                    }
                    //string s1= new string(c);
                    //Console.WriteLine("{0}",s1); 
                    
                    for(int j=0; j<m; j++){
                        if(char.IsLower(c[j])){
                            for( int p=j; p<m-1; p++){
                                c[p]=c[p+1];
                            }
                            m--;
                        }
                    }
                   
                    var c2=new char[m];
                    for(int j=0; j<m; j++)
                        c2[j]=c[j];
                
                    string a2= new string(c2);
                    //Console.WriteLine("{0}\n",a2);

                    if(a2.Length == b.Length)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                    

                }

            }         
        }
    }
}
//double letters
/*
                //a=a.ToUpper();
                var c= a.ToCharArray();
                //Console.WriteLine("{0}",a);
                for(int j1=0; j1<m; j1++)
                    for(int j2=0; j2<m; j2++)
                
                
                do{
                for(int j=0; j<m; j++)
                    if (b.IndexOf(c[j]) == -1) {
                        for( int p=j; p<m-1; p++){
                            c[p]=c[p+1];
                        }
                    Console.WriteLine("{0}",c.ToString()); 
                    m--;
                    }
                }while(m!=b.Length);
                
                var c2=new char[m];
                for(int j=0; j<m; j++)
                    c2[j]=c[j];
                
                string a2= new string(c2);
                Console.WriteLine("{0}\n",a2);
                string fuckyou = (string) a2;
                string fuckme = (string) b;
                if(fuckme==fuckyou)
                    Console.WriteLine("2YES");
                else
                    Console.WriteLine("2NO");
                }

 */