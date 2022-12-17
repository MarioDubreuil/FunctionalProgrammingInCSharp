//

var triple = (int x) => 3 * x;
var range = Enumerable.Range(1, 3);
var triples = range.Select(triple);
foreach (var i in triples)
{
    Console.WriteLine(i);
}