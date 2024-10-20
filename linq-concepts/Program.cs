

#region working with path

var totalPath = Path.Combine(Directory.GetCurrentDirectory(), "hello/you");
System.Console.WriteLine(totalPath);

#endregion


#region LINQ using lambda 

#endregion

#region  group by
// var number = new List<int> { 10, 2, 3, 4, 100, 6, 7, 8, 9, 1 };

// var query = from num in number
//             orderby num descending
//             group num by num % 2 == 0 ? "Even" : "Odd" into numGroup
//             select new { category = numGroup.Key, Numbers = numGroup };


// var result = number.GroupBy(x => x % 2 == 0 ? "Even" : "Odd")
//     .Select(x => new { category = x.Key, Numbers = x });

// foreach (var item in query)
// {
//     Console.WriteLine($"{item.category} -----  {string.Join(", ", item.Numbers)}");
// }
#endregion
#region LINQ architecture
// System.Console.WriteLine("LINQ Query");
// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// foreach (var item in numbers)
// {
//     if (item % 2 == 0)
//     {
//         System.Console.WriteLine(item);
//     }
// }
// System.Console.WriteLine("----------------------- ");

// var query = from num in numbers
//             where num % 2 == 0
//             select num;
// foreach (var item in query)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine("-----------------------------");

// var data = numbers.Where(x => x % 2 == 0);
// foreach (var item in data)
// {
//     System.Console.WriteLine(item);
// }
#endregion
#region Anonymous Types

// var p = new { Name = "John", Age = 20 };
// System.Console.WriteLine(p.Name);


// Student s = new Student();
// System.Console.WriteLine(s.Name);

// class Student
// {
//     int Id;
//     public string Name
//     {
//         get
//         {
//             return "John";
//         }
//         set
//         {
//             Name = value;
//         }
//     }
//     int Age;
// };
#endregion
#region IComparable and IComparer

// List<Student> list = new List<Student> {
//         new Student { Id = 1, Name = "John", Age = 20 },
//         new Student { Id = 2, Name = "Jane", Age = 22 },
//         new Student { Id = 3, Name = "Doe", Age = 24 },
//         new Student { Id = 4, Name = "Smith", Age = 26 },
//         new Student { Id = 5, Name = "Doe", Age = 28 }
//         };


// foreach (var item in list)
// {
//     Console.WriteLine(item.Name);
// }


// class Student
// {
//     public int Id { get; set; }
// public string Name { get; set; }
// public int Age { get; set; }
// }

#endregion
#region LINQ Concepts

// IEnumerable<int> collection = [1, 2, 3, 4, 5];

// ArrayList al = new ArrayList();
// al.Add(1);
// al.Add(2);
// al.Add(3);

// foreach (var item in al)
// {
//     Console.WriteLine(item);
// }

// al.ToArray().Dump();

// // collection.Count().Dump();

// // collection.Select((x, i) => x * 2).Dump();

#endregion