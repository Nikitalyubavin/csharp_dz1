Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"a = {num1}, b = {num2} -> max = {num1}");
}
else
{
    Console.WriteLine($"a = {num1}, b = {num2} -> max = {num2}");
}