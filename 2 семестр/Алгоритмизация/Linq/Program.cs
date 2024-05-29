using System.Threading.Tasks.Dataflow;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> ints = new() { 1, 2, 25, 50, 32, 678, 345, 897, 3545, 7867 };
        var a =
            from aa in ints
            where (aa % 10) % 3 == 0
            select aa;
        var b = from bb in ints where Enumerable.Range(0, bb.ToString().Length).Any(i => Convert.ToInt32(bb.ToString()[i]) % 2 == 0)
                select bb;
        Console.WriteLine("Числа, у которых последняя цифра кратна 3: ");
        foreach( var aa in a ) Console.Write (aa + " ");
        Console.WriteLine("\nЧисла, в которых присутствует четная цифра: ");
        foreach (var bb in b) { Console.Write(bb + " "); }

        int[] intss = { 1, 2, 25, 33, 324, 52323, 6522, 124 };
        var c = from cc in intss where cc % 2 == 0 select cc;
        Console.WriteLine("\nРезультат первой выборки: ");
        foreach(var cc in c ) Console.WriteLine(cc);
        intss = Enumerable.Range(0, intss.Length).Select(i => i % 2 != 0 ? 2 : intss[i]).ToArray();
        var dd =
               from d in intss
               where d % 2 == 0
               select d;
        Console.WriteLine("\nРезультат второй выборки: ");
        foreach(var d in dd) Console.Write(d + " ");
    }


}
