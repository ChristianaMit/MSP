using System;

namespace Inheritance{

    public class Calculate{
        public int GetIntVal(){
            int x=Convert.ToInt32(Console.ReadLine());
            return x;
        }
         public double GetDoubleVal(){
		    double x=Convert.ToDouble(Console.ReadLine());
            return x;
        } 
        public double GetVolume(int a){
            return a*a*a;
        }
        public double GetVolume(int l, int h, int b){
            return l*h*b;
        }
        public double GetVolume(double r){
            return (2*r*Math.PI)/3;
        }
        public double GetVolume(double r, double h){
            return Math.PI*r*r*h;
        }
        public void Display(double v){
            string output = v.ToString("#.000");
            Console.WriteLine("Volume is: {0}", output); 
        }
    
    }



public class Solution {
    public static void Main(string[] args) {
        Calculate cal = new Calculate();
        int testCases = cal.GetIntVal();
        while (testCases > 0) {
            double volume = 0.0;
            int ch = cal.GetIntVal();
            if( ch <1 || ch >4){
                Console.WriteLine("For testcase {0} number is not the right value.\n", testCases);
                break;
            }
            if (ch == 1) {
                int a = cal.GetIntVal();
                if(a < 0)
                    Console.WriteLine("Values must be possitive.");
                else 
                    volume = cal.GetVolume(a);
            } 
            else if (ch == 2) {
                int l = cal.GetIntVal();
                int b = cal.GetIntVal();
                int h = cal.GetIntVal();
                volume = cal.GetVolume(l, b, h);
            } 
            else if (ch == 3) {
                double r = cal.GetDoubleVal();
                volume = cal.GetVolume(r);
            } 
            else if (ch == 4) {
                double r = cal.GetDoubleVal();
                double h = cal.GetDoubleVal();
                volume = cal.GetVolume(r, h);

             }
            testCases--;
            cal.Display(volume);
        }
    } 
} 

}