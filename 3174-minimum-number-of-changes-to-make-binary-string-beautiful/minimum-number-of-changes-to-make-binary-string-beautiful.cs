public class Solution {
    public int MinChanges(string s)
  {
      int result = 0;
      char pre = s[0];

      for (int i = 1; i < s.Length; i+=2)
      {
          if (s[i] != pre)
          {
              result++;
          }
          if(i != s.Length -1)
          {
              pre = s[i + 1];
          }
      }
          return result;
  }
}