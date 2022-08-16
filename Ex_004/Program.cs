Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a < N)
{
    a = a + 1;
    Console.Write($"{a}, ");
    a++;
}
