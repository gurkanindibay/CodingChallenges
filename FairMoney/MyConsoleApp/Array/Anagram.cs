public class AnagramFinder
{
    public static  bool FindAnagram(string s, string t)
    {
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Dictionary<char, int> sDict = [];
        Dictionary<char, int> tDict = [];

        for (int i = 0; i < sArray.Length; i++)
        {
            bool exists = sDict.TryGetValue(sArray[i], out int count);

            count = exists ? count + 1 : 1;
            sDict[sArray[i]] = count;
        }


        for (int i = 0; i < tArray.Length; i++)
        {
            bool existsInSArray = sDict.TryGetValue(tArray[i], out int countSArray);
            bool existsInTArray = tDict.TryGetValue(tArray[i], out int countTArray);

            if (existsInTArray && !existsInSArray) return false;

            countTArray = existsInTArray ? countTArray + 1 : 1;

            if (existsInSArray && existsInTArray && countTArray > countSArray) return false;

            tDict[tArray[i]] = countTArray;
        }
        

        if (sDict.Keys.Count != tDict.Keys.Count) return false;

        foreach (char c in sDict.Keys)
        {

            if (sDict[c] != tDict[c]) return false;

        }

        return true;
    }
}