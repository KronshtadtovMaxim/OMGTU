using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

Dictionary<string, int> nomera = new Dictionary<string, int>();
bool flag = true;
while (true)
{
    Console.Write("Введите дату (в формате xx.xx.xx): ");
    string data = Console.ReadLine();
    if (data == "end") {  break; }
    string[] g = new string[3];
    string[] g1 = data.Split(".");
    switch (g[1])
    {
        case "01":
            if (int.Parse(g[0]) >= 31)) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "02":
            if (((int.Parse(g[0]) >= 29)&&(int.Parse(g[2])%4 != 0) || ((int.Parse(g[0]) >= 30) && (int.Parse(g[2]) % 4 == 0)))) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "03":
            if (int.Parse(g[0])>=32) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "04":
            if (int.Parse(g[0]) >= 31) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "05":
            if (int.Parse(g[0]) >= 32) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "06":
            if (int.Parse(g[0]) >= 31) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "07":
            if (int.Parse(g[0]) >= 32) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "08":
            if (int.Parse(g[0]) >= 32) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "09":
            if (int.Parse(g[0]) >= 31) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "10":
            if (int.Parse(g[0]) >= 32) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "11":
            if (int.Parse(g[0]) >= 31) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        case "12":
            if (int.Parse(g[0]) >= 32) { Console.WriteLine("Введены неверные данные"); flag = false; }
            break;
        default:
            Console.WriteLine("Введены неверные данные");
            flag = false;
            break;
    }
    if(flag == false)
    {
        flag = true;
        continue;
    }
    Console.Write("Введите время разговора в секундах: ");
    int sec = int.Parse(Console.ReadLine());
    try { nomera.Add(data, sec); }
    catch 
    { 
        foreach(string key in nomera.Keys)
        {
            if(key == data)
            {
                nomera[key] += sec;
            }
        }
    }
}
Console.WriteLine("Дата - время");
foreach (string key in nomera.Keys)
{
    Console.WriteLine($"{key} - {nomera[key]}");
}

