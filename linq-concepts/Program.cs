using System.Collections.Generic;
using Dumpify;

IEnumerable<int> collection = [1, 2, 3, 4, 5];


collection.Select((x, i) => x * 2).Dump();