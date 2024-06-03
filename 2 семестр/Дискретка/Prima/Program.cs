class Graph
{
    public int v1;
    public int v2;
    public int weight;
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
            Console.Write("Введите первую вершину (end = break): ");
            string ss = Console.ReadLine();
            if (ss == "end") { break; }
            int f = Convert.ToInt32(ss);
            Console.Write("Введите вторую вершину: ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("Введите вес графа: ");
            int h = int.Parse(Console.ReadLine());
            graphs.Add(new Graph(f, g, h));
            if (!verts.Contains(f)) {  verts.Add(f); }
            if(!verts.Contains(g)) { verts.Add(g); }
        }
        List<int> verts2 = new List<int>();
        List<Graph> graphss = new List<Graph>();
        int a = verts.Count;
        verts2.Add(graphs[0].v1);
        verts.Remove(graphs[0].v1);
        while(verts2.Count != a)
        {
            int abh = 0;
            int j = -1;
            int minr = -1;
            for (int i = 0; i < graphs.Count; i++)
            {
                if (!verts2.Contains(graphs[i].v1) && verts2.Contains(graphs[i].v2))
                {
                    if(minr == -1)
                    {
                        minr = graphs[i].weight;
                        j = i;
                        abh =1;
                    }
                    else 
                    {
                        if(minr > graphs[i].weight)
                        {
                            minr = graphs[i].weight;
                            j = i;
                            abh = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < graphs.Count; i++)
            {
                if (verts2.Contains(graphs[i].v1) && !verts2.Contains(graphs[i].v2))
                {
                    if (minr == -1)
                    {
                        minr = graphs[i].weight;
                        j = i;
                        abh = 2;
                    }
                    else
                    {
                        if (minr > graphs[i].weight)
                        {
                            minr = graphs[i].weight;
                            j = i;
                            abh = 2;
                        }
                    }
                }
            }
            if (j != -1)
            {
                if(abh == 2){
                verts2.Add(graphs[j].v2);
                verts.Remove(graphs[j].v2);
                graphss.Add(graphs[j]);
                graphs.Remove(graphs[j]);
                }
                if(abh == 1){
                verts2.Add(graphs[j].v1);
                verts.Remove(graphs[j].v1);
                graphss.Add(graphs[j]);
                graphs.Remove(graphs[j]);
                }
            }
        }
        int min = 0;
        foreach(Graph graph in  graphss) { min += graph.weight; }
        Console.WriteLine($"Минимальный остов: {min}");
    }
}
