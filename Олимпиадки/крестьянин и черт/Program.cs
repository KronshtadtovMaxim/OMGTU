using System;
class HelloWorld
{
    static void Main()
    {
        float counter = 0;
        Console.WriteLine("Введите макс кол-во монет");
        float MaxN = int.Parse(Console.ReadLine());
        for (float i = 1; i <= MaxN; i++) // i - начальные деньги
        {
            float n = i;
            for (float k = 1; k <= i * 2; k++)
            {
                if (k >= i)
                {
                    
                    n = i;
                    while (n > 0)
                    {
                        float t = n;
                        n = n * 2 - k;
                        if (n >= t) 
                        {
                            break;
                        }
                    }
                    if (n == 0)
                    {
                        counter += 1;
                    }
                }
            }
        }
        Console.WriteLine(counter);
        Console.ReadKey();
    }
}