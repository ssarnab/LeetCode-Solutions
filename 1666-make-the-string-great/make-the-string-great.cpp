class Solution {
public:
    string makeGood(string s) {
      stack<char> st;
    // Iterate through the string
    for (char ch : s) {
        // Check if the stack is not empty and the current character combined with the top of the stack forms a "bad" pair
        if (!st.empty() && abs(st.top() - ch) == 32) {
            // Pop the character from the stack
            st.pop();
        } else {
            // Push the current character onto the stack
            st.push(ch);
        }
    }
    // Reconstruct the string from the characters remaining in the stack
    string result = "";
    while (!st.empty()) {
        result = st.top() + result;
        st.pop();
    }
    return result;
    }
};