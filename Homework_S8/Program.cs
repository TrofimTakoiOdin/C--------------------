 class Program
    {
        static void Main(string[] args)
        {
            Problem60();
            
            
            
 
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
    
        static void Problem60()
        {
            int[,,] My3DMass = Init3DArray();
            Fill3DArray(My3DMass);
            Print3DArray(My3DMass);
        }
        static int[,,] Init3DArray()
        {
            Console.WriteLine("Введите размеры массива (X x Y x Z): ");
            Console.WriteLine("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int[,,] Array3D = new int[x, y, z];
            return Array3D;
        
        }
    
        static void Fill3DArray(int[,,] Arr)
        {
            int[] Temp = new int[Arr.GetLength(0) * Arr.GetLength(1) * Arr.GetLength(2)];
            int  number;
            for (int i = 0; i < Temp.GetLength(0); i++)
            {
                Temp[i] = new Random().Next(10, 100);
                number = Temp[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (Temp[i] == Temp[j])
                        {
                            Temp[i] = new Random().Next(10, 100);
                            j = 0;
                            number = Temp[i];
                        }
                        number = Temp[i];
                    }
                }
            } 
            int Count = 0; 
            for (int x = 0; x < Arr.GetLength(0); x++)
            {
                for (int y = 0; y < Arr.GetLength(1); y++)
                {
                    for (int z = 0; z < Arr.GetLength(2); z++)
                    {
                    Arr[x, y, z] = Temp[Count];
                    Count++;
                    }
                }
            }
        }
        static void Print3DArray (int[,,] array3D)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    Console.Write($"X({i}) Y({j}) ");
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write( $"Z({k}) = {array3D[i,j,k]}; ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    
    }    
           

    
       