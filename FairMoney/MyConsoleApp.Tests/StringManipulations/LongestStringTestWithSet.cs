[TestFixture]
public class LongestStringTestWithSet
{
    [Test]
    public void TestLongestString()
    {
        int len = LongestString.findWithSet("abdedfge");

        Assert.That(len, Is.EqualTo(4));
    }

    [Test]
    public void TestLongestString1()
    {
        int len = LongestString.findWithSet("abba");

        Assert.That(len, Is.EqualTo(2));
    }

    [Test]
    public void TestLongestString2()
    {
        int len = LongestString.findWithSet("dvdf");

        Assert.That(len, Is.EqualTo(3));
    }

    [Test]
    public void TestLongestStringOneChar()
    {
        int len = LongestString.findWithSet("bbbbbb");

        Assert.That(len, Is.EqualTo(1));
    }

    [Test]
    public void TestLongestStringEmpty()
    {
        int len = LongestString.findWithSet("");

        Assert.That(len, Is.EqualTo(0));
    }

    [Test]
    public void TestLongestStringNull()
    {
        int len = LongestString.findWithSet(null);

        Assert.That(len, Is.EqualTo(0));
    }
}