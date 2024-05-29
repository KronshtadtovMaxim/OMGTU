public delegate void Wash(Car car);
public class Car
{
    public string name;
    public string number;
    public Car(string name, string number)
    {
        this.name = name;
        this.number = number;
    }

}
class Moyka
{
    public void clean_car(Wash wash, Car car)
    {
        wash(car);
    }
}
public class Garage
{
    public List<Car> cars = new();
    public void Add(Car car) { cars.Add(car); }
    public void washall(Wash wash)
    {
        foreach(Car car in cars) 
        {
            wash(car);
        }
    }
         
}
class Program
{
    static void Main()
    {
        Garage cars = new();
        while (true)
        {
            Console.Write("Введите название и номер машины через пробел: ");
            string[] a = Console.ReadLine().Split(" ");
            if (a[0] == "end") { break; }
            cars.Add((new Car(a[0], a[1])));
        }
        cars.washall(car => Console.WriteLine($"{car.name} {car.number} была вымыта"));
    }
}





