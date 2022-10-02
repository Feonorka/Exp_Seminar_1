Console.Write("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());

string MyCalendar(int weekDay)
{
    string[] Days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
    int lenght = Days.Length;
    if (weekDay > 7 | weekDay <= 0) return $"{weekDay} не соответствует ни одному дню недели";
    else return Days[weekDay - 1];
}

string CheckCal(int numDay)
{
    if (numDay >= 6 & numDay <= 7) return "Выходной";
    else if (numDay <= 5 & numDay >= 1) return "Рабочий";
    else return "Введите другое число";
}

string day = MyCalendar(num);
string whatDay = CheckCal(num);
Console.WriteLine($"({num}) {day} - {whatDay}");

