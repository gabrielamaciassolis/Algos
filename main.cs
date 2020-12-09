using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("init");
      int[] nums = {1,1,0,1,1,1,0,1,1};

     int results = FindMaxConsecutiveOnes(nums);  

    Console.WriteLine ("results {0}", results);  

    Console.WriteLine ("end");  

  }

   static public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int contador = 0;
          for(int i = 0 ; i<nums.Length ; i++){
          if(nums[i] == 1){
            contador++;
            max = Math.Max(contador,max);
          }else{
          contador = 0;
          }
        }
        return max;
    }
}