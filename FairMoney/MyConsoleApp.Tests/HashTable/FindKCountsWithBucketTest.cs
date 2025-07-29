[TestFixture]
public class FindKCountsWithBucketTest
{

    [Test]
    public void Test1()
    {
        int[] values = [1, 1, 1, 2, 2, 3];
        List<int> result = FindKCountWithBucket.find(values, 2);

        Assert.That(result[0], Is.EqualTo(1));
        Assert.That(result[1], Is.EqualTo(2));
    }
}