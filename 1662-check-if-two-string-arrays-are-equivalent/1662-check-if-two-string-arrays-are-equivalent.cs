public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
        string one = "";
        string two = "";
        int wordOneLength = word1.Length;
        int wordTwoLength = word2.Length;
        int max = 0;
        
        if(wordOneLength > wordTwoLength) max = wordOneLength;
        else max = wordTwoLength;
        
        for(int i = 0 ; i<max;i++)
        {
            if( i < wordOneLength){
                one = one + word1[i] ;
            }
             if( i < wordTwoLength)
             {
                two = two + word2[i] ;
              }
        }
        if(one == two)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}