bool flag = false;
int ser = -1;
int c = 0;
Console.WriteLine("Кол-во серых мышек");
int s  = int.Parse(Console.ReadLine());
Console.WriteLine("Кол-во белых мышек");
int b =  int.Parse(Console.ReadLine());
Console.WriteLine("Интервал поедания");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Кол-во серых мышек на выходе");
int sv = int.Parse(Console.ReadLine());
Console.WriteLine("Кол-во белых мышек на выходе");
int bv = int.Parse(Console.ReadLine());
int[] mouse = new int[s + b];
int death_s = s - sv;
for (int i =0;i<s+b;i++ )
{
    mouse[i] = i;
}
for(int i = 0;i<(s+b)-(sv+bv); i++ )
{
    while (!(ser==k && mouse[c] !=-1))
    {
        if (mouse[c] != -1)
            ser += 1;
        if (ser != k || mouse[c] == -1)
            c = (c + 1) % (b + s);
    }
    mouse[c] = -1; ser = 0; 
}
for (int i = 0; i < s + b; i++)
{
    if (s < sv || b < bv)
    {
        flag = true;
        break;
    }
    if (mouse[i] == -1)
    {
        if (death_s != 0)
        {
            death_s--;
            Console.WriteLine($"Расположение серой съеденной мыши: {i + 1} ");
        }
        else
        {
            if (i == 0)
            {
                flag = true;
                break;
            }
            Console.WriteLine($"Раположение белой съеденной мыши: {i + 1}");
        }
    }
    else
    {
        if (sv != 0)
        {
            sv--;
            Console.WriteLine($"Расположение Серой ЖИВОЙ мыши: {i + 1}");
        }
        else
        {
            if (i == 0)
            {
                flag = true;
                break;
            }
            Console.WriteLine($"Расположение Белой ЖИВОЙ мыши: {i + 1}");
        }
    }
}
if (flag)
    Console.WriteLine("Расположение невозможно");

    
