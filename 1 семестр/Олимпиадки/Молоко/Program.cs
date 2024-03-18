int n = int.Parse(Console.ReadLine());// колиичество фирм 
float V1, V2,S1,S2;
float sell1 = 0;
float sell2=0;
float sell3 = 0;
double min = 1000000;
int num= 0;
float k = 0;
for (int i=0;  i<n; i++)
{
    string line = Console.ReadLine();
    string[] str = line.Split(' ');
    float x1 = float.Parse(str[0]);
    float y1 = float.Parse(str[1]);
    float z1 = float.Parse(str[2]);
    float x2 = float.Parse(str[3]);
    float y2 = float.Parse(str[4]);
    float z2 = float.Parse(str[5]);
    float  c1 = float.Parse(str[6]);
    float c2 = float.Parse(str[7]);
    V1 = (float)(x1*y1*z1);
    V2 = (float)(x2*y2*z2);
    S1 = (float)(((2*x1*y1) + (2*x1*z1) + (2*y1*z1)));
    S2 = (float)(((2 * x2 * y2) + (2 * x2 * z2) + (2 * y2 * z2)));
    k = S1 / S2;
    sell2 = V1 - (k * V2);
    sell1 = Math.Abs((1000 *( c1 - k*c2))/sell2);
    if (sell1<min)
    {
        min = sell1;
        num = i+1;
    }
}
min = Math.Round(min, 2);
Console.Write(num+" " + min);

