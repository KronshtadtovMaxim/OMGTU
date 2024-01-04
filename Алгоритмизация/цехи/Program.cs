class Ceh
{
    private int nomer;
    public int Nomer
    { get { return nomer; } }
    private int[] year;
    public int[] Year
    { get { return year; } }
    private double[] volume;
    public double [] Volume
    { get { return volume; } }
    public Ceh(int nomer, int[] year, double[] volume)
    {
        this.nomer = nomer;
        this.year = year;
        this.volume = volume;
    }
}
class Programm
{
    public static void Main()
    {
        Ceh[] cehi = new Ceh[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Номер цеха ");
            int nomer = int.Parse(Console.ReadLine());
            int[] year = new int[3];
            double[] volume = new double[3];
            Console.WriteLine($"{i+1} цех ");
            for (int j = 0; j<3; j++)
            {
                Console.Write("Год ");
                Console.Write("Объём производства (через пробел)");
                Console.WriteLine();
                string[] y = Console.ReadLine().Split(" ");
                year[j] = int.Parse(y[0]);
                volume[j]= double.Parse(y[1]);
            }
            cehi[i] = new Ceh(nomer, year, volume);
        }
        int a = 0;
        while(a!=1)
        {
            Years(cehi);
            Console.WriteLine("0 - продолжить, 1 - остановить");
            a = int.Parse(Console.ReadLine());
        }
        double[] sum = new double[3];
        for (int i =0; i<3; i++)
        {
            for(int j =0; j<3; j++)
            {
                sum[i] += cehi[i].Volume[j];
            }
        }
        Console.WriteLine("Суммарный объём");
        for(int i =0; i<3; i++)
        {
            Console.WriteLine($" цех{i+1} " + sum[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                double intensiv = Math.Round((cehi[i].Volume[j] / 365),4);
                Console.WriteLine($" Интенсивность проивзодства {i+1} цеха в {cehi[i].Year[j]}  году  - {intensiv} шт в день");
            }
        }
     
    }
    static void Years(Ceh[]cehi)
    {
        Console.Write("Введите год ");
        int year_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Цехи и их объёмы производства в заданный год");
        double[] sum = new double[3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (cehi[i].Year[j] == year_2)
                {
                    Console.WriteLine($" Цех {cehi[i].Nomer} ({cehi[i].Volume[j]} шт) ");
                }
                sum[i] += cehi[i].Volume[j];
            }
        }
    }
}
