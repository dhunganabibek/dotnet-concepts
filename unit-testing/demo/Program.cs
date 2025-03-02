Test t1 = new Test(10, 20);
Test t2 = t1;
t2.a = 500;

System.Console.WriteLine(t2.a);


public struct Test
{

    public int a { get; set; }
    public int b { get; set; }

    public Test(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}