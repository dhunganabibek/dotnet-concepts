using Dumpify;

IEnumerable<int> collection = [1, 2, 3, 4, 5];

// Where for filtering
collection.Where(x => x > 5).Dump();

// ofType to get of specific type
collection.OfType<int>().Dump();


// skip 
collection.Skip(5).Dump();

// take that much number of element
collection.Take(19).Dump();

// skipWhile and TakeWhile (filter until false)

// Select
collection.Select((x, i) => $"{x.ToString()}---- {i}").Dump();