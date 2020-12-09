using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("init");
      int[] nums = {12,345,2,6,7896};

     int results = FindNumbersEvenDigitsC.FindNumbersEvenDigits(nums);  

    Console.WriteLine ("results {0}", results);  

    Console.WriteLine ("end");  

  }

  
}