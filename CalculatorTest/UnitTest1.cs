using Calculator;
namespace CalculatorTest;

public class UnitTest1
{

    // Example of Test driven development create the function testing it first
    // Then move it into the production code.
    [Fact]
    public void Sum_of_2_and_2_should_be_4()
    {
        var result = Sum(2, 2);
        if(result != 4)
        {
            throw new Exception();
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