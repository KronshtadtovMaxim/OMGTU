using System.Security.Cryptography.X509Certificates;

class Car
{
    public string name;
    public string number;
    public Car(string name, string number) { this.name = name; this.number = number; }
}
class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        while (true) { Console.Write("Введите название и номер машины: "); string[] a = Console.ReadLine().Split(" "); if (a[0] == "end"){break;}cars.Add(new Car(a[0], a[1])); }
        foreach(Car car in cars) { Console.WriteLine($"{car.name} {car.number} была вымыта"); }
    }
}