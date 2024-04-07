public class Solution {
    public string MinRemoveToMakeValid(string s) {
        int o = 0, cl = 0, f = 0;
        foreach (char c in s) 
        {
            if (c == '(')
            {
                o++;
                f++;
            }
            else if (c == ')' && f > 0)
            {
                cl++;
                f--;
            }
        }
        
        int k = Math.Min(o, cl);
        string re = "";
        o = k;
        cl = k;
        foreach (char c in s)
        {
            if (c == '(')
            {
                if (o > 0)
                {
                    re += '(';
                    o--;
                }
                continue;
            }
            if (c == ')')
            {
                if (cl > 0 && cl > o)
                {
                    re += ')';
                    cl--;
                }
                continue;
            } 
            else
            {
                re += c;
            }
        }
        return re;
    }
}