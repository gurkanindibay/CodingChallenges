[TestFixture]
public class ValidParanthesisTest
{
    [Test]
    public void TestValidStringIncludesAll()
    {
        string s = "{[]}";

        Assert.That(ValidParanthesis.IsValid(s), Is.EqualTo(true));
    }
    [Test]
    public void TestInValidString1()
    {
        string s = "{[]";

        Assert.That(ValidParanthesis.IsValid(s), Is.EqualTo(false));
    }

    [Test]
    public void TestInValidString2()
    {
        string s = "{[}]";

        Assert.That(ValidParanthesis.IsValid(s), Is.EqualTo(false));
    }
}