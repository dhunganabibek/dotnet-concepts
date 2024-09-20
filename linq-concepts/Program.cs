using System.Collections.Generic;
using System.Collections;
using Dumpify;

IEnumerable<int> collection = [1, 2, 3, 4, 5];

ArrayList al = new ArrayList();
al.Add(1);
al.Add(2);
al.Add(3);

System.Console.WriteLine(al);

// collection.Count().Dump();

// collection.Select((x, i) => x * 2).Dump();