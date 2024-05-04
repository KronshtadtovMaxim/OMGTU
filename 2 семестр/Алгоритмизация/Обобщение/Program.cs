using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class nums<T>
{
    public T a; public T b;
    public nums(T a, T b) { this.a = a; this.b = b; }

    public T plus()
    {
        dynamic A = a;
        dynamic B = b;
        return (A + B);
    }
    public T minus()
    {
        dynamic A = a;
        dynamic B = b;
        return (A - B);
    }
    public T division()
    {
        dynamic A = a;
        dynamic B = b;
        return (A / B);
    }
    public T multiply()
    {
        dynamic A = a;
        dynamic B = b;
        return (A * B);
    }
}
class Programm
{
    static void Main()
    {
        bool flag = true;
        while (flag == true)
        {
            Console.WriteLine($"Выберите тип данных: \n 1) Целые\n 2) Вещественные\n 3) break");
            switch (int.Parse(Console.ReadLine()))
            { 
            case 1:
                {
                        Console.Clear();
                        Console.Write("Введите первое число: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        int b = int.Parse(Console.ReadLine());
                        nums<int> numss;
                        numss = new nums<int>(a, b);
                        Console.WriteLine("Выберите операцию:\n 1) Сложение\n 2) Вычитание\n 3) Деление\n 4) Умножение\n 5) break");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                int aa = numss.plus();
                                Console.WriteLine($"Результат: {aa}");
                                break;
                            case 2:
                                int bb = numss.minus();
                                Console.WriteLine($"Результат: {bb}");
                                break;
                            case 3:
                                if(b == 0) { Console.WriteLine("Ошибка! Деление на ноль невозможно"); break; }
                                if(a%b != 0)
                                {
                                    int g = a % b;
                                    int y = a - g;
                                    Console.WriteLine($"Результат: {y} + {g}/{b}");
                                    break;
                                }
                                int cc = numss.division();
                                Console.WriteLine($"Результат: {cc}");
                                break;
                            case 4:
                                int dd = numss.multiply();
                                Console.WriteLine($"Результат: {dd}");
                                break;
                            case 5:
                                break;
                            default: Console.WriteLine("Введено неверное значение"); break;
                        }
                        break;
                }
                case 2:
                    Console.Clear();
                    Console.Write("Введите первое число: ");
                    double a1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double b1 = double.Parse(Console.ReadLine());
                    nums<double> numsss;
                    numsss = new nums<double>(a1, b1);
                    Console.WriteLine("Выберите операцию:\n 1) Сложение\n 2) Вычитание\n 3) Деление\n 4) Умножение\n 5) break");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            double aa = numsss.plus();
                            Console.WriteLine($"Результат: {aa}");
                            break;
                        case 2:
                            double bb = numsss.minus();
                            Console.WriteLine($"Результат: {bb}");
                            break;
                        case 3:
                            if (b1 == 0) { Console.WriteLine("Ошибка! Деление на ноль невозможно"); break; }
                            double cc = numsss.division();
                            Console.WriteLine($"Результат: {cc}");
                            break;
                        case 4:
                            double dd = numsss.multiply();
                            Console.WriteLine($"Результат: {dd}");
                            break;
                        case 5:
                            break;
                        default: Console.WriteLine("Введено неверное значение"); break;
                    }
                    break;
                case 3:
                    flag = false;
                    Console.Clear();
                    break;
            }
        }
    }
}
 