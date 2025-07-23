public class TwoSumProblem
{
    public static int[] FindTwoSum(int[] numList, int target)
    {
        int[] result = new int[2];
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < numList.Length; i++)
        {
            var exists = dict.TryGetValue(target - numList[i], out int outIndex);
            if (exists)
            {
                result[0] = outIndex;
                result[1] = i;
                break;
            }
            else
            {
                dict[numList[i]] = i;
            }
        }

        return result;
    }
}