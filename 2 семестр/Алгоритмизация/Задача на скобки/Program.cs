Console.Write("Введите выражение: ");
string a = Console.ReadLine();
Stack<string> List = new Stack<string>();
for(int i = 0; i < a.Length; i++)
{
    if (a[i] == '(' || a[i] == '[' || a[i] == '{') { List.Push(Convert.ToString(a[i])); }
    if (a[i] == ')') { if (!List.Contains(Convert.ToString('('))) {  Console.WriteLine("Скобки расставлены неправильно"); break; } }
    if (a[i] == ']') { if (!List.Contains(Convert.ToString('['))) { Console.WriteLine("Скобки расставлены неправильно"); break; } }
    if (a[i] == '}') { if (!List.Contains(Convert.ToString('{'))) { Console.WriteLine("Скобки расставлены неправильно"); break; } }
    if(i == a.Length - 1) { Console.WriteLine("Скобки расставлены верно"); }
}