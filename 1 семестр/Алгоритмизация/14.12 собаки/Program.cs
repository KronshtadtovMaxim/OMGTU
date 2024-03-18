class Sobaka
{
    private string imya;

    public string im { get { return imya; } }
    private string poroda;
    public string por { get { return poroda; } }
    private string okrass;
    public string ok { get { return okrass; } set { okrass = value; } }
    private int year_rozjdeniya;
    public int year { get { return year_rozjdeniya; } }
    private string pol;
    public string p { get { return pol; } }

    public Sobaka(string imya, string poroda, string okrass, int year_rozjdeniya, string pol)
    {
        this.imya = imya;
        this.poroda = poroda;
        this.okrass = okrass;
        this.year_rozjdeniya = year_rozjdeniya;
        this.pol = pol;
    }
    public void Print()
    {
        Console.WriteLine();
        Console.WriteLine($"Кличка: {imya}\t\nПорода: {poroda}\t\nОкрас: {okrass}\t\nГод рождения: {year_rozjdeniya}" +
            $"\t\nПол: {pol}");
        Console.WriteLine();
    }
}
class Programm
{
    public static void Main()
    {
        Console.WriteLine("Введите количество собак: ");
        int n = int.Parse(Console.ReadLine());
        Sobaka[] dogs = new Sobaka[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Заполнение {i + 1} собаки");
            Console.Write("Кличка ");
            string imya = Console.ReadLine();
            Console.Write("Порода: ");
            string poroda = (Console.ReadLine());
            Console.Write("Окрас: ");
            string okrass = Console.ReadLine();
            Console.Write("Год рождения: ");
            int year_rozjdeniya = int.Parse(Console.ReadLine());
            Console.Write("Пол: ");
            string pol = Console.ReadLine();
            dogs[i] = new Sobaka(imya, poroda, okrass, year_rozjdeniya, pol);
        }
        F_1(dogs);
        Console.WriteLine();
        F_3(dogs);
        Console.WriteLine();
        F_4(dogs);

        for (int i = 0; i < n; i++)
        {
            dogs[i].Print();
        }
    }
    static void F_1(Sobaka[] array)
    {
        Console.Write("Год рождения для сравнения: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine($"Собаки, у которых {value}-ый год рождения: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (value == array[i].year)
            {
                Console.WriteLine($"{array[i].im} - {array[i].year}");
            }
        }
    }
    static bool F_2(int i, string porod, Sobaka[] array)
    {
        if (array[i].por.Contains(porod))
            return true;
        else
            return false;
    }
    static void F_3(Sobaka[] array)
    {
        Console.Write("Порода для сравнения: ");
        string p_o = Console.ReadLine();
        Console.WriteLine($"Собаки, имеющие породу {p_o}");
        for (int i = 0; i < array.Length; i++)
        {
            if (F_2(i, p_o, array) == true)
                Console.WriteLine($"{array[i].im}\t");
        }
    }
    static void F_4(Sobaka[] array)
    {
        Console.WriteLine("Введите количество собак, у которых хотите поменять окрас");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            Console.Write($"Введите имя {i + 1}-ой собаки: ");
            string name = Console.ReadLine();
            if (array[i].im.Contains(name))
            {
                Console.Write("Введите новый окрас: ");
                string h = Console.ReadLine();
                array[i].ok = h;
            }
            else
                continue;
        }
        Console.WriteLine();
    }

}