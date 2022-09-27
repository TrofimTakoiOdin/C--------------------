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
