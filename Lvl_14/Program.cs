Console.Write("Ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

string PairDiv(int one)
{
    if (one % 7 == 0 & one % 23 == 0) return "Да";
    else return "Нет";
}
string result = PairDiv(num);
Console.WriteLine(result);
