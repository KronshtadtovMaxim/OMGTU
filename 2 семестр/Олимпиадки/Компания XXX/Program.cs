Dictionary<string, string> nomera = new Dictionary<string, string>();
List<string> nums = new List<string>();
List<int> nums1 = new List<int>();
while (true)
{
    string[] g = Console.ReadLine().Split(" ");
    if (g[0] == "END")
    {
        break;
    }
    if(g.Length == 1)
    {
        try { nomera.Add(g[0], "Unknown name"); }
        catch {  }

    }
    if(g.Length == 2)
    {
        try { nomera.Add(g[0], g[1]); }
        catch { nomera[g[0]] = g[1]; }
    }
    if(g.Length == 3)
    {
        try { nomera.Add(g[0], g[1]+ " " + g[2]); }
        catch { nomera[g[0]] = g[1] + " " + g[2]; }
    }
    nums.Add(g[0]);
}
string a = Console.ReadLine();
if (char.IsNumber(a[0]))
{
    for (int i = 0; i < nums.Count - 1; i += 2)
    {
        if (nums[i] == a || nums1.Contains(int.Parse(nums[i])))
        {
            nums1.Add(int.Parse(nums[i + 1]));
        }
    }
}
else
{
    for (int i = 0; i < nums.Count; i += 2)
    {
        if (nomera[nums[i]] == a)
        {
            nums1.Add(int.Parse(nums[i + 1]));
        }

    }
}
for (int i = 0; i < nums.Count; i += 2)
{
    if (nums1.Count >= 1)
    {
        for (int j = 0; j < nums1.Count; j++)
        {
            if (nums1[j] >= 0 && nums1[j] <= 9)
            {
                string b = "000" + Convert.ToString(nums1[j]);
                if (b == nums[i])
                {
                    nums1.Add(int.Parse(nums[i + 1]));
                }

            }
            else if (nums1[j] >= 10 && nums1[j] <= 99)
            {
                string b = "00" + Convert.ToString(nums1[j]);
                if (b == nums[i])
                {
                    nums1.Add(int.Parse(nums[i + 1]));
                }

            }
            else if (nums1[j] >= 100 && nums1[j] <= 999)
            {
                string b = "0" + Convert.ToString(nums1[j]);
                if (b == nums[i])
                {
                    nums1.Add(int.Parse(nums[i + 1]));
                }

            }
            else if (nums1[j] >= 1000)
            {
                string b = Convert.ToString(nums1[j]);
                if (b == nums[i])
                {
                    nums1.Add(int.Parse(nums[i + 1]));
                }

            }
        }
    }
}
nums1.Sort(); 
foreach(int num1 in nums1)
{
    if(num1 >= 0 && num1 <= 9)
    {
        string b = "000" + Convert.ToString(num1);
        Console.Write(b);
        Console.WriteLine(" " + nomera[b]);
    }
    else if(num1 >= 10 && num1 <= 99)
    {
        string b = "00" + Convert.ToString(num1);
        Console.Write(b);
        Console.WriteLine(" " + nomera[b]);
    }
    else if(num1>=100 && num1 <= 999)
    {
        string b = "0" + Convert.ToString(num1);
        Console.Write(b);
        Console.WriteLine(" " + nomera[b]);
    }
    else if (num1 >= 1000)
    {
        string b = Convert.ToString(num1);
        Console.Write(b);
        Console.WriteLine(" " + nomera[b]);
    }
}
