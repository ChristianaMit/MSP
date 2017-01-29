using System;

namespace Numbers
{
    public class NR   
    {
        private static string [] units = new[] { "zero", "unu", "doi", "trei", "patru", "cinci", "șase", "șapte", "opt", "nouă", "zece", "unsprezece", "doisprezece", "treisprezece", "paisprezece", "cincisprezece", "șaisprezece"};
        private static string [] sintax = new[] { "două", "sprezece", "zeci", "șaizeci", "o sută ", "o mie ", "un milion ", "un miliard "};
      
      
      public static string ConvertNumber(int number){
          string result = NumberToWords(number);
          return result.Remove(1).ToUpper() + result.Substring(1);
      }

      public static string RemoveSpaces(int number){
          string result = ConvertNumber(number);
          result = number + " : " + result + ".";
          return result.Replace("  ", " ");
      }

      public void PrintNumber(int number)
        {
            Console.WriteLine("{0}", RemoveSpaces(number));
        }
      
       public static string NumberToWords(int number)
    {
        if ( number == 0)
            return units[0];

        if (number < 0)
            return "minus " + NumberToWords(Math.Abs(number));
        
        string words = "";
        

        if ((number / 1000000000) > 0){
            if((number / 1000000000) == 1)
                words += sintax[7];
            if ((number / 1000000000) == 2)
                    words += sintax[0]+ " miliarde ";
            number %= 1000000000;
        }

        if ((number / 1000000) > 0){
            if((number / 1000000) == 1)
                words += sintax[6];
            else{
                if ((number / 1000000) == 2)
                    words += sintax[0];
                else
                    words += NumberToWords(number / 1000000);
                if ((number / 10000000) % 10 > 1)
                    words += " de";
                words += " milioane ";
            }
            number %= 1000000;
        }

        if ((number / 1000) > 0){
            if((number / 1000) == 1)
                words += sintax[5];
            else{
                if ((number / 1000) == 2)
                    words += sintax[0];
                else
                    words += NumberToWords(number / 1000);
                if ((number / 10000) %10 > 1)
                    words += " de";
                words += " mii ";
            }
            number %= 1000;
        }


        if ((number / 100) > 0){
            if((number / 100) == 1)
                words += sintax[4];
            if((number / 100) == 2)
                words += sintax[0] + " sute ";
            if((number / 100) >2)
                words += NumberToWords(number / 100) + " sute ";
            number %= 100;
        }


        if ((number / 10) > 1){
            if ((number / 10) == 2)
                words += sintax[0] + sintax[2];
            if ((number / 10) == 6)
                words += sintax[3];
            if ((number / 10) != 2 && (number / 10) != 6)
                words += units[number / 10] + sintax[2];
            if ((number % 10) != 0)
                words += " și ";
            number %= 10;
        }


        if (number > 0){
                if ((number / 10) % 10 ==1){
                    if(number < 17)
                        words += units[number];
                    else 
                        words += units[number % 10] + sintax[1];    
                }
                else if ((number % 10) > 0)
                    words += units[number % 10];
        }

        return words;
    }

    }

    class Program
    {
        static void Main(string[] args)
        {
            NR a = new NR();
            a.PrintNumber(1);
            a.PrintNumber(10);
            a.PrintNumber(-12);
            a.PrintNumber(100);
            a.PrintNumber(700000);
            a.PrintNumber(750000);
            a.PrintNumber(705000);
            a.PrintNumber(755000);
            a.PrintNumber(12334);
        }
    }
}

