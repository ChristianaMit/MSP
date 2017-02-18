using System;

namespace Inheritance{
    class Sports{
        virtual public string GetName(){
            return "Generic Sports.";
        }
        virtual public void GetNumberOfTeamMembers(){
            Console.WriteLine( "Each team has n players in " + GetName() );
        }
}

    class Soccer: Sports {
        public override string GetName(){
            return "Soccer Class.";
        }
        public override void GetNumberOfTeamMembers(){
            Console.WriteLine( "Each team has 11 players in " + GetName() );
        }
    }

    public class Solution{
	
        public static void Main(string []args){
            Sports c1 = new Sports();
            Soccer c2 = new Soccer();
            Console.WriteLine(c1.GetName());
            c1.GetNumberOfTeamMembers();
            Console.WriteLine(c2.GetName());
            c2.GetNumberOfTeamMembers();
	    }   
    }
}