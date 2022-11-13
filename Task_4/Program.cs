Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine());

int a = 1;

int s = 0;

Console.Write($"{n} -> ");

while (a < n - 1)
{
    s = a % 2;
    if (s == 0)
    {        
        Console.Write($"{a}, ");
        a = a + 1;
    }
    else
    {
        a = a + 1;
    }
}

while (a <= n)
{
    s = a % 2;
    if (s == 0)
    {        
        Console.Write($"{a}");
        a = a + 1;
    }
    else
    {
        a = a + 1;
    }
}