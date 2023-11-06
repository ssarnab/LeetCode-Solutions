public class Solution {
    public int GetWinner(int[] arr, int k) {
      int winCount = 0;
      int maxValue=arr[0];
      for(int i=1;i<arr.Length;i++)
      {
        if(maxValue<arr[i])
        {
          maxValue=arr[i];
          winCount=1;
        }
        else
          winCount++;
          
        if(winCount==k) return maxValue;
      }
      return maxValue;
        
    }
}