public class FindKCount
{
    public static  List<int> find(int[] values, int k)
    {
        Dictionary<int, int> map = [];

        foreach (int i in values)
        {
            if (map.TryGetValue(i, out int result))
            {
                map[i] = result++;
            }
            else
            {
                map[i] = 1;
            }
        }

        var topKKeys = map.OrderByDescending(entry => entry.Value)
        .Take(k)
        .Select(entry => entry.Key)
        .ToList();

        return topKKeys;
    }
}