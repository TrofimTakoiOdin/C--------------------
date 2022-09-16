    // string[,]table = new string[2, 3];
    // table[1, 2] = "word";
    // for (int rows = 0; rows < 2; rows++)
    // {
    //     for (int columns = 0; columns < 3; columns++)
    //     {
    //         Console.Write($"-{table[rows, columns]}-");
    //     }
    //     Console.WriteLine();
    // }

    // static void PrintArray(int[,] matr)
    // {
    //     Console.ForegroundColor = ConsoleColor.DarkBlue;
    //     for (int i = 0; i < matr.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < matr.GetLength(1); j++)
    //         {
    //             Console.Write(matr[i, j] + " ");
    //         }
    //         Console.WriteLine();
    //     }
    //     Console.ResetColor();
    // }
    // static void FillArray(int[,] matr)
    // {
    //     for (int i = 0; i < matr.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < matr.GetLength(1); j++)
    //         {
    //             matr[i, j] = new Random().Next(1, 11);
    //         }
    //     }
    // }
    // int[,]matr = new int[10, 10];
    // FillArray(matr);
    // PrintArray(matr);
double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
// for (int i = 1; i < 25; i++)
// {
//     Console.WriteLine($"{i}! ► {Factorial(i)}");
// }
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 10; i++)
{
     Console.WriteLine($"{i} ► {Fibonacci(i)}");
}
