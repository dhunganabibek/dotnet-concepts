using System.Security.Cryptography;
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
var data = @"
[
    {""name"":""Bibek"", ""age"":25, ""occupation"":""Engineer""},
    {""name"":""Santona"", ""age"":24, ""occupation"":""Designer""},
    {""name"":""John"", ""age"":30, ""occupation"":""Teacher""},
    {""name"":""Alice"", ""age"":28, ""occupation"":""Doctor""},
    {""name"":""Michael"", ""age"":35, ""occupation"":""Lawyer""},
    {""name"":""Emily"", ""age"":22, ""occupation"":""Student""},
    {""name"":""David"", ""age"":40, ""occupation"":""Manager""},
    {""name"":""Sophia"", ""age"":27, ""occupation"":""Nurse""},
    {""name"":""Daniel"", ""age"":32, ""occupation"":""Architect""},
    {""name"":""Olivia"", ""age"":29, ""occupation"":""Writer""}
]";

;

var persons = JsonConvert.DeserializeObject<Person[]>(data);
Console.WriteLine(JsonConvert.SerializeObject(persons, Formatting.Indented));

record Person(string name, int age, string occupation);