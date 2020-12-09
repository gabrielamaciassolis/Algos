
using System;
public class FindMaxConsecutiveOnesC {
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