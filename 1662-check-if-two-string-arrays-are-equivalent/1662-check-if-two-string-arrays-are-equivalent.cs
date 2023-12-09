public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
//         string one = "";
//         string two = "";
//         int wordOneLength = word1.Length;
//         int wordTwoLength = word2.Length;
//         int max = 0;
        
//         if(wordOneLength > wordTwoLength) max = wordOneLength;
//         else max = wordTwoLength;
        
//         for(int i = 0 ; i<max;i++)
//         {
//             if( i < wordOneLength){
//                 one = one + word1[i] ;
//             }
//              if( i < wordTwoLength)
//              {
//                 two = two + word2[i] ;
//               }
//         }
//         if(one == two)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
        
        
        
//         StringBuilder one = new StringBuilder();
//         StringBuilder two = new StringBuilder();

//         foreach (string word in word1) {
//             one.Append(word);
//         }

//         foreach (string word in word2) {
//             two.Append(word);
//         }

//         return one.ToString() == two.ToString();
        
              int i = 0; // index for word1
        int j = 0; // index for word2
        int charIndex1 = 0; // index for characters in word1[i]
        int charIndex2 = 0; // index for characters in word2[j]

        while (i < word1.Length && j < word2.Length) {
            // Compare characters
            if (word1[i][charIndex1] != word2[j][charIndex2]) {
                return false;
            }

            // Move to the next character
            charIndex1++;
            charIndex2++;

            // Move to the next word if we reach the end of a word
            if (charIndex1 == word1[i].Length) {
                i++;
                charIndex1 = 0;
            }

            if (charIndex2 == word2[j].Length) {
                j++;
                charIndex2 = 0;
            }
        }

        // Check if both arrays are exhausted
        return i == word1.Length && j == word2.Length;
        
    }
}