using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;

class Graph
{
    public int v1;
    public int v2;
    public int weight;
    public Graph(int v1, int v2, int weight) { this.v1 = v1; this.v2 = v2; this.weight = weight; }
}
    class Apple
    {
        public int spelost;
        public int vetka;
        public int way;

        public Apple(int vetka, int spelost)
        {
            this.spelost = spelost;
            this.vetka = vetka;
        }
    }
class Program
{
    static void Main()
    {
        List<Graph> graphss = new();
        List<Apple> apples = new();
        List<Apple> needapples = new();
        List<int> verts2 = new();
        string[] a = Console.ReadLine().Split(" ");
        for (int i = 1; i <= int.Parse(a[0]); i++)
        {
            string[] b = Console.ReadLine().Split(" ");
            graphss.Add((new Graph(int.Parse(b[0]), i, int.Parse(b[1]))));
            if (!verts2.Contains(int.Parse(b[0]))) { verts2.Add(int.Parse(b[0])); }
            if (!verts2.Contains(i)) { verts2.Add(i); }
        }
        for (int i = 0; i < int.Parse(a[1]); i++)
        {
            string[] c = Console.ReadLine().Split(" ");
            apples.Add(new Apple(int.Parse(c[0]), int.Parse(c[1])));
        }
        string[] d = Console.ReadLine().Split(" ");
        int start = int.Parse(d[0]);
        int Spelost = int.Parse(d[1]);
        int otvet = 0;
        int counter = 0;
        int h = 0;
        foreach (Apple app in apples) { if (app.spelost >= Spelost) { needapples.Add(app); } }
        while (needapples.Count != 0)
        {
            // Console.WriteLine($"Старт - {start}");
            Dictionary<int, int> dict = new();
            List<int> verts = new List<int>();
            foreach (int vert in verts2) { verts.Add(vert); }
            List<int> vertscheked = new List<int>();
            vertscheked.Add(start);
            dict.Add(start, 0);
            verts.Remove(start);
            while (verts.Count != 0)
            {
                List<Graph> graphs = new();
                foreach (Graph graph in graphss) { graphs.Add(graph); }
                int minr = 10000000;
                int j = -1;
                int b = -1;
                for (int i = 0; i < graphs.Count; i++)
                {
                    if ((vertscheked.Contains(graphs[i].v1) && !vertscheked.Contains(graphs[i].v2)) || ((vertscheked.Contains(graphs[i].v2) && !vertscheked.Contains(graphs[i].v1))))
                    {
                        if (vertscheked.Contains(graphs[i].v1))
                        {
                            if (graphs[i].weight + dict[graphs[i].v1] < minr)
                            {
                                minr = graphs[i].weight + dict[graphs[i].v1];
                                j = i;
                                b = 1;
                            }
                        }
                        if (vertscheked.Contains(graphs[i].v2))
                        {
                            if (graphs[i].weight + dict[graphs[i].v2] < minr)
                            {
                                minr = graphs[i].weight + dict[graphs[i].v2];
                                j = i;
                                b = 2;
                            }
                        }
                    }
                }
                if (j != -1)
                {
                    if (b == 1)
                    {
                        verts.Remove(graphs[j].v2);
                        vertscheked.Add(graphs[j].v2);
                        dict.Add(graphs[j].v2, graphs[j].weight + dict[graphs[j].v1]);
                        graphs.Remove(graphs[j]);
                    }
                    if (b == 2)
                    {
                        verts.Remove(graphs[j].v1);
                        vertscheked.Add(graphs[j].v1);
                        dict.Add(graphs[j].v1, graphs[j].weight + dict[graphs[j].v2]);
                        graphs.Remove(graphs[j]);
                    }
                }
            }
            int g = int.MaxValue;
            for (int i = 0; i < needapples.Count; i++)
            {
                if (dict[needapples[i].vetka] < g) { g = dict[needapples[i].vetka]; h = i; }
            }
            otvet += g;
            //foreach(Apple app in needapples) { Console.WriteLine($"вершина - {app.vetka}, минимальное расстояние - {dict[app.vetka]}"); }
            start = needapples[h].vetka;
            verts2.Remove(needapples[h].vetka);
            needapples.Remove(needapples[h]);
           Console.WriteLine($"ответ - {otvet}");
        }
    }
}