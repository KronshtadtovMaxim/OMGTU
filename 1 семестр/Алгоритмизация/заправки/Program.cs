using System;
namespace Zapravki;
class Programm
{
    static void Main()
    {
        Console.WriteLine("Количество городов");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ограничение");
        int k = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] r = new int[n + 1];
        int point = 10000, s1 = 0, s2 = 0, s = 0, ss1 = 0, ss2 = 0, sum = 0, l = 0, len3 = 0, len4 = 0;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine($"Расстояние от {i + 1} города до {i + 2} города ");
            int b = int.Parse(Console.ReadLine());
            a[i + 1] += b + l;
            l = a[i + 1];
        }
        int sum2 = a[n - 2] / 2;
        int sum3 = sum2;
        int sum4 = sum3;
        for (int i = 0; i < a.Length; i++)
        {
            if (!(s1 < a[i] + k && s1 > a[i] - k) && s1 != 0)
                ss1 = s1;
            if (!(s2 < a[i] + k && s2 > a[i] - k) && s2 != 0)
                ss2 = s2;
            if (((sum2 - ss1) <= (sum2 - ss2)))
                s = ss1;
            if (((sum2 - ss1) > (sum2 - ss2)))
                s = ss2;
            if (s != 0 && Math.Abs(sum2- s) <Math.Abs(sum2 -point))
                point = s;
            if (a[i] + k <= sum2)
            {
                while (sum3 != a[i] + k)
                {
                    sum3 -= 1;
                }
            }
            else if (a[i] + k > sum2)
            {
                while (sum3 != a[i] + k)
                {
                    sum3 += 1;
                }
            }
            if (a[i] - k >= sum2)
            {
                while (sum4 != a[i] - k)
                {
                    sum4 += 1;
                }
            }
            else if (a[i] - k < sum2)
            {
                while (sum4 != a[i] - k)
                {
                    sum4 -= 1;
                }
            }
            if (!(sum3 > len4 && sum3 < len3))
                s1 = sum3;
            if (!(sum4 > len4 && sum4 < len3))
                s2 = sum4;
            sum3 = sum2; sum4 = sum2;
            len3 = a[i] + k;
            len4 = a[i] - k;
        }
        if (!(s1 < len3 + k && s1 > len4) && s1 != 0)
            ss1 = s1;
        if (!(s2 < len3 && s2 > len4) && s2 != 0)
            ss2 = s2;
        if (((sum2 - ss1) <= (sum2 - ss2)))
            s = ss1;
        if (((sum2 - ss1) > (sum2 - ss2)))
            s = ss2;
        if (s != 0 && Math.Abs(sum2 - s) < Math.Abs(sum2 - point))
            point = s;
        if (point == 10000)
            Console.WriteLine("Установка заправки невозможна");
        else
        {
            Console.WriteLine("Место заправки " + point);
            r[0] = point;
            sum += r[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] <= point)
                    r[i + 1] = point - a[i];
                else if (a[i] > point)
                    r[i + 1] = a[i] - point;
                sum += r[i + 1];
            }
            Console.WriteLine($"Сумма расстояний от каждого города из {n} до заправки: {sum} ");
        }
    }
}



