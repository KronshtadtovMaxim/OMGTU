/*Работа с двумерным массивом.
1) Определить количество строк, в котором минимальный и максимальный элемент четные.
2) Выдать номера столбцов в которых все элементы положительные.
3) Посчитать кол-во нулевых элементов во всем массиве.
4) Определить, имеется ли в массиве строка с 0 суммой.
5) Определить кол-во пар строк, состоящих из одинаковых элементов.*/


            int max = 0;
            int min = 0;
            int count = 0;
            int k = 0;
            int count1 = 0;
            int sum = 0;
            int count2 = 0;
            int l = 0;
            int t = 0;
            int count3 = 0;
            int count4 = 0;
            int count6 = 0;
            Console.WriteLine("Введите количество строк массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов  массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[m, n];
            int[] st = new int[n];
            Console.WriteLine("Введите элементы ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                    max = min = mas[i, 0];
                    t = mas[0, j];
                    k = mas[i, j];
                    if (k == 0)
                        count1++;
                    if (mas[i, j] >= max)
                        max = mas[i, j];
                    if (mas[i, j] < min)
                        min = mas[i, j];
                }
                if (max % 2 == 0 && min % 2 == 0)
                    count++;
                Console.WriteLine();
            }
            Console.WriteLine("Введённый двумерный массив: ");
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    l = mas[i, j];
                    sum = sum + l;
                    Console.Write(mas[i, j] + "\t");
                }
                if (sum == 0)
                    count2++;
                if (sum == mas[i, 0] * n && mas[i, 0] != 0)
                    count3++;
                sum = 0;
                Console.WriteLine();
            }
            for (int j = 0; j < n; j++)
            {

                for (int i = 0; i < m; i++)
                {
                    t = mas[0, j];
                    l = mas[i, j];
                    if (l > 0 && t > 0)
                    {
                        count6++;
                        l = mas[i, j];
                        t = mas[0, j];
                    }
                }
                if (count6 == m)
                {
                    st[j] = j + 1;

                }
                count6 = 0;
            }
            Console.WriteLine("1) Кол-во строк, в которых макс и мин элементы четные: " + count);
            Console.WriteLine("2) Номера столбцов, в которых все элементы положительные");
            for (int h = 0; h < st.Length; h++)
            {
                if (st[h] == 0)
                    continue;
                Console.Write(st[h] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("3) Количество нулевых элементов в массиве: " + count1);
            Console.WriteLine("4) Есть ли в массиве строка, сумма которой равна 0?");
            if (count2 != 0)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");
            Console.WriteLine("5) Кол-во пар строк, состоящих из одинаковых элементов.");
            if (count3 == 0)
                Console.WriteLine("Таких строк нет");
            if (count3 % 2 == 0 && count3 != 0)
            {
                count4 = count3 / 2;
                Console.WriteLine(count4);
            }
            if (count3 % 2 != 0)
            {
                int count5 = count3 / 2;
                count3 = count3 - count5 * 2;
                Console.WriteLine("Кол-во пар: " + count5);
                Console.WriteLine("Кол-во строк: " + count3);
            }

