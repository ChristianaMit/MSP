using System;

namespace Inheritance{

public class Animal{
	    public void walk(){
		    Console.WriteLine("I am walking");
        }
}   
public class Bird: Animal{
	    public void fly(){
		    Console.WriteLine("I am flying");
	    }
        public void sing(){
            Console.WriteLine("I am singing");
        }
}

class Inh1{
        static void Main(String[] args) {
            Bird bird = new Bird();
	        bird.walk();
	        bird.fly();
            bird.sing();
        }
    }
}