namespace Calculator;

public class CalculatorFuncs
{
    public int Sum(int left, int right)
        => left + right;

    public int Subtract(int left, int right)
        => left - right;   

    public int Multiply(int left, int right)
        => left * right;
    
    public int Divide(int left, int right)
        => left / right;
    
    public int CircleArea(int diameter)
        => ((diameter / 2)^2) * Math.PI;

    public int CubeVolume(int side)
        => (side^3);

    public int PrismVolume(int areaOfBase, int height)
        => (areaOfBase * height);
}