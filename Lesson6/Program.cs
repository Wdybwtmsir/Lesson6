try
{
    int a, b;
    Console.WriteLine("Введите, сколько прошло дней:");
    a = Convert.ToInt32(Console.ReadLine());
    if (a < 7)
        Console.WriteLine($"С момента отсчета прошло 0 целых недель, а остаток дней равен - {a} ");
    if (a <= -1)
        Console.WriteLine("Количество дней не может быть меньше нуля ");
    b = a / 7;
    a -= b * 7;
    Console.WriteLine($"Полных недель с начала отчета прошло - {b}, остаток дней равен - {a} ");
}
catch
{
    Console.WriteLine("Введите правильные данные!");
}