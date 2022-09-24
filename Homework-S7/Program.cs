static double[,] FillTwoDemensionalArray()
{
    Console.WriteLine("Задайте размер массива: M x N");
    Console.WriteLine("Введите количество строк: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int N = Convert.ToInt32(Console.ReadLine());
    double[,]Matrix = new double[M, N];
    Random rnd = new Random();
    
    for (int i = 0; i < M; i++)
    {
        
        for (int j = 0; j < N; j++)
        {
            Matrix[i, j] = Convert.ToInt64(rnd.Next(-100, 100));
        }
    }
    return Matrix;
}   

static void PrintArray(double[,] Matr)
 {
     Console.ForegroundColor = ConsoleColor.DarkBlue;
     for (int i = 0; i < Matr.GetLength(0); i++)
     {
         for (int j = 0; j < Matr.GetLength(1); j++)
         {
             Console.Write(Matr[i, j] + " ");
         }
         Console.WriteLine();
     }
     Console.ResetColor();
}
static void FindElementInTDA(double[,] Matr)
{
    Console.WriteLine("Введите координаты");
    Console.WriteLine("x = ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y = ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x < Matr.GetLength(0) && y < Matr.GetLength(1))
    {
        var z = Matr.GetValue(x, y);
        Console.WriteLine($"Искомый элемент: {z}");
    }
    else Console.WriteLine("Такого элемента нет!");
}
static void ArithmeticMeanColumn(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        int Arithmetic
    }
}
var Matriza = FillTwoDemensionalArray();
PrintArray(Matriza);
FindElementInTDA(Matriza);
