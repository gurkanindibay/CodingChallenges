public class FindKCountWithBucket
{
    public static List<int> find(int[] values, int k)
    {
        Dictionary<int, int> map = [];

        foreach (int i in values)
        {
            if (map.TryGetValue(i, out int ret))
            {
                map[i] = ret++;
            }
            else
            {
                map[i] = 1;
            }
        }

        List<int>[] buckets = new List<int>[values.Length];

        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = [];
        }

        foreach (var pair in map)
        {
            buckets[pair.Value].Add(pair.Key);
        }

        List<int> result = [];

        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            result.AddRange(buckets[i]);
        }

        return [.. result.Take(2)];


    }
}