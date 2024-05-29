class Client
{
    public int number;
    public string name;
    public double profit;
    public double spending;
    public double nalog => profit * 0.05;

    public Client(int number, string Name, double profit, double spending)
    {
        number = this.number;
        name = Name;
        profit = this.profit;
        spending = this.spending;
    }
}
class Program
{
    static void Main()
    {
        Client[] clients =
        {
            new Client(10, "Иванов Петр Сергеевич", 100000, 30000),
            new Client(20, "Иванов Иван Иванович", 70000, 60000),
            new Client(30, "Петров Петр Петрович", 50000, 10000),
            new Client(40, "Александров Прохор Михайлович", 300000, 50000),
            new Client(50, "Керн Александр Петрович", 10000, 20000)
        };

        var fd = clients.Where(d => d.profit - d.spending - d.nalog < 0);
        Console.WriteLine("Клиенты с отрицательным балансом: ");
        foreach(var n in fd) { Console.WriteLine(n.name); }
        var ds = clients.Count(d => d.profit - d.spending - d.nalog > 0);
        Console.WriteLine($"\nКоличество клиентов с положительным балансом: {ds}");
        var a = clients.Max(d => d.profit);
        var b = clients.Where(d => d.profit == a);
        Console.WriteLine($"Клиенты с максимальным доходом: ");
        foreach (var client in b) { Console.WriteLine(client.name); }
        var c = clients.Sum(d => d.nalog);
        Console.WriteLine($"\nОбщая сумма налогов клиентов: {c}");

    }
}