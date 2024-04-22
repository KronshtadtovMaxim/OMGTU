Console.WriteLine("Введите элементы выражения в отдельных строках: ");
Stack<int> stck = new Stack<int>();
while(true)
{
    string s = Console.ReadLine();
    if (s == "end") { break; }
    int ss;
    if (int.TryParse(s, out ss))
    {
        stck.Push(ss);
    }
    else
    {
        switch (s)
        {
            case "+":
                {
                    if (stck.Count > 1)
                    {
                        stck.Push(stck.Pop() + stck.Pop());
                    }
                    else { Console.WriteLine("Ошибка! Нехватка элементов для выполнения действия"); break; }
                    break;
                }
            case "-":
                {
                    if (stck.Count > 1)  
                    {
                        int num = stck.Pop();
                        stck.Push(stck.Pop() - num);
                    }
                    else { Console.WriteLine("Ошибка! Нехватка элементов для выполнения действия"); break; }
                    break;
                }
            case "*":
                {   if (stck.Count > 1)
                    {
                        stck.Push(stck.Pop() * stck.Pop());
                    }
                    else { Console.WriteLine("Ошибка! Нехватка элементов для выполнения действия"); break; }
                    break;
                }
            case "/":
                {if (stck.Count > 1)
                    {
                        int num = stck.Pop();
                        if (num != 0)
                        {
                            stck.Push(stck.Pop() / num);
                        }
                        else { Console.WriteLine("Ошибка! Деление на ноль"); break; }
                    }
                    else { Console.WriteLine("Ошибка! Нехватка элементов для выполнения действия"); break; }
                    break;
                }
        }
    }
}
Console.WriteLine(stck.Pop());

