using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Dumpify;
using Newtonsoft.Json;

// IEnumerable<int> collection = [1, 2, 3, 4, 5];

// // Where for filtering
// collection.Where(x => x > 5).Dump();

// // ofType to get of specific type
// collection.OfType<int>().Dump();


// // skip 
// collection.Skip(5).Dump();

// // take that much number of element
// collection.Take(19).Dump();

// // skipWhile and TakeWhile (filter until false)

// // Select
// collection.Select((x, i) => $"{x.ToString()}---- {i}").Dump();
// var data = @"
// [
//     {
//         ""name"":""Bibek"",
//         ""age"":25,
//         ""occupation"":""Engineer"",
//         ""courses"": [""AI"", ""Machine Learning"", ""Data Structures""]
//     },
//     {
//         ""name"":""Santona"",
//         ""age"":24,
//         ""occupation"":""Designer"",
//         ""courses"": [""Graphic Design"", ""UI/UX"", ""Illustration""]
//     },
//     {
//         ""name"":""John"",
//         ""age"":30,
//         ""occupation"":""Teacher"",
//         ""courses"": [""Mathematics"", ""Physics"", ""Chemistry""]
//     },
//     {
//         ""name"":""Alice"",
//         ""age"":28,
//         ""occupation"":""Doctor"",
//         ""courses"": [""Anatomy"", ""Physiology"", ""Pharmacology""]
//     },
//     {
//         ""name"":""Michael"",
//         ""age"":35,
//         ""occupation"":""Lawyer"",
//         ""courses"": [""Constitutional Law"", ""Criminal Law"", ""Civil Rights""]
//     },
//     {
//         ""name"":""Emily"",
//         ""age"":22,
//         ""occupation"":""Student"",
//         ""courses"": [""Computer Science"", ""Psychology"", ""Literature""]
//     },
//     {
//         ""name"":""David"",
//         ""age"":40,
//         ""occupation"":""Manager"",
//         ""courses"": [""Business Management"", ""Leadership"", ""Marketing""]
//     },
//     {
//         ""name"":""Sophia"",
//         ""age"":27,
//         ""occupation"":""Nurse"",
//         ""courses"": [""Nursing"", ""First Aid"", ""Pediatrics""]
//     },
//     {
//         ""name"":""Daniel"",
//         ""age"":32,
//         ""occupation"":""Architect"",
//         ""courses"": [""Architecture Design"", ""Urban Planning"", ""Sustainable Design""]
//     },
//     {
//         ""name"":""Olivia"",
//         ""age"":29,
//         ""occupation"":""Writer"",
//         ""courses"": [""Creative Writing"", ""Literature"", ""Journalism""]
//     }
// ]";


// var persons = JsonConvert.DeserializeObject<Person[]>(data);

// persons.Select(x => x.courses).Dump();

// record Person(string name, int age, string occupation, List<string> courses);


List<int> nums = [1, 2, 3];
List<string> names = ["Bibek", "Memphis"];

nums.SelectMany(x => names, (num, name) => new { name, num }).Dump();

