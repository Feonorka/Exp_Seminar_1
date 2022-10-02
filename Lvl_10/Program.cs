Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Between (int numer)
{
    int dlinaNuma = numer.ToString().Length;
    if (dlinaNuma > 3 | dlinaNuma < 3) return -1;
    else
    return (numer / 10) % 10;
}

int secNum = Between (num);
Console.WriteLine(secNum);