using Calculator;
using FluentAssertions;

namespace CalculatorTest;

public class CalculatorTest
{
    // This parameterized test allow for reusablity of test functions.
    // We are running the AddingParameterize test a total of four times.  
    // Parameterized Test
    [Theory]
    [InlineData(3, 1)]
    [InlineData(1, 2)]
    [InlineData(3, 3)]
    [InlineData(3, 4)]
    [InlineData(7, 9)]
    [InlineData(10, 0)]    
    public void AddingParamaterize(int x, int y)
    {
        int result = x + y;
        Assert.Equal(result, Sum(x, y));
    }
    // Getting rid of the if statement using Fluent Assertions
    // To install do the following, run: 
    // dotnet add package FluentAssertions
    // ```dotnet test```
    [Fact]
    public void Fluent_Assertion_Test_1()
        => new CalculatorFuncs()
            .Sum(2, 2)
            .Should().Be(4);  

    // Example of Test driven development create the function testing it first
    // Then move it into the production code.
    [Fact]
    public void Sum_of_2_and_2_should_be_4()
    {
        int result = Sum(2, 2);
        // result = 10;
        if(result != 4)
        {
            throw new Exception($"The Sum(2,2) should return 4, but we recieved {result}.\n");
        }
    }

    public int Sum(int left, int right)
    {
        return left + right;
    }
    //////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void AddTest1()
    {
        // Arrange
        CalculatorFuncs cal = new CalculatorFuncs();
        int result1 = cal.Sum(2, 3);
        int result2 = cal.Sum(2, 2);

        // Assert
        Assert.Equal(5, result1);
        Assert.Equal(4, result2);        
    }

    [Fact]
    public void AddTest2()
    {
        // Arrange
        CalculatorFuncs cal = new CalculatorFuncs();
        int result1 = cal.Sum(4, 4);
        int result2 = cal.Sum(9, 9);

        // Assert
        Assert.Equal(8, result1);
        Assert.Equal(18, result2);           
    }

    [Fact]
    public void SubTest1()
    {
        // Arrange
        CalculatorFuncs cal = new CalculatorFuncs();
        int result1 = cal.Subtract(2, 3);
        int result2 = cal.Subtract(2, 4);

        // Assert
        Assert.Equal(-1, result1);
        Assert.Equal(-2, result2);        
    }

    [Fact]
    public void SubTest2()
    {
        // Arrange
        CalculatorFuncs cal = new CalculatorFuncs();
        int result1 = cal.Subtract(4, 4);
        int result2 = cal.Subtract(9, 9);

        // Assert
        Assert.Equal(0, result1);
        Assert.Equal(0, result2);           
    }    
}