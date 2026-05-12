using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    #region 两数之和
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            int complement = target - nums[i];
            if (numMap.TryGetValue(complement, out int index))
            {
                return new int[] { index, i };
            }
            else
            {
                numMap.TryAdd(num, i);
            }
        }

        return new int[] { 0 };
    }
    #endregion

    #region 49.字母异位词分组
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            string str = strs[i];
            string key = GetKey2(str);

            if (anagramMap.TryGetValue(key, out List<string> anagrams))
            {
                anagrams.Add(str);
            }
            else
            {
                anagramMap.Add(key, new List<string>() { str });
            }
        }

        return new List<IList<string>>(anagramMap.Values);
    }

    private string GetKey(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Sort(charArray);
        return new string(charArray);
    }

    private string GetKey2(string str)
    {
        char[] chars = str.ToCharArray();
        int[] count = new int[26];
        for (int i = 0; i < chars.Length; i++)
        {
            count[chars[i] - 'a']++;
        }
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > 0)
            {
                sb.Append((char)('a' + i));
                sb.Append(count[i]);
            }
        }
        return sb.ToString();
    }

    #endregion

    #region 1.两数之和
    #endregion
}
