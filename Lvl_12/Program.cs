// Задача 12. Напишите программу которая будет
// 1. принимать на вход два числа
// 2. выводить является ли второе число кратным первому
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Write("Ваше первое число: ");
int fnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваше второе число: ");
int snum = Convert.ToInt32(Console.ReadLine());

string DivNum(int firstNUM, int secNUM)
{
int resNum = firstNUM % secNUM;
if (resNum == 0) return "Кратно";
else return $"Не кратно, остаток {resNum}";
}

string kratnoe = DivNum(fnum, snum);
Console.WriteLine(kratnoe);
