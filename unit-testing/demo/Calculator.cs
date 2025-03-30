using System.Linq.Expressions;

namespace demo;
public class Calculator
{
    public Func<int, int, int> Add = (int a, int b) => { return a + b; };
    public Expression<Func<int, int, int>> Sub = (a, b) => a - b;

}