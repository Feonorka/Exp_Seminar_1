// Задача 11. Напишите программу, которая
// 1. Выводит случайное трёхзначное число
// 2. Удаляет вторую цифру этого числа
// 3. Выводи на печать двухзначное число
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Случайное число в интервале отрезка 10 - 99 -> {number}");

int CutNum(int digNum)
{
    int firstNum = digNum / 100;
    Console.WriteLine($"Первая цифра {firstNum}");
    int thirdNum = digNum % 10;
    Console.WriteLine($"Третья цифра {thirdNum}");
    int resNum = firstNum * 10 + thirdNum;
    return resNum;
}
int cuter = CutNum(number);
Console.WriteLine(cuter);
