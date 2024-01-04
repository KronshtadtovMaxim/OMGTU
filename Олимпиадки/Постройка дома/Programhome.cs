using System;
class HelloWorld
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine()); // длина 
        int y = int.Parse(Console.ReadLine());// ширина 
        int l = int.Parse(Console.ReadLine());// длина уц.стены
        int c1 = int.Parse(Console.ReadLine());//цена  ремонта метра уц.стены 
        int c2 = int.Parse(Console.ReadLine());// цена разбора метра уц. стены 
        int c3 = int.Parse(Console.ReadLine());// цена строительства метра из материала отрем. стены
        int c4 = int.Parse(Console.ReadLine());//цена постройки метра из нового материала
        int c5 = int.Parse(Console.ReadLine());//цена метра из нового материала
        int c6 = int.Parse(Console.ReadLine());//цена вывоза на свалку метра при разборе уц. стены
        if (l >= 2 * (x + y))
        {
            if (x >= y)
            {
                int s1 = c1 * x + (c2 + c3) * (2 * (x + y) - x) + (c2 + c6) * (l - (2 * (x + y))); // если используется вся стена
                int s2 = l * (c2 + c6) + 2 * (x + y) * (c4 + c5);// если стену не испльзуем 
                int s3 = c1 * x + (c2 + c6) * (l - x) + (c4 + c5) * (2 * (x + y) - x); // если используем часть большей стены
                if (s1 < s2 && s1 < s3)
                    Console.WriteLine(s1);
                if (s2 < s3 && s2 < s1)
                    Console.WriteLine(s2);
                if (s3<s1&&s3<s2)
                    Console.WriteLine(s3);
            }
            else
            {
                int s4 = c1 * y + (c2 + c3) * (2 * (x + y) - y) + (c2 + c6) * (l - (2 * (x + y))); // если используется вся стена относительно y
                int s5 = l * (c2 + c6) + 2 * (x + y) * (c4 + c5);// если стену не испльзуем
                int s6 = c1 * y + (c2 + c6) * (l - y) + (c4 + c5) * (2 * (x + y) - y); // если используем часть большей стены
                int s20 = c1 * x + (c2 + c3) * (2 * (x + y) - x) + (c2 + c6) * (l - (2 * (x + y)));// если используется вся стена относительно x
                int s21 = ((c2 + c3) * 2 * (x + y)) + ((c2 + c6) * (l - (2 * (x + y)))); //если используется вся разобранная стена 
                if (s4 < s5 && s4 < s6&&s4<s20&&s4<s21)
                Console.WriteLine(s4);
                if (s5 < s4 && s5 < s6&&s5<s20&&s5<s21)
                    Console.WriteLine(s5);
                if (s6<s5&&s6<s4&&s6<s20&&s6<s21)
                    Console.WriteLine(s6);
                if(s20<s4&&s20<s5&&s20<s6&&s20<s21)
                    Console.WriteLine(s20);
                if (s21<s4&&s21<s5&&s21<s6&&s21<s20)
                Console.WriteLine(s21);
            }
        }
        else
        {
            if (l >= y && l >= x)
            {
                if (x >= y)
                {
                    int s7 = c1 * x + (c2 + c3) * (l - x) + (c4 + c5) * (2 * (x + y) - l); // если используется вся стена
                    int s8 = (c4 + c5) * (2 * (x + y)) + (c2 + c6) * l; // если стена не используется 
                    int s9 = c1 * x + (c2 + c6) * (l - x) + (c4 + c5) * (2 * (x + y) - x); // если стена используется только для X
                    int s10 = c1 * x + (c2 + c3) * y + (c4 + c5) * (x + y) + (c2 + c6) * (l - (x + y)); // если стена используется и для x и для Y
                    if (s7 < s8 && s7 < s9 && s7 < s10)
                        Console.WriteLine(s7);
                    if (s8 < s7 && s8 < s9 && s8 < s10)
                        Console.WriteLine(s8);
                    if (s9 < s7 && s9 < s8 && s9 < s10)
                        Console.WriteLine(s9);
                    if(s10<s7&&s10<s8&&s10<s9&&s10<s9)
                        Console.WriteLine(s10);
                }
                else
                {
                    int s11 = c1 * y + (c2 + c3) * (l - y) + (c4 + c5) * (2 * (x + y) - l); // если используется вся стена включая y
                    int s12 = (c4 + c5) * (2 * (x + y)) + (c2 + c6) * l; // если стена не используется 
                    int s13 = c1 * y + (c2 + c6) * (l - y) + (c4 + c5) * (2 * (x + y) - y); // если стена используется только для y
                    int s14 = c1 * x + (c2 + c6) * (l - x) + (c4 + c5) * (2 * (x + y) - x);// если стена используется только для x
                    int s15 = c1 * x + (c2 + c3) * (l - x) + (c4 + c5) * (2 * (x + y) - l); // если используется вся стена включая x
                    int s19 = (c2 + c3) * l + (c4 + c5)*(2 * (x + y) - l);// используется вся разобранная стена 

                     if (s11 < s12 && s11 < s13&& s11<s14&& s11<s15&&s11<s19)
                    Console.WriteLine(s11);
                     if (s12 < s11 && s12 < s13&& s12<s14&&s12<s15&&s12<s19)
                    Console.WriteLine(s12);
                     if (s13 < s11 && s13 < s12&& s13<s14&&s13<s15&&s13<s19)
                    Console.WriteLine(s13);
                     if (s14<s11&&s14<s12&&s14<s13&&s14<s15&&s14<s19)
                    Console.WriteLine(s14);
                     if (s15<s11&&s15<s12&&s15<s13&&s15<s14&&s15<s19)
                        Console.WriteLine(s15);
                     if(s19<s11&&s19<s12&&s19<s13&&s19<s14&&s19<s15)
                    Console.WriteLine(s19);
                }
            }
            else
            {

                int s16 = (c4 + c5) * (2 * (x + y)) + (c2 + c6) * l; // если стена не используется 
                int s17 = c1 * l + (c4 + c5) * (2 * (x + y) - l); // используется вся стена 
                int s18 = (c3 + c2) * l + (c4 + c5) * (2 * (x + y) - l);  // используется вся разобраннач стена 

               if (s16<s17&&s16<s18)
                Console.WriteLine(s16);
               if (s17<s16&&s17<s18)
                Console.WriteLine(s17);
               if (s18<s16&&s18<s17)
                Console.WriteLine(s18);


            }
        }
    }
}