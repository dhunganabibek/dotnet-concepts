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

            //Console.Write("x:");
            //var x = int.Parse(Console.ReadLine());

            //Console.Write("y:");
            //var y = int.Parse(Console.ReadLine());

            //Console.Write("Operation:");
            //var operation = Console.ReadLine();

            //if(operation == "+")
            //{
            //    Console.WriteLine($"{x} + {y} = {x+y}");
            //}
            //else if(operation == "-")
            //{
            //    Console.WriteLine($"{x} - {y} = {x - y}");
            //}

            //var i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}

            //Console.ReadKey();

            for(var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++) {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                
            }

            Console.ReadKey();



        }

    }
}



