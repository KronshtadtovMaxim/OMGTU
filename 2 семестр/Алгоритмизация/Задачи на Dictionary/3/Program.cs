using System.Collections;

Dictionary<string,int> nomera = new Dictionary<string, int>();
Hashtable nomerki = new Hashtable();
List<string> nums = new List<string>();
while (true)
{
    Console.Write("Введите номер: ");
    string nomer = Console.ReadLine();
    if (nomer == "end") { break; }
    Console.Write("Введите дату в формате xx.xx.xx: ");
    string data = Console.ReadLine();
    try { nomera.Add(data, 1); }
    catch (ArgumentException)
    {
        foreach (string data1 in nomera.Keys)
        {
            if (data1.Equals(data))
            {
                nomera[data] += 1;
            }
        }
    }
    if(nomerki.ContainsKey(nomer))
    {
        foreach (string data1 in nomerki.Keys)
        {
            if (data1.Equals(data))
            {
                nomera[data] += 1;
            }
        }
    }
}
Console.WriteLine("Отчет (номер - количество звонков): ");
foreach(string nomer in nomera.Keys)
{
    Console.WriteLine($"{nomer} - {nomera[nomer]}");
}
Console.WriteLine("Отчет (номер - количество звонков): ");
foreach(string key in nomerki.Keys)
{
    Console.WriteLine($"{key} - {nomerki[key]}") ;
}