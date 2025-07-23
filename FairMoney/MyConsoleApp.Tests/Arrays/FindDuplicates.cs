[TestFixture]
public class FindDupliatesTest
{

    private int[] duplicateArray = { 1, 2, 3, 4, 5, 1 };
    private int[] nonDuplicateArray = { 1, 2, 3, 4, 5 };
    [Test]
    public void TestDuplicate()
    {
        Assert.That(FindDuplicates.Find(duplicateArray), Is.EqualTo(true));
    }

    [Test]
    public void TestNonDuplicate()
    {
        Assert.That(FindDuplicates.Find(nonDuplicateArray), Is.EqualTo(false));
    }

    [Test]
    public void TestEmptyArray()
    {
        Assert.That(FindDuplicates.Find([]), Is.EqualTo(false));
    }


    [Test]  
    public void TestNullArray()
    {
        Assert.That(FindDuplicates.Find(null), Is.EqualTo(false));
    }

}