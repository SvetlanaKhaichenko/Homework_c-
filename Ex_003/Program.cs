Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 2;
if (a % b == 0)
{
    Console.WriteLine($"Введенное число {a} четное");
}
else
{
    Console.WriteLine($"Введенное число {a} нечетное");
}