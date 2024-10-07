public class Solution {
    public int MinLength(string s)
{

    for (int i = 0; i < s.Length; i++)
    {
        ///if (i > 0)
        {
            if (i > 0 && s[i-1] == 'A')
            {
                if ( s[i] == 'B')
                {
                    s = s.Remove(i-1, 2);
                    i = 0;
                }
            }
            if (i > 0 && s[i-1] == 'C')
            {
                if ( s[i] == 'D')
                {
                    s = s.Remove(i-1, 2);
                    i = 0;
                }
            }
        }
    }

    return s.Length;
}
}

