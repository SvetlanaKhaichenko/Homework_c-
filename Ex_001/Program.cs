Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write($"Число {a} > {b}");
}
else
{
    Console.Write($"Число {b} > {a}");
}