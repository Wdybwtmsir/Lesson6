try
{
    int a, b;
    Console.WriteLine("Введите, сколько прошло дней:");
    a = Convert.ToInt32(Console.ReadLine());    
    b = a / 7;
    a -= b * 7;
    Console.WriteLine($"Полных недель с начала отчета прошло - {b}, остаток дней равен - {a} ");
}
catch
{
    Console.WriteLine("Введите правильные данные!");
}