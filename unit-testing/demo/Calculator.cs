using System.Linq.Expressions;

namespace demo;
public class Calculator
{
    public Func<int, int, int> Add = (a, b) => a + b;
    public Expression<Func<int, int, int>> Sub = (a, b) => a - b;

}