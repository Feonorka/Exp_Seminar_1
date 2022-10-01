Console.Write("Ваше число для проверки кратности: ");
int numMain = Convert.ToInt32(Console.ReadLine());

Console.Write("Первое число для проверки: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число для проверки: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string PairDiv(int one, int two, int three)
{
    if (one % two == 0 & one % three == 0) return "Да";
    else return "Нет";
}
string result = PairDiv(numMain, num1, num2);
Console.WriteLine(result);
