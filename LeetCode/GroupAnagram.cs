namespace LeetCode
{
    public static class GroupAnagram
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {

            var groups = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                char[] hash = new char[26];
                foreach (char c in str)
                {
                    hash[c - 'a']++;
                }

                string key = new string(hash);
                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }

                groups[key].Add(str);
            }

            return groups.Values.ToList();
        }
    }
}
