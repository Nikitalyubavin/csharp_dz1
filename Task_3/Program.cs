Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int num1 = num % 2;

if (num1 == 0)
{
    Console.WriteLine($"{num} -> да");
}
else
{
    Console.WriteLine($"{num} -> нет");
}