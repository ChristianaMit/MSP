using System;

namespace Inheritance{

    public class Calculate{
    
    int get_int_val(){
        int sc=new Scanner(System.in);
		int x=sc.nextLine();
        return x;
    }
    
    double get_double_val(){
        Scanner sc=new Scanner(System.in);
		double x=sc.nextLine();
        return x;
    }
    public void getData{
        ;
    }
    
    
    float get_volume(int a){
        DecimalFormat df = new DecimalFormat("#.####");
        df.setRoundingMode(RoundingMode.CEILING);

        Double d = n.doubleValue();
        System.out.println(df.format(d));


    }
    
}



    public class Solution {

 public static void main(String[] args) {

    Calculate cal = new Calculate();
    int T = cal.get_int_val();
    while (T--> 0) {
     double volume = 0.0;
     int ch = cal.get_int_val();
     if (ch == 1) {
      int a = cal.get_int_val();
      volume = Calculate.do_calc().get_volume(a);
     } else if (ch == 2) {
      int l = cal.get_int_val();
      int b = cal.get_int_val();
      int h = cal.get_int_val();
      volume = Calculate.do_calc().get_volume(l, b, h);

     } else if (ch == 3) {
      double r = cal.get_double_val();
      volume = Calculate.do_calc().get_volume(r);

     } else if (ch == 4) {
      double r = cal.get_double_val();
      double h = cal.get_double_val();
      volume = Calculate.do_calc().get_volume(r, h);

     }
     cal.output.display(volume);
    }

   

  } 
} 

}