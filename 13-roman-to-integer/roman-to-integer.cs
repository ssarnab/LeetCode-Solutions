public class Solution {
    public int RomanToInt(string s) {
        
     int sum = 0;
 for (int i = 0; i < s.Length; i++)
 {
     if (s[i] == 'I')
     {
         sum += 1;
         continue;
     }
          
     if (s[i] == 'V')
     {
         if(i > 0)
         {
             if (s[i - 1] == 'I')
             {
                 sum += 3;
             }
             else
             {
                 sum += 5;
             }
         }
         else
         {
             sum += 5;
         }
         continue;
     }

     if (s[i] == 'X')
     {
         if (i > 0)
         {
             if (s[i - 1] == 'I')
             {
                 sum += 8;
             }
             else
             {
                 sum += 10;
             }
         }
         else
         {
             sum += 10;
         }
         continue;
     }
  
     if (s[i] == 'L')
     {
         if (i > 0)
         {
             if (s[i - 1] == 'X')
             {
                 sum += 30;
             }
             else
             {
                 sum += 50;
             }
         }
     
         else
         {
             sum += 50;
         }
         continue;
     }

     if (s[i] == 'C')
     {
         if (i > 0)
         {
             if (s[i - 1] == 'X')
             {
                 sum += 80;
             }
             else
             {
                 sum += 100;
             }
         }

         else
         {
             sum += 100;
         }
         continue;
     }
   
     if (s[i] == 'D')
     {
         if (i > 0)
         {
             if (s[i - 1] == 'C')
             {
                 sum += 300;
             }
             else
             {

                 sum += 500;
             }
         }
 
         else
         {
             sum += 500;
         }
         continue;
     }
       
     if (s[i] == 'M')
     {
         if (i > 0)
         {
             if (s[i - 1] == 'C')
             {
                 sum += 800;
             }
             else
             {

                 sum += 1000;
             }
         }

         else
         {
             sum += 1000;
         }
         continue;
     }
 }
 return sum;

    }
}