public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int keepIndex = 0;
        int moveIndex = 0;
        int maxLength = s.Length == 1 ? 1 : 0;
        Dictionary<int, char> collectionSubstring = new Dictionary<int, char>();

        while (keepIndex < s.Length && moveIndex < s.Length)
        {
            if (collectionSubstring.ContainsValue(s[moveIndex]))
            {
                keepIndex++;
                moveIndex = keepIndex;
                collectionSubstring.Clear();
            }
            collectionSubstring.Add(moveIndex, s[moveIndex]);
            maxLength = maxLength > (moveIndex - keepIndex + 1) ?
                        maxLength : (moveIndex - keepIndex + 1);
            moveIndex++;
        }
        return maxLength;
    }
}