using System;
using System.Collections.Immutable;
using System.Linq;
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
            Console.Write("Введите вес графа: ");
            int h = int.Parse(Console.ReadLine());
            graphs.Add(new Graph(f, g, h));
            graph.Add(new Graph(f, g, h));
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
        bool flag = false;
        while (true)
        {
            foreach (int key in dict.Keys)
            {
                if (key < -100)
                {
                    flag = true;
                    Console.WriteLine("В данном графе существует отрицательный цикл");
                    break;
                }
            }
            if (flag == true) { break; }
            problem++;
            if (problem == 200) { Console.Clear(); Console.WriteLine("В данном графе существует отрицательный цикл"); break; }
            int minr = 100000;
            int j = -1;
            for (int i = 0; i < graphs.Count; i++)
            {
                if (vertscheked.Contains(graphs[i].v1) && !vertscheked.Contains(graphs[i].v2))
                {
                    if (graphs[i].weight + dict[graphs[i].v1] < minr)
                    {
                        minr = graphs[i].weight + dict[graphs[i].v1];
                        j = i;
                    }
                }
            }
            if (j != -1)
            {
                verts.Remove(graphs[j].v2);
                vertscheked.Add(graphs[j].v2);
                graphss.Add(graphs[j]);
                try { dict.Add(graphs[j].v2, minr); }
                catch (System.ArgumentException)
                {
                    if (minr < dict[graphs[j].v2])
                    {
                        dict[graphs[j].v2] = minr;
                    }
                }
                graphs.Remove(graphs[j]);
            }
            bool fg = true;
            foreach (Graph g in graph)
            {
                if (g.weight < 0 && vertscheked.Contains(g.v1) && vertscheked.Contains(g.v2))
                {
                    if (dict[g.v1] + g.weight < dict[g.v2])
                    {
                        dict[g.v2] = dict[g.v1] + g.weight;
                        Console.WriteLine("В данном графе существует отрицательный цикл");
                        fg = false;
                    }
                }
            }
            for(int i = 0; i < graphss.Count; i++)
            {
                if (dict[graphss[i].v1] + graphss[i].weight < dict[graphss[i].v2])
                {
                    dict[graphss[i].v2] = dict[graphss[i].v1] + graphss[i].weight;
                }
            }

        }
        if (flag == false)
        {
            Console.Clear();
            Console.WriteLine($"Расстояние от вершины {koma} до остальных: ");
            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (int vert in dict.Keys)
            {
                Console.WriteLine($"{vert} - {dict[vert]}");
            }
        }
    }
}
        
        
        
   

