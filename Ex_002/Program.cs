Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int q = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max > b)
{
   max = a;
}
else
{
    max = b;
}
if (max < q)
{
  max = q;
}
Console.WriteLine($"Наибольшее число из введенных {max}");

