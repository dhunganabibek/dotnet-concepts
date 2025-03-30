

class MainClass
{
    static void Main()
    {
        //function expression
        // treating function as first class citizen
        // (lambda expression, Delegate --> to give type to lambda expression)

        // Why? 
        // 1. save function as variable, 
        // 2. second pass function as arguments,
        // 3. return function from function (closure)
        Func<int, bool> isOddFE = num => num % 2 == 0;
        var a2 = isOddFD;

        int a = 10;
        string name = "santona";
        bool isTrue = true;

        List<int> list = [1, 2, 3];


        // Function declartion
        bool isOddFD(int num, string test)
        {
            return num % 2 == 0;
        }
        System.Console.WriteLine(Santona.age);
        System.Console.WriteLine(Santona.isHappy);
    }
}

class Santona
{
    public static int age = 10;

    public static string isHappy()
    {
        return "isHappy";
    }
}








