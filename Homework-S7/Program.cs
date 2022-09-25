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

static void PrintDoubleArray(double[,] Matr)
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
static void PrintIntArray(int[,] Matr)
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
        double Total = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {

            Total += Convert.ToDouble(Array[j, i]);
        }
        double ArithmeticMean = Total / Array.GetLength(1);
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно: {ArithmeticMean}");
    }   
}
static int[,] FillArray()
 {  
    int[,] Matr = new int [5, 5];
    for (int i = 0; i < Matr.GetLength(0); i++)
    {
        for (int j = 0; j < Matr.GetLength(1); j++)
        {
            Matr[i, j] = new Random().Next(1, 11);
        }
    }
    return Matr;
 }
static void Problem47()
{
    var Matriza = FillTwoDemensionalArray();
    PrintDoubleArray(Matriza);

}
static void Problem50()
{
    var Matriza = FillTwoDemensionalArray();
    PrintDoubleArray(Matriza);
    FindElementInTDA(Matriza);
}
static void Problem52()
{
    var Matriza = FillArray();
    PrintIntArray(Matriza);
    ArithmeticMeanColumn(Matriza);
}
static void Spaces()
{
    Console.WriteLine("=================");
}
static bool Exit()
{
    Console.WriteLine("Хотите выйти?");
    Console.WriteLine("Введите Y, чтобы выйти");
    Console.WriteLine("Любая другая клавиша, чтобы вернуться в МЕНЮ");
    if (Console.ReadLine().ToLower() == "y")
    {
        return false;  
    }
    else
    {
        return true;
    }
}
static bool MainMenu()
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Black; 
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Выберите задачу: ");
    Console.WriteLine("1. Задача 47");
    Console.WriteLine("2. Задача 50");
    Console.WriteLine("3. Задача 52");
    Console.WriteLine("Для выхода нажмите Q");
    Console.ResetColor();
            
    switch (Console.ReadLine().ToLower())
    {
        case "1":
        Problem47();
        Spaces();
        return Exit();

        case "2":
        Problem50();
        Spaces();
        return Exit();

        case "3":
        Problem52();
        Spaces();
        return Exit();

        case "q":
        return false;

        default:
        return true;
    }
}

bool ShowMenu = true;
while (ShowMenu)
{
    ShowMenu = MainMenu();
}       