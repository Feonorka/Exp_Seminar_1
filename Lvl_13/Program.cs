Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int dlina = num.ToString().Length;

int Delitel(int numA)
{
    int dlina = numA.ToString().Length;
    while (dlina > 3)
        {
            numA = numA / 10;
            dlina --;
        }
    return (numA % 10);
}

int devNum = Delitel(num);
if (dlina < 3)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine(devNum);