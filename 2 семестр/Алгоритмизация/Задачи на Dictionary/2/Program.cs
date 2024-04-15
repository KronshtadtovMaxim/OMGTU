Dictionary<string, int> nomera = new Dictionary<string, int>();
while (true)
{
    Console.Write("Введите номер телефона: ");
    string nomer = Console.ReadLine();
    if(nomer == null) { Console.WriteLine("Некорректно задан номер телефона"); continue; }
    if(nomer == "end") {  break; }
    Console.Write("Введите минуты разговора: ");
    string g = Console.ReadLine();
    try { int time1 = int.Parse(g); }
    catch(FormatException) { Console.WriteLine("Неверный тип данных"); continue; }
    int time = int.Parse(g);
    try { nomera.Add(nomer, time); }
    catch
    {
        foreach(string key in nomera.Keys)
        {
            if(key == nomer)
            {
                nomera[key] += time;
            }
        }
    }
}
Console.Clear();
Console.WriteLine("Месячный отчёт (Номер телефона - количество минут):");
foreach(string key in nomera.Keys)
{
    Console.WriteLine($"{key} - {nomera[key]}");
}
