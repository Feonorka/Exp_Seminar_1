
int number = new Random().Next(10, 100);
System.Console.WriteLine($"Случайное число в интервале отрезка 10 - 99 -> {number}");
// int firstDig = number / 10;
// int secondDig = number % 10;
// if (firstDig == secondDig) System.Console.WriteLine("Цифры равны");

// else if (firstDig > secondDig) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDig}");
// else Console.WriteLine($"Наибольшая цифпа числа {number} -> {secondDig}");

// int maxDig = 0;
// if (firstDig > secondDig) maxDig = firstDig;
// else maxDig = secondDig;

// int max = firstDig > secondDig ? firstDig : secondDig;

int MaxDigit (int numer)
{
    int firstDig = numer / 10;
    int secondDig = numer % 10;
    // if (firstDig > secondDig) return firstDig;
    // return secondDig;
    if (IsEqDig(firstDig, secondDig)) return -1;
    return firstDig > secondDig ? firstDig : secondDig;
}

bool IsEqDig(int numer1, int numer2)
{
    return numer1 == numer2;
}

int maxDigit = MaxDigit(number);
string res = maxDigit != -1 ? maxDigit.ToString(): "Цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");
