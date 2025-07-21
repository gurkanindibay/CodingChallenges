using NUnit.Framework;

[TestFixture]
public class ProgramTests
{
    [Test]
    public void HelloWorldTest()
    {
        Assert.That(Program.HelloWorld(), Is.EqualTo("Hello, World!"));
    }
}
