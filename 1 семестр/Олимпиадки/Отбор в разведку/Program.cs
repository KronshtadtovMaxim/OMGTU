float n = int.Parse(Console.ReadLine());
float k = 0;
if (n == 3)
    k = 1;
if(n>3)
{
    float i;
    for (i = 1; i <= n / 2; i *= 2) { }
    if (n <= i + i / 2)
        k = n - i;
    else
        k = 2 * i - n;
    Console.WriteLine(i);
}
