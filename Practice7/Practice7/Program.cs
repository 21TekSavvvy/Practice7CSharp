class loops
{
    static void Main()
    {
        for(int i = 1; i <11;i++)
        {
            if (i == 5 || i==6)
            {
                continue;
            }
            System.Console.Write(i+ " ");
        }
        System.Console.WriteLine();
        for (int i = 1; i < 11; i++)
        {
            if (i == 5 || i == 6)
            {
                continue;
            }
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        for (int i = 1; i < 11; i++)
        {
            if (i == 5 || i == 6)
            {
                continue;
            }
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        for (int i = 10; i >0; i--)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        for (int i = 10; i > 0; i--)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        for (int i = 10; i > 0; i--)
        { 
            if (i == 2)
            {
                break;
            }
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        for (int i = 10; i > 0; i--)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
        for (int i = 1; i < 11; i++)
        {
            System.Console.Write(i + " ");
        }
        System.Console.ReadKey();
    }
}