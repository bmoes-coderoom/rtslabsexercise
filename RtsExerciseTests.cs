using Xunit;

namespace RTS;

public class RtsExerciseTests
{
    [Fact]
    public void aboveBelow_Should_Return_Dictionary_ContainingCountsOfIntsAboveAndBelowTheComparisonValue()
    {
        // arrange
        int[] list = { 1, 5, 2, 1, 10 };
        int compareValue = 6;
        var expectedDict = new Dictionary<string, int>
        {
            { "above", 1 },
            { "below", 4 }
        };

        // act
        var aboveBelowDict = RtsExercise.aboveBelow(list, compareValue);
        
        // assert
        Assert.Equal(expectedDict, aboveBelowDict);
    }
    
    [Fact]
    public void aboveBelow_Should_Return_Dictionary_Containing0ForAboveAndBelowCountsWhenListIsEmpty()
    {
        // arrange
        int[] list = Array.Empty<int>();
        int compareValue = 6;
        var expectedDict = new Dictionary<string, int>
        {
            { "above", 0 },
            { "below", 0 }
        };

        // act
        var aboveBelowDict = RtsExercise.aboveBelow(list, compareValue);
        
        // assert
        Assert.Equal(expectedDict, aboveBelowDict);
    }
    
    [Fact]
    public void aboveBelow_Should_Return_Dictionary_Containing0ForAboveAndBelowCountsWhenListIsNull()
    {
        // arrange
        int[] list = null;
        int compareValue = 6;
        var expectedDict = new Dictionary<string, int>
        {
            { "above", 0 },
            { "below", 0 }
        };

        // act
        var aboveBelowDict = RtsExercise.aboveBelow(list, compareValue);
        
        // assert
        Assert.Equal(expectedDict, aboveBelowDict);
    }

    [Fact]
    public void stringRotation_Should_Return_StringRotatedClockwiseWhenRotationAmtIsPositive()
    {
        // arrange
        string input = "MyString";
        int rotationAmt = 2;
        string expectedResult = "ngMyStri";
        
        // act
        string result = RtsExercise.stringRotation(input, rotationAmt);

        // assert
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void stringRotation_Should_Return_OriginalStringWhenRotationAmtIsLT1(int rotationAmt)
    {
        // arrange
        string input = "MyString";
        string expectedResult = input;
        
        // act
        string result = RtsExercise.stringRotation(input, rotationAmt);

        // assert
        Assert.Equal(expectedResult, result);
    }
    
    [Fact]
    public void stringRotation_Should_Return_EmptyStringWhenInputStrIsEmpty()
    {
        // arrange
        string input = "";
        int rotationAmt = 2;
        string expectedResult = input;
        
        // act
        string result = RtsExercise.stringRotation(input, rotationAmt);

        // assert
        Assert.Equal(expectedResult, result);
    }
    
    [Fact]
    public void stringRotation_Should_Return_NullWhenInputStrIsNull()
    {
        // arrange
        string input = null;
        int rotationAmt = 2;
        string expectedResult = input;
        
        // act
        string result = RtsExercise.stringRotation(input, rotationAmt);

        // assert
        Assert.Equal(expectedResult, result);
    }
    
    [Fact]
    public void stringRotation_Should_Return_SameStrWhenInputStrIsAllWhiteSpace()
    {
        // arrange
        string input = "     ";
        int rotationAmt = 2;
        string expectedResult = input;
        
        // act
        string result = RtsExercise.stringRotation(input, rotationAmt);

        // assert
        Assert.Equal(expectedResult, result);
    }
}