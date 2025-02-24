using demo;
using System;

Console.WriteLine("Hello, World!");


Calculator c = new Calculator();
var myAdd = c.Add;
var mySub = c.Sub.Compile();


Console.WriteLine(mySub(4, 7) == 11);
Console.WriteLine(myAdd(4, 7));

