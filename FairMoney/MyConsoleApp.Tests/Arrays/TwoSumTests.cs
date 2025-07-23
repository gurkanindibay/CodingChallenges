[TestFixture]
public class TwoSumTests
{
    private static readonly int[] testArray = { 2, 7, 9, 15 };

    [Test]
    public void TwoSumTestResultExists()
    {
        int[] expected = [0, 2];
        int target = 11;

        var result = TwoSumProblem.FindTwoSum(testArray, target);

        Assert.That(result, Is.EquivalentTo(expected));
    }
    
        [Test]
    public void TwoSumTestResultNotExists()
    {
        int[] expected = [0, 0];
        int target = 18;

        var result = TwoSumProblem.FindTwoSum(testArray, target);

        Assert.That(result, Is.EquivalentTo(expected));
    }
}