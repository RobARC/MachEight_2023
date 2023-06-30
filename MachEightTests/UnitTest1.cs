using MachEighChallenge;

namespace MachEightTests;
public class Tests
{
    [Test]
    public void Sum_Should_Print_Pairs_When_Found()
    {
        // Arrange Positives Numbers
        List<int> numbers = new List<int>{2, 4, 6, 8, 10, 12, 14, 16};
        int targetSum = 18;

        // Act
        Find_Pairs.Find_Numbers_Pairs(numbers, targetSum);

        //Print Array and targetSum
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
    }
    [Test]
    public void Sum_Should_Print_Pairs_When_Found2()
    {
        // Arrange Negatives Numbers
        List<int> numbers = new List<int>{-2, -4, -6, -8, -10, -12, -14, -16};
        int targetSum = -18;

        // Act
        Find_Pairs.Find_Numbers_Pairs(numbers, targetSum);

        //Print Array and targetSum
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
    }
    [Test]
    public void Sum_Should_Print_No_pairs_were_found()
    {
        // Arrange No pairs were found
        List<int> numbers = new List<int>{-2, 4, -6, 8, -10, 12, -14, 16};
        int targetSum = -18;

        // Act
        Find_Pairs.Find_Numbers_Pairs(numbers, targetSum);

        //Print Array and targetSum
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
    }
     [Test]
    public void Sum_Should_Print_Error_Message()
    {
        // Arrange Print Error Message
        List<int> numbers = new List<int>{};
        int targetSum = -18;

        // Act
        Find_Pairs.Find_Numbers_Pairs(numbers, targetSum);

        //Print Array and targetSum
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
    }
     [Test]
    public void Should_Print_Only_One_Pair()
    {
        // Arrange
        List<int> numbers = new List<int>{5, 7};
        int targetSum = 12;

        // Act
        Find_Pairs.Find_Numbers_Pairs(numbers, targetSum);

        //Print Array and targetSum
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
    }
    [Test]
    public void Should_Print_Unique_Element()
    {
        // Arrange Print Error Message
        List<int> numbers = new List<int>{ 10 };
        int targetSum = 10;

        // Act
        Find_Pairs.Find_Numbers_Pairs(numbers, targetSum);

        //Print Array and targetSum
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
    }
     [Test]
    public void Should_Print_Big_Numbers()
    {
        // Arrange
        List<int> numbers = new List<int>{ 1000, 2000, 3000, 4000, 5000 };
        int targetSum = 5000;

        // Act
        Find_Pairs.Find_Numbers_Pairs(numbers, targetSum);

        //Print Array and targetSum
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
    }
    [Test]
    public void Should_Print_TargetSum_Zero()
    {
        // Arrange
        List<int> numbers = new List<int>{ 2, 4, 0, -2, -4 };
        int targetSum = 0;

        // Act
        Find_Pairs.Find_Numbers_Pairs(numbers, targetSum);

        //Print Array and targetSum
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Target Sum: {targetSum}");
    }
}