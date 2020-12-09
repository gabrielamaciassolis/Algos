
using System;
public class FindNumbersEvenDigitsC {
  static public int FindNumbersEvenDigits(int[] nums) {

/*       loop the "nums"
       covert int to string
       get the len nums[i].length
       len % == 0 then it is even
       result++
*/
int result = 0;
for(int i=0; i < nums.Length;i++){
  string x = nums[i].ToString();
  int len = x.Length;
  if(len % 2 == 0){
    result++;
  }
}
return result;
    }
}