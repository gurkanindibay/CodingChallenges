public class FindDuplicates
{
    public static bool Find(int[] targetArray)
    {
        if (targetArray == null) return false;
        Dictionary<int, int> duplicateDict = [];

        for (int i = 0; i < targetArray.Length; i++)
        {
            if (duplicateDict.TryGetValue(targetArray[i], out int index))
            {
                return true;
            }
            else
            {
                duplicateDict[targetArray[i]] = i;
            }
        }

        return false;

    }
}