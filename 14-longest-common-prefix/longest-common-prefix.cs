public class Solution {
    public string LongestCommonPrefix(string[] array_) {
    string result = "";
int loopCount = array_ != null ? array_[0].Length : 0;

for (int i = 0; i < loopCount; i++)
{
    if (array_[0] != "")
    {
        char check = array_[0][i];

        for (int j = 1; j < array_.Length; j++)
        {

            if (array_[j] != "")
            {
                if (array_[j].Length > i)
                {
                    char c = array_[j][i];
                    if (c != check)
                    {
                        return result;
                    }
                }
                else
                {
                    return result;
                }
            }
            else
            {
                return result;
            }
        }
        result = result + check;
    }
   

}

return result;
    }
}