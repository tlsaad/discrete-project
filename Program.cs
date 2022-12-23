internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers program ");
        Console.WriteLine("Enter first number : ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter last number : ");
        int end = int.Parse(Console.ReadLine());
        int total;
        for (int i = start; i < end; i++)
        {
            total = 0;
            for (int k = 1; k < i; k++)
            {
                if (i % k == 0) 
                {
                    total = total + k;
                                                          

                }
            }
            if (total == i)
            {
                Console.WriteLine(total);
            }

        }
        Console.ReadKey();
    }
}