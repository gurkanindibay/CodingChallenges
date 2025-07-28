[TestFixture]
public class LongestStringTest
{
    [Test]
    public void TestLongestString()
    {
        int len = LongestString.find("abdedfge");

        Assert.That(len, Is.EqualTo(4));
    }

    [Test]
    public void TestLongestString1()
    {
        int len = LongestString.find("abba");

        Assert.That(len, Is.EqualTo(2));
    }

    [Test]
    public void TestLongestString2()
    {
        int len = LongestString.find("dvdf");

        Assert.That(len, Is.EqualTo(3));
    }

    [Test]
    public void TestLongestStringOneChar()
    {
        int len = LongestString.find("bbbbbb");

        Assert.That(len, Is.EqualTo(1));
    }

    [Test]
    public void TestLongestStringEmpty()
    {
        int len = LongestString.find("");

        Assert.That(len, Is.EqualTo(0));
    }

    [Test]
    public void TestLongestStringNull()
    {
        int len = LongestString.find(null);

        Assert.That(len, Is.EqualTo(0));
    }
}