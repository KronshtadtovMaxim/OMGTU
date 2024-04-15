string stroka = "";
List<string> Main = new List<string>();
while (true)
{
    List<string> nums = new List<string>();
    bool flag = false;
    string n = Console.ReadLine();
    for (int i = 0; i < n.Count(); i++)
    {
        if (Char.IsNumber(n[i]))
        {
            flag = true;
            string t = "";
            t += n[i];
            nums.Add(t);
        }
    }
    string[] vss = n.Split(' ');
    if (n == "end") { break; }
    switch (vss[0])
    {
        case "WATER":
            n = n.Replace("WATER", "");
            if(flag == true)
            {
                foreach (string num in nums)
                {
                    n = n.Replace(num, Main[Convert.ToInt32(num) - 1]);
                }
                stroka = "WT" + n + "TW";
            }
            else { stroka = "WT" + n + "TW"; }
            Main.Add(stroka);
            break;
        case "DUST":
            n = n.Replace("DUST", "");
            if (flag == true)
            {
                foreach (string num in nums)
                {
                    n = n.Replace(num, Main[Convert.ToInt32(num) - 1]);
                }
                stroka = "DT" + n + "TD";
            }
            else { stroka = "DT" + n + "TD"; }
            Main.Add(stroka);
            break;
        case "FIRE":
            n = n.Replace("FIRE", "");
            if (flag == true)
            {
                foreach (string num in nums)
                {
                    n = n.Replace(num, Main[Convert.ToInt32(num) - 1]);
                }
                stroka = "FR" + n + "RF";
            }
            else { stroka = "FR" + n + "RF  "; }
            Main.Add(stroka);
            break;
        case "MIX":
            n = n.Replace("MIX", "");
            if (flag == true)
            {
                foreach(string num in nums)
                {
                    n = n.Replace(num, Main[Convert.ToInt32(num) - 1]);
                }
                stroka = "MX" + n + "XM";
            }
            else { stroka = "MX" + n + "XM"; }
            Main.Add(stroka);
            break;
    }
}
stroka = stroka.Replace(" ", null);
Console.WriteLine(stroka);