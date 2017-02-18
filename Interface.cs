using System;

namespace Inheritance{

    public interface IAdvancedArithmetics{
        int DivisorSum(int Number);
    }

    public class MyCalculator: IAdvancedArithmetics
    {
        public int DivisorSum(int Number){
            int sum=0;
            for(int i=1; i<=Number; i++)
                if(Number%i==0)
                    sum+=i;
            return sum;
        }
    }

    public class Solution{
    public static void Main(String []args){
        MyCalculator myCalculator = new MyCalculator();
        Console.WriteLine("I implemented: ");
        ImplementedInterfaceNames(myCalculator);
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(myCalculator.DivisorSum(n) + "\n");
      	
    }
 
    static void ImplementedInterfaceNames(Object o){
        foreach (Type tinterface in o.GetType().GetInterfaces())
        {
            Console.WriteLine(tinterface.ToString());
        }
    }

}

}