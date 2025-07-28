public class AnagramGroup
{

    public static List<List<string>> Groups(List<string> strList)
    {
        Dictionary<string, List<string>> stringDict = [];

        foreach (var str in strList)
        {
            int[] charKey = new int[26];

            char[] charArray = str.ToCharArray();

            foreach (var c in charArray)
            {
                charKey[c - 'a']++;
            }

            string key = string.Join("#", charKey);

            if (!stringDict.ContainsKey(key))
            {  
                stringDict[key] = [];
            }
            stringDict[key].Add(str);
            
        }

        return [.. stringDict.Values];
    }
}