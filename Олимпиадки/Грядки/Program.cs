Console.WriteLine("Введите количество грядок:");
int n = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int s = 0;
for (int i = 0; i < n; i++) //через цикл
{
    s += x * (2 + 2*i) + 2 * y + 2 * l;
        }
Console.WriteLine(s);
int S = 2 * n * (l + x + y) + x * n * (n - 1); //через формулу
Console.WriteLine(S);