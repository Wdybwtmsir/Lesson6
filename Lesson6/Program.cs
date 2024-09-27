try
{
    int DaysPassed, WeeksFull;
    Console.WriteLine("Введите, сколько прошло дней:");
    DaysPassed = Convert.ToInt32(Console.ReadLine());
    if (DaysPassed < 7)
        Console.WriteLine($"С момента отсчета прошло 0 целых недель, а остаток дней равен - {DaysPassed} ");
    if (DaysPassed <= -1)
        Console.WriteLine("Количество дней не может быть меньше нуля ");
    WeeksFull = DaysPassed / 7;
    DaysPassed -= WeeksFull * 7;
    Console.WriteLine($"Полных недель с начала отчета прошло - {WeeksFull}, остаток дней равен - {DaysPassed} ");
}
catch
{
    Console.WriteLine("Введите правильные данные!");
}