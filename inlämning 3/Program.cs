using System;

class Program
{
    static void Main()
    {
        int height = 5; 

        for (int row = 1; row <= height; row++)
        {
            Console.Write(new string(' ', height - row));

            if (row < height)
            {
                Console.Write("/"); 

                int innerSpace = 2 * row - 2;

                for (int col = 1; col <= innerSpace; col++)
                {
                    if (row == 3 && (col == 2 || col == innerSpace - 1))
                        Console.Write("\"");
                    else
                        Console.Write(" ");
                }

                Console.Write("\\"); 
            }
            else
            {
                Console.Write("/");
                Console.Write(new string('_', 2 * row - 2));
                Console.Write("\\");
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
