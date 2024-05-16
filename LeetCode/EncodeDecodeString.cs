using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class EncodeDecodeString
    {
        public static string Encode(List<string> input)
        {
            var output = new StringBuilder();

            foreach (var item in input)
            {
                output.Append(item.Length + "/" + item);
            }

            return output.ToString();
        }

        public static List<string> Decode(string encodedString)
        {
            var result = new List<string>();

            var i = 0;
            while (i < encodedString.Length)
            {
                var j = i;
                while (encodedString[j] != '/')
                {
                    ++j;
                }

                int.TryParse(encodedString.Substring(i, j - i), out var size);

                j++;

                var word = encodedString.Substring(j, size);
                result.Add(word);

                i = j + size;
            }

            return result;
        }
    }
}
