using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace LeetCode;

public static class LongestSubstringWithoutRepeatCharacters 
{
    public static int LengthOfLongestSubstring(string s) 
    {
        var charSet = new HashSet<char>();

        int left=0, right=0, maxLength=0;

        while (right < s.Length) 
        {
            if (!charSet.Contains(s[right])) 
            {
                charSet.Add(s[right]);
                right++;

                maxLength = Math.Max(maxLength, charSet.Count);
            }
            else 
            {
                charSet.Remove(s[left]);
                left++;
            }
        } 
        return maxLength;
    }
}