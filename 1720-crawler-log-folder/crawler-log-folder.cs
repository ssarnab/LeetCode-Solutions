public class Solution {
    public int MinOperations(string[] logs) {

      int state = 0;  
      for(int i=0;i<logs.Length;i++){
        if(logs[i]== "../"){
            if (state !=0){
                state = state - 1 ;
            }
        }
         else{    
            if(logs[i]!= "./")
                { 
                 state = state + 1;
                }
            }
      }
return state;
    }
}