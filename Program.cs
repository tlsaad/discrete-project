Console.WriteLine("The perfect numbers program ");
Console.WriteLine("Enter first number : ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Enter last number : ");
int end = int.Parse(Console.ReadLine());
int i = start, n = 1, sum = 0;
Console.WriteLine("The perfect numbers are ");
while (i <= end)
{
    while (n <= end)
    {
        if (n < i)
        {
            if (i % n == 0)
                sum = sum + n;
        }
        n++;
    }
    if (sum == i)
    {
        Console.Write(i + " ");
    }
    i++;
    n = 1;
    sum = 0;
}
Console.ReadKey();
