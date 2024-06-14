using System;
int n = int.Parse(Console.ReadLine());
List<string> slova = new List<string>();
for(int i = 0; i <n; i++) { slova.Add(Console.ReadLine()); }
int nachalo  = int.Parse(Console.ReadLine());
Dictionary<string, int> dict = new();
Dictionary<string, int> dict1 = new();
for(int i = 0; i<nachalo; i++)
{
    string[] a = Console.ReadLine().Split(" ");
    dict.Add(a[0], int.Parse(a[1])); //ограничение на начало
}
int konec = int.Parse(Console.ReadLine());
for(int i = 0;i<konec; i++)
{
    string[] b = Console.ReadLine().Split(" ");
    dict1.Add(b[0], int.Parse(b[1])); //ограничение на конец
}
int otvet = 0;
foreach(string slovo in slova)
{
    try
    {
        if (dict[Convert.ToString(slovo[0])] > 0 && dict1[Convert.ToString(slovo[slovo.Length - 1])] > 0)
        {
            otvet++;
            dict[Convert.ToString(slovo[0])] = dict[Convert.ToString(slovo[0])] - 1;
            dict1[Convert.ToString(slovo[slovo.Length - 1])] = dict1[Convert.ToString(slovo[slovo.Length - 1])] - 1;
        }
    }
    catch (KeyNotFoundException) { continue; }
}
Console.WriteLine($"Ответ - {otvet}");