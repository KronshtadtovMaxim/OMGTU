using System;
using System.Security.Cryptography.X509Certificates;

class Kniga
{
    private string fio;
    public string Fio
    { get { return fio; } }
    private string name;
    public string Name
    { get { return name; } }
    private int year;
    public int Year
    { get { return year; } }
    private int[] month;
    public int[] Month
    { get { return month; } }
    public Kniga(string fio, string name, int year, int[] month)
    {
        this.fio = fio;
        this.name = name;
        this.year = year;
        this.month = month;
    }
    public void Print()
    {
        Console.WriteLine();
        Console.WriteLine($"ФИО автора: {fio}\t\nНазвание книги: {name}\t\nГод издания: {year}\t\nМесяца выдачи: ");
        for (int i = 0; i < month.Length; i++)
        {
            Console.Write(month[i] + ", ");
        }
        Console.WriteLine();
    }
}
class Programm
{
    public static void Main()
    {
        Console.Write("Введите количество книг: ");
        int n = int.Parse(Console.ReadLine());
        Kniga[] arr = new Kniga[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите данные {i + 1} книги: ");
            Console.Write("ФИО автора: ");
            string fio = Console.ReadLine();
            Console.Write("Название книги: ");
            string name = Console.ReadLine();
            Console.Write("Год издания: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Количество месяцев: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Месяца выдачи: ");
            int[] month = new int[a];
            string mes = Console.ReadLine();
            string[] strings = mes.Split(" ");
            for (int j = 0; j < a; j++)
            {
                month[j] = int.Parse(strings[0]);
            }
            arr[i] = new Kniga(fio, name, year, month);
            Console.WriteLine();
        }
        Find_Year(arr);
        Find_Fio(arr);
        Find_book(arr);
    }
    static void Find_Year(Kniga[] array)
    {
        Console.Write("Введите год для сравнения: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write($"Книги, дата издания которых позже {y} года: ");
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Year > y)
            {
                count++;
                Console.Write(array[i].Name + "\t");
            }
        }
        if (count == 0)
            Console.WriteLine("Таких книг нет");
        Console.WriteLine();
    }
    static void Find_Fio(Kniga[] array)
    {
        Console.Write("Введите ФИО автора: ");
        string y2 = Console.ReadLine();
        Console.WriteLine($"Книги автора {y2}: ");
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Fio.Contains(y2))
            {
                count++;
                Console.Write(array[i].Name + "\t");
            }
        }
        if (count == 0)
        {
            Console.WriteLine("В данной библиотеке отсуствуют книги заданного автора");
        }
        Console.WriteLine();
    }
    static void Find_book(Kniga[] array)
    {
        Console.WriteLine();
        Console.Write("Введите название книги: ");
        string y3 = Console.ReadLine();
        bool flag = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Name == y3)
            {
                array[i].Print();
                flag = true;
            }
        }
        if (flag == false)
        { Console.WriteLine("В библиотеке отсуствует заданная книга "); }
        Console.WriteLine();
    }
}