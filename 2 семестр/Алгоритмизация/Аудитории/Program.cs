class Auditoriya
{
    private int nomer;
    public int Nomer
    { get { return nomer; } set { nomer = value; } }
    private int places;
    public int Places
    { get { return places; } set { places = value; } }
    private bool proektor;
    public bool Proektor
    { get { return proektor; } set { proektor = value; } }
    private int pc;
    public int Pc
    { get { return pc; } set { pc = value; } }
    public Auditoriya(int nomer, int places, bool proektor, int pc)
    {
        this.nomer = nomer;
        this.places = places;
        this.proektor = proektor;
        this.pc = pc;
    }
    public void Print()
    {
        Console.WriteLine($"Номер аудитории: {Nomer}; Количество мест: {places}; Имеется ли проектор : {proektor}; Количество компьютеров: {pc}");
    }
}
    class Menu
{
        public static void Main()
    {
        List<Auditoriya> Aud = new List<Auditoriya>();
        bool flag = true;
        while (flag == true)
        {
            Console.Clear();
            Console.WriteLine("Выберите 1 из предложенных вариантов: ");  
            Console.WriteLine("1) Добавить аудиторию в базу");
            Console.WriteLine("2) Изменить данные об аудитории");
            Console.WriteLine("3) Выборка аудиторий с количеством посадочных мест больше или равным заданного");
            Console.WriteLine("4) Выборка аудиторий с проектором");
            Console.WriteLine("5) Выборка аудиторий с пк и заданным кол-вом посадочных мест");
            Console.WriteLine("6) Выборка аудиторий по номеру этажа");
            Console.WriteLine("7) Вывод всех данных по аудиториям");
            Console.WriteLine("8) Выход");
            Console.Write("Введите цифру: ");
            int ytr = Int32.Parse(Console.ReadLine());
            switch (ytr)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Введите номер аудитории: ");
                    int nomer = Int32.Parse(Console.ReadLine());
                    Console.Write("Введите количество мест в аудитории: ");
                    int places = Int32.Parse(Console.ReadLine());
                    Console.Write("Имеется ли в аудитории проектор (true - да, false - нет): ");
                    bool proektor = bool.Parse(Console.ReadLine());
                    Console.Write("Введите количество компьютеров в аудитории: ");
                    int pc = Int32.Parse(Console.ReadLine());
                    Auditoriya n1 = new Auditoriya(nomer, places, proektor, pc);
                    Aud.Add(n1);
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Введите номер аудитории: ");
                    int num = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < Aud.Count; i++)
                    {
                        if (Aud[i].Nomer == num)
                        {
                            Console.Write("Что вы хотите изменить?(0 - количество мест, 1 - проектор, 2 - количество компьютеров)");
                            int ghj = Int32.Parse(Console.ReadLine());
                            switch (ghj)
                            {
                                case 0:
                                    Console.Write($"Введите изменное количество мест (текущее {Aud[i].Places}): ");
                                    Aud[i].Places = int.Parse(Console.ReadLine());

                                    break;
                                case 1:
                                    if (Aud[i].Proektor == true)
                                    {
                                        Aud[i].Proektor = false;
                                    }
                                    else { Aud[i].Proektor = true; }
                                    break;
                                case 2:
                                    Console.Write($"Введите изменное количество мест (текущее: {Aud[i].Pc}): ");
                                    Aud[i].Places = int.Parse(Console.ReadLine());
                                    break;

                            }
                        }
                    }

                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Введите минимальное значение: ");
                    int vbm = Int32.Parse(Console.ReadLine());
                    Console.Write($"Номер(а) аудитории(й), в которой(ых) мест больше чем {vbm}: ");
                    for (int i = 0; i < Aud.Count; i++)
                    {
                        if (Aud[i].Places >= vbm)
                        {
                            Console.Write($"{Aud[i].Nomer}, ");
                        }
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Аудитории, в которых есть проектор: ");
                    for (int i = 0; i < Aud.Count; i++)
                    {
                        if (Aud[i].Proektor == true)
                        {
                            Console.Write($"{Aud[i].Nomer}, ");
                        }
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Введите количество посадочных мест: ");
                    int dyrachyo = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < Aud.Count; i++)
                    {
                        if (Aud[i].Proektor == true && Aud[i].Places == dyrachyo)
                        {
                            Console.Write($"{Aud[i].Nomer}, ");
                        }
                    }

                    break;
                case 6:
                    Console.Clear();
                    Console.Write("Введите номер этажа: ");
                    int quinn = Int32.Parse(Console.ReadLine());
                    Console.Write($"Аудитории, которые находятся на {quinn} этаже: ");
                    for (int i = 0; i < Aud.Count; i++)
                    {
                        if (Aud[i].Nomer - quinn * 100 > 0 && Aud[i].Nomer - quinn * 100 < 100)
                        {
                            Console.Write($"{Aud[i].Nomer}, ");
                        }
                    }
                    break;
                case 7:
                    Console.Clear();
                    for (int i = 0; i < Aud.Count; i++)
                    {
                     Console.WriteLine($"Номер аудитории: {Aud[i].Nomer}, количество мест: {Aud[i].Places}, есть ли проектор: {Aud[i].Proektor}, сколько компьютеров: {Aud[i].Pc}");
                    }
                    Console.Write("Нажмите enter чтобы продолжить");
                    Console.ReadLine();
                    break;
                case 8:
                    flag = false;
                    break;
            }
        }








        
        
        }
    }



