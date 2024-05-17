class Graph
{
    public int v1;
    public int v2;
    public Graph(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }
}
class Programm
{
    static void Main()
    {
        List<Graph> graphs = new List<Graph>();
        List<Graph> graph = new List<Graph>();
        List<int> verts = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        while (true)
        {
            Console.Write("Введите номер первой вершины (end = break): ");
            string ss = Console.ReadLine();
            if (ss == "end") { break; }
            int f = Convert.ToInt32(ss);
            Console.Write("Введите номер второй вершины: ");
            int g = int.Parse(Console.ReadLine());
            graphs.Add(new Graph(f, g));
            graph.Add(new Graph(f, g));
            if (!verts.Contains(f)) { verts.Add(f); }
            if (!verts.Contains(g)) { verts.Add(g); }
        }
        List<int> vertscheked = new List<int>();
        Console.Write("Введите номер вершины с которой хотите начать: ");
        int koma = int.Parse(Console.ReadLine());
        int a = verts.Count;
        verts.Remove(koma);
        vertscheked.Add(koma);
        dict.Add(vertscheked[0], 1);
        while (dict.Keys.Count != a)
        {
            for(int i  = 0; i < graph.Count; i++)
            {
                if (vertscheked.Contains(graph[i].v1) && (!vertscheked.Contains(graph[i].v2)))
                {
                    dict.Add(graph[i].v2, dict[graphs[i].v1] + 1);
                    vertscheked.Add(graph[i].v2);
                }
            }
            int j = -1;
            foreach(int key in dict.Keys)
            {
                if(key > j) { j = key;}
            }
            Console.WriteLine($"Ширина графа - {dict[j]}");
        }

    }
}