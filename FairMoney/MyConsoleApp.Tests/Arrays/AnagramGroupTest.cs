[TestFixture]

public class AnagramGroupTest
{
    [Test]
    public void TestGroup()
    {
        List<string> strList = ["eat", "tea", "tan", "ate", "nat", "bat"];

        List<List<string>> strGroups = AnagramGroup.Groups(strList);

        foreach (var list in strGroups) {
            Console.WriteLine("----List---");
            foreach (var str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}