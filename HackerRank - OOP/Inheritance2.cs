using System;


namespace Inheritance{
public class Arithmetic {
    public int add(int i1, int i2){
        return i1+i2;
    }
}

public class Adder: Arithmetic {}

class Inh2{
    static void Main(String[] args) {
        Adder a = new Adder();
        Type superClass = a.GetType().BaseType;
        Console.WriteLine("My superclass is: {0}" , superClass);	
        Console.WriteLine(a.add(10,32) + " " + a.add(10,3) + " " + a.add(10,10) + "\n");
     }
}
}
