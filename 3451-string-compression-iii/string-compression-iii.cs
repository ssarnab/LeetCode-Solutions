public class Solution
{
    public string CompressedString(string word)
    {
        StringBuilder result = new StringBuilder();
        char pre = word[0];
        int count = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (i > 0)
            {
                if (count != 9)
                {
                    if (word[i] == pre)
                    {
                        count++;
                        if (i == word.Length - 1)
                        {
                             result.Append(count.ToString()).Append(pre);
                        }
                    }
                    else
                    {

                         result.Append(count.ToString()).Append(pre);
                        pre = word[i];
                        count = 1;
                        if (i == word.Length - 1)
                        {
                             result.Append(count.ToString()).Append(pre);
                        }
                    }
                }

                else
                {
                     result.Append(count.ToString()).Append(pre);

                    if (word[i] != pre)
                    {
                        pre = word[i];
                    }
                    count = 1;
                    if (i == word.Length - 1)
                    {
                         result.Append(count.ToString()).Append(pre);
                    }
                }


            }

            else
            {
                pre = word[i];
                count++;
                if (i == word.Length - 1)
                {
                     result.Append(count.ToString()).Append(pre);
                }
            }

        }

        return result.ToString();
    }

}