using Calculator;
namespace CalculatorTest;

public class UnitTest1
{
    [Fact]
    public void AddTest()
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
}