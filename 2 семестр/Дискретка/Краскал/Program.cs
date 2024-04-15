public class Graf
{
    public string v1;
    public string v2;
    public int weight;
    public Graf(string v1, string v2, int weight)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.weight = weight;
    }
}
public class Programm
{
    static void Main()
    {
        List<Graf> grafs = new();
        List<Graf> grafss = new();
        List<int> weight = new();
        int min = 0;
        while (true)
        {
            Console.Write("Введите первую вершину: ");
            string a = Console.ReadLine();
            if (a == "end") { break; }
            Console.Write("Введите вторую вершину: ");
            string b = Console.ReadLine();
            Console.Write("Введите вес ребра: ");
            int c = int.Parse(Console.ReadLine());
            grafs.Add(new Graf(a, b, c));
            weight.Add(c);
        }
        weight.Sort();
        List<string> list = new();  
        List<string> list1 = new();
        for(int i = 0; i < weight.Count; i++)
        {
            for(int j = 0; i<weight.Count; j++) 
            {
                if (weight[i] == grafs[j].weight)
                {
                    grafss.Add(grafs[i]);
                    break;
                }
            }

        }
        List<string> verts = new();
        for(int i = 0; i<grafss.Count; i++)      
        {
            if (!verts.Contains(grafss[i].v1)) { verts.Add(grafss[i].v1); }
            if (!verts.Contains(grafss[i].v2)) { verts.Add((grafss[i].v2));}
        }
        int[] vv = new int[verts.Count];
        for(int i = 0; i < grafss.Count; i++)
        {
            if (!vv.Contains(0)) { break; }
            if (vv[int.Parse(grafss[i].v1)-1] == 0 && vv[int.Parse(grafss[i].v2)-1] == 0)
            {
                min += grafss[i].weight;
                vv[int.Parse(grafss[i].v1) - 1] = i + 1;
                vv[int.Parse(grafss[i].v2) - 1] = i + 1;
                continue;
            }
            if(vv[int.Parse(grafss[i].v1) - 1] == 0 && vv[int.Parse(grafss[i].v2) - 1] != 0)
            {
                min += grafss[i].weight;
                vv[int.Parse(grafss[i].v1) - 1] = vv[int.Parse(grafss[i].v2) - 1];
                continue;
            }
            if (vv[int.Parse(grafss[i].v2) - 1] == 0 && vv[int.Parse(grafss[i].v1) - 1] != 0)
            {
                min += grafss[i].weight;
                vv[int.Parse(grafss[i].v2) - 1] = vv[int.Parse(grafss[i].v1) - 1];
                continue;
            }
            if (vv[int.Parse(grafss[i].v1) - 1] != vv[int.Parse(grafss[i].v2) - 1])
            {
                if(vv[int.Parse(grafss[i].v1) - 1] > vv[int.Parse(grafss[i].v2) - 1])
                {
                    vv[int.Parse(grafss[i].v1) - 1] = vv[int.Parse(grafss[i].v2) - 1];
                    min += grafss[i].weight;
                }
                continue;
            }
            else
            {
                vv[int.Parse(grafss[i].v2) - 1] = vv[int.Parse(grafss[i].v1) - 1];
                min += grafss[i].weight;
                continue;
            }
        }
        Console.WriteLine("Кратчайший остов: {0}", min);
    }
}