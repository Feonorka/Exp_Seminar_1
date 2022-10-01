//Задача 16. Напишите программу, которая
// 1. принимает на вход два числа и проверяет
// 2.является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Первое число для проверки: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число для проверки: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool SquareNum(int numerFirst, int numerSecond)
{
    return numerFirst * numerFirst == numerSecond;
}

bool DivSquare(int numerFirst, int numerSecond)
{
    return numerSecond / numerFirst == numerFirst;
}

string Result(int n1, int n2)
{
    if (SquareNum(n1, n2) & DivSquare(n1, n2)) return "Да";
    else return "Нет";
}

string proverkaNum = Result(num1, num2);
Console.WriteLine(proverkaNum);
