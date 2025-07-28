using System.Collections.Generic;
using System.Reflection.PortableExecutable;

public class LongestString
{

    public static int find(string input)
    {
        if (input == null) return 0;
        List<int> nums = [];
        char[] chars = input.ToCharArray();
        int max = 0;
        Dictionary<char, int> dict = [];
        int counter = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];
            if (!dict.TryGetValue(c, out int li))
            {
                counter++;
                max = counter > max ? counter : max;
                dict[c] = i;
            }
            else
            {
                counter = i - li;
            }
        }

        return max;
    }

    public static int findWithSet(string input)
    {

        if (input == null || input.Length == 0) return 0;
        int maxLength = 0;
        char[] chars = input.ToCharArray();

        HashSet<char> charSet = [];
        int left = 0;

        for (int right = 0; right < chars.Length; right++)
        {
            while (charSet.Contains(chars[right]))
            {
                charSet.Remove(chars[left]);
                left++;
            }
            charSet.Add(chars[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;

    }
}