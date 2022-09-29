 class Program
    {
        static void Main(string[] args)
        {
            Problem58();
            
            
            
 
        }
        static int[,] InitMatrix()
        {
            Console.WriteLine("Введите число строк: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число столбцов: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] Matrix = new int[x, y];
            return Matrix;
        }
        static void PrintArray(int[,] Arr)
        {
           for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Console.Write("{0}\t", Arr[i, j]);
                    Console.WriteLine();
            }
        }
 
        static int[,] Fill2DArray(int[,] Matrix)
        {
            
            Random rand = new Random();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = rand.Next(1, 15);
                    
                }
                
            }
            return Matrix;
        }
 
        public static void DiscendingOrderSort(int[,] Mas)
        {
 
            int x, i,j,k;
            
            for (i = 0; i < Mas.GetLength(0); i++)
            {
 
                for (j = 0; j < Mas.GetLength(1); j++)
                {
                    x = Mas[i, j];
 
                    for (k = j - 1; k >= 0 && Mas[i,k] < x; k--)
                    {    
                        Mas[i, k + 1] = Mas[i, k];
 
                        
                    }
                    Mas[i, k + 1] = x;
                }
            }
    
        }
    
        static int RowSum(int[,] Mas, int i)
        {
            int j;
            int StrSum = Mas[i, 0];
            for (j = 1; j < Mas.GetLength(1); j++)
            {
               StrSum += Mas[i, j];
            }
            return StrSum;
        }
    
        static int SmallestRow(int[,] Mas)
        {
            int MinLineInd = 0;
            int MinSum = RowSum(Mas, 0);
            for (int i = 1; i < Mas.GetLength(0); i++)
            {
                int TempSum = RowSum(Mas, i);
                
                if (MinSum > TempSum)
                {
                    MinSum = TempSum;
                    MinLineInd = i + 1;
                }
            }
            return MinLineInd;
        }    
    
        static void Problem56(int[,] Mas)
        {
            Console.WriteLine($"Строка с наименьшей суммой элементов: {SmallestRow(Mas)} ");
        }
    
        static int[,] MatrixMultyply(int[,] MartrixOne, int[,] MartrixTwo, int[,] ResultMatrix)
        {
            for (int i = 0; i < ResultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ResultMatrix.GetLength(1); j++)
                {
                    int Total = 0;
                    for (int k = 0; k < MartrixOne.GetLength(1); k++)
                    {
                        Total += MartrixOne[i,k] * MartrixTwo[k,j];
                    }
                    ResultMatrix[i,j] = Total;
                }
            }
            return ResultMatrix;
        }   
    

        static void Problem58()
        {   Console.Clear();
            Console.WriteLine("Данная программа перемножает матрицы.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Количество столбцов матрицы А должно быть равно количству строк матрицы Б");
            Console.ResetColor();
            Console.WriteLine("Введите параметры матрицы А: ");
            int[,] FirstMatrix = InitMatrix();
            FirstMatrix = Fill2DArray(FirstMatrix);
            Console.WriteLine("Введите параметры матрицы Б: ");
            int[,] SecondMatrix = InitMatrix();
            SecondMatrix = Fill2DArray(SecondMatrix);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Матрица А: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            PrintArray(FirstMatrix);
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Матрица Б: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            PrintArray(SecondMatrix);
            Console.WriteLine();
            Console.ResetColor();
            if (FirstMatrix.GetLength(1) == SecondMatrix.GetLength(0))
            {
                int[,] ResMatrix = new int[FirstMatrix.GetLength(0), SecondMatrix.GetLongLength(1)];
                Console.WriteLine("Результат произведения матриц:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                PrintArray(MatrixMultyply(FirstMatrix, SecondMatrix, ResMatrix));
                Console.ResetColor();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Такие матрицы нельзя перемножить");
                Console.WriteLine("так как количество столбцов матрицы А не равно количеству строк матрицы В.");
                Console.ResetColor();
            }

        }
    }
       