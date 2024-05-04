using System.Linq;
class Graph
{
    public int v1;
    public int v2;
    public int weight;
    public bool cheked;
    public Graph(int v1, int v2, int weight)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.weight = weight;
    }
}
class Programm
{
    static void Main()
    {
        List<Graph> graphs = new List<Graph>();
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
            Console.Write("Введите вес графа: ");
            int h = int.Parse(Console.ReadLine());
            graphs.Add(new Graph(f, g, h));
            if (!verts.Contains(f)) { verts.Add(f); }
            if (!verts.Contains(g)) { verts.Add(g); }
        }
        List<int> vertscheked = new List<int>();
        Console.Write("Введите номер вершины с которой хотите начать: ");
        int koma = int.Parse(Console.ReadLine());
        int a = verts.Count;
        List<Graph> graphss = new List<Graph>();
        verts.Remove(koma);
        vertscheked.Add(koma);
        dict.Add(vertscheked[0], 0);
        int problem = 0;
        while (verts.Count != 0)
        {
            problem++;
            if(problem == 100) { break; }
            int minr = 10000000;
            int j = -1;
            int b = -1;
            for (int i = 0; i < graphs.Count; i++)
            {
                if (vertscheked.Contains(graphs[i].v1) && !vertscheked.Contains(graphs[i].v2) || (vertscheked.Contains(graphs[i].v2) && !vertscheked.Contains(graphs[i].v1)))
                {
                    if (vertscheked.Contains(graphs[i].v1))
                    {
                        b = 1;
                        if (graphs[i].weight + dict[graphs[i].v1] < minr)
                        {
                            minr = graphs[i].weight + dict[graphs[i].v1];
                            j = i;
                        }
                    }
                    if (vertscheked.Contains(graphs[i].v2))
                    {
                        b = 2;
                        if (graphs[i].weight + dict[graphs[i].v2] < minr)
                        {
                            minr = graphs[i].weight + dict[graphs[i].v2];
                            j = i;
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
                    graphss.Add(graphs[j]);
                    dict.Add(graphs[j].v2, graphs[j].weight + dict[graphs[j].v1]); 
                    graphs.Remove(graphs[j]);
                }
                if (b == 2)
                {
                    verts.Remove(graphs[j].v1);
                    vertscheked.Add(graphs[j].v1);
                    graphss.Add(graphs[j]);
                    try { dict.Add(graphs[j].v1, graphs[j].weight + dict[graphs[j].v2]); }
                    catch (KeyNotFoundException){ ; }
                    graphs.Remove(graphs[j]);
                }
            }
        }
        Console.WriteLine($"Расстояние от вершины {koma} до остальных: ");
        foreach (int vert  in dict.Keys)
        {
            Console.WriteLine($"{vert} - {dict[vert]}");
        }
    }
}
        
        
        
   

