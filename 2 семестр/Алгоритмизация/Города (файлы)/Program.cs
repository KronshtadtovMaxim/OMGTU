using System.Security.Cryptography.X509Certificates;

class City
{
    public string name;
    public string country;
    public string population;
    public City(string name, string country, string population)
    {
        this.name = name;
        this.country = country;
        this.population = population;
    }

}


class Program
{
    static void Main()
    {
        StreamReader sr = File.OpenText("Список_городов.txt");
        List<City> cities = new List<City>();
        while (true)
        {
            string line = sr.ReadLine();
            if(line == null) break;
            string[] a = line.Split(" ");
            cities.Add(new City(a[0], a[1], a[2]));
        }
        Console.Write("Введите страну для выборки: ");
        string country = Console.ReadLine();
        var countries =
            from city in cities
            where city.country == country
            select city;
        List<City> countrs = countries.ToList();
        Console.Write("Введите букву для выборки: ");
        char tur = char.Parse(Console.ReadLine());
        var bookva =
            from city in cities
            where city.country[0] == tur
            select city;
        List<City> bookvi = bookva.ToList();
        Console.Write("Введите популяцию для выборки: ");
        int popul = int.Parse(Console.ReadLine());
        var popullll =
            from city in cities
            where int.Parse(city.population) >= popul
            select city;
        List<City> popular = popullll.ToList();
        StreamWriter city_bookva = File.CreateText("города_на_букву.txt");
        foreach(City city in bookvi) { city_bookva.Write(city.name + " "); }
        StreamWriter city_countries = File.CreateText("города_из_страны.txt");
        foreach(City city in countrs) {city_countries.Write(city.name + " "); };
        StreamWriter city_popul = File.CreateText("города_с_населением.txt");
        foreach(City city in popular) { city_popul.Write(city.name + " "); };
    }
}