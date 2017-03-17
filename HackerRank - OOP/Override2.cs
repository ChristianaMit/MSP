using System;

namespace Inheritance{
    public class BiCycle{
        virtual public string DefineMe(){
		    return "a vehicle with pedals.";
	    }
    }
    public class MotorCycle: BiCycle{
	    public override string DefineMe(){
		    return "a cycle with an engine.";
	    }
	    public MotorCycle(){
		    Console.WriteLine("Hello I am a motorcycle, I am "+ DefineMe());
            string temp=base.DefineMe();
            Console.WriteLine("My ancestor is a cycle who is "+ temp );
	    }
    }
    class Solution{
	    public static void Main(String []args){
		    MotorCycle M=new MotorCycle();
	    }
    }  
}