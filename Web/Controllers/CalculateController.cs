using Microsoft.AspNetCore.Mvc;
using Calculator;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    [HttpGet("Add/{left}/{right}")]
    public int Get(int left, int right)
    {
        CalculatorFuncs calculator = new CalculatorFuncs();
        return calculator.Sum(left, right);
    }
}
