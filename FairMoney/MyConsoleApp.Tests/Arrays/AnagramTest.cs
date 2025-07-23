[TestFixture]
public class AnagramTest
{
    [Test]
    public static void IsAnagramTest_True()
    {
        string str1 = "anagram";
        string str2 = "ganaram";

        var result = AnagramFinder.FindAnagram(str1, str2);

        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public static void IsAnagramTest_False()
    {
        string str1 = "anagram";
        string str2 = "ganara";

        var result = AnagramFinder.FindAnagram(str1, str2);

        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public static void IsAnagramTest_False2()
    {
        string str1 = "anagram";
        string str2 = "ganaraa";

        var result = AnagramFinder.FindAnagram(str1, str2);

        Assert.That(result, Is.EqualTo(false));
    }
}