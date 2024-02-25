class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("\t -= Welcome to my Project! =- ");
            System.Console.WriteLine("1. Triangle");
            System.Console.WriteLine("2. Square");
            System.Console.WriteLine("3. Parallelogram");
            System.Console.Write("Choose >>> ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    int n = 8;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n - i - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");

                        if (i > 0 && i < n - 1)
                        {
                            for (int k = 0; k < 2 * i - 1; k++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("*");
                        }

                        if (i == n - 1)
                        {
                            for (int l = 0; l < 2 * i; l++)
                            {
                                Console.Write("*");
                            }
                        }

                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for (int x = 0; x < 5; x++)
                    {
                        for (int k = 0;k < 5;k++)
                        {
                            if (x == 0)
                            {
                                System.Console.Write("* ");
                            }
                            else if (x == 4)
                            {
                                System.Console.Write("* ");
                            }
                            else
                            {
                                if (k == 0)
                                {
                                    System.Console.Write("* ");
                                }
                                else if (k == 4)
                                {
                                    System.Console.Write("* ");
                                }
                                else
                                {
                                    System.Console.Write("  ");
                                }
                            }
                        }
                        Console.WriteLine();
                    }

                    break;
                case 3:
                    int height = 7; 
                    int width = 10; 
                    for (int i = height - 1; i >= 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("  ");
                        }

                        for (int k = 0; k < width; k++)
                        {
                            if (k == 0 || k == width - 1 || i == 0 || i == height - 1)
                                Console.Write("* ");
                            else
                                Console.Write("  ");
                        }

                        Console.WriteLine();
                    }
                    break;
                default:
                    System.Console.WriteLine("You entered incorrectly!");
                    break;
            }
            System.Console.WriteLine("Do you want to continue? [Yes(y)/No(n)] >>> ");
            string goHome = System.Console.ReadLine();
            if (goHome == "n" | goHome == "N")
            {
                Console.Clear();
                System.Console.WriteLine("Thanks, bye!");
                break;
            }
        }
    }
}