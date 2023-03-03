namespace com.bibekdhunga
{
    class Test{

        public static void Main()
        {
            //Console.WriteLine("Hello, Place");
            //var list = new List<Int64> { 1, 2, 3, 4, 5 };
            //var dict = new Dictionary<string, string>();

            //dict["name"] = "Bibek";
            //dict["age"] = "15";

            //Console.WriteLine(list);

            //Console.WriteLine("Hello, test2");

            Console.Write("x:");
            var x = int.Parse(Console.ReadLine());

            Console.Write("y:");
            var y = int.Parse(Console.ReadLine());

            Console.Write("Operation:");
            var operation = Console.ReadLine();

            if(operation == "+")
            {
                Console.WriteLine($"{x} + {y} = {x+y}");
            }
            else if(operation == "-")
            {
                Console.WriteLine($"{x} - {y} = {x - y}");
            }

        }

    }
}



