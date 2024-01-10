while (true)
{
    Console.WriteLine("Input a number for count");
    try
    {
        int num = int.Parse(Console.ReadLine());
        while (num > 0)
        {
            num--;
            Console.WriteLine(num);
        }
        Console.WriteLine();
    }
    catch
    {
        Console.WriteLine("Caught exception");
        Console.WriteLine();
        continue;
    }
}