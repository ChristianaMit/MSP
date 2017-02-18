using System;
using System.Collections.Generic;

namespace Inheritance{

public class Solution{
   
   public static IEnumerator<object> func(List<object> MyList){
         IEnumerator<object> it = MyList.GetEnumerator();
         object element =  it.Current;
         while(it.MoveNext()){
            if(element is string)
                  break;
      }
      return it;  
   }
   public static void Main(string []args){
      List<object> MyList = new List<object>();
      int n = Convert.ToInt32(Console.ReadLine());
      int m = Convert.ToInt32(Console.ReadLine());
      for(int i = 0;i<n;i++){
         MyList.Add(Convert.ToInt32(Console.ReadLine()));
      }
      
      MyList.Add("###");
      for(int i=0;i<m;i++){
         MyList.Add(Console.ReadLine());
      }
      
      IEnumerator<object> it=func(MyList); 
      while(it.MoveNext()){
         Object element = it.Current;
         Console.WriteLine("{0}", element);
      }
   }
}




}