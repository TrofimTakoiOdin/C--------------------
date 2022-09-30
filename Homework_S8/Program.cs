 class Program
    {
        static void Main(string[] args)
        {
            bool ShowMenu = true;
            while (ShowMenu)
            {
                ShowMenu = MainMenu();
            }       
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
                if (Console.ReadLine().ToLower() == "y") return false;  
                else return true;
            }
        static bool MainMenu()
            {
                Console.Clear(); 
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Выберите задачу: ");
                Console.WriteLine("1. Задача 54");
                Console.WriteLine("2. Задача 56");
                Console.WriteLine("3. Задача 58");
                Console.WriteLine("4. Задача 60");
                Console.WriteLine("5. Задача 62");
                Console.WriteLine("Для выхода нажмите Q");
                Console.ResetColor();
            
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                    Problem54();
                    Spaces();
                    return Exit();

                    case "2":
                    Problem56();
                    Spaces();
                    return Exit();

                    case "3":
                    Problem58();
                    Spaces();
                    return Exit();

                    case "4":
                    Problem60();
                    Spaces();
                    return Exit();

                    case "5":
                    Problem62();
                    Spaces();
                    return Exit();

                    case "q":
                    return false;

                    default:
                    return true;
                }
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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Console.Write("{0}\t", Arr[i, j]);
                    Console.WriteLine();
            }
            Console.ResetColor();
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
        public static void DiscendingOrderSort(ref int[,] Mas)
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
        static void Print3DArray (int[,,] array3D)
        {   
            Console.ForegroundColor = ConsoleColor.DarkGreen;
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
            Console.ResetColor();
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
        static void Problem54()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Задача 54: Задайте двумерный массив. ");
            Console.WriteLine("Программа упорядочивает по убыванию элементы каждой строки двумерного массива");
            Console.ResetColor();
            int[,] Matrix = InitMatrix();
            Matrix = Fill2DArray(Matrix);
            DiscendingOrderSort(ref Matrix);
            PrintArray(Matrix);
        }
        static void Problem56()
        {   
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. ");
            Console.WriteLine("Пограмма будет находить строку с наименьшей суммой элементов.");
            Console.ResetColor();
            int[,] Matrix = InitMatrix();
            Matrix = Fill2DArray(Matrix);
            PrintArray(Matrix);
            Console.WriteLine();
            Console.WriteLine($"Строка с наименьшей суммой элементов: {SmallestRow(Matrix)} ");
        }
        static void Problem58()
        {   
            Console.Clear();
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
            PrintArray(FirstMatrix);
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Матрица Б: ");
            Console.WriteLine();
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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Задача 60. Сформирован трёхмерный массив из неповторяющихся двузначных чисел.");
            Console.WriteLine("Программа построчно выводит массив, добавляя индексы каждого элемента.");
            Console.ResetColor();
            int[,,] My3DMass = Init3DArray();
            Fill3DArray(My3DMass);
            Print3DArray(My3DMass);
        }
        static void Problem62()
        {
            Console.Clear();
            Console.WriteLine("Задача 62: Заполните спирально массив 4 на 4.");
            int n = 4;
            int[,] MatrixFour = new int[n, n];

            int temp = 1, i = 0, j = 0;

            while (temp <= MatrixFour.GetLength(0) * MatrixFour.GetLength(1))
            {
                MatrixFour[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < MatrixFour.GetLength(1) - 1) j++;
                
                else if (i < j && i + j >= MatrixFour.GetLength(0) - 1) i++;
    
                else if (i >= j && i + j > MatrixFour.GetLength(1) - 1) j--;
    
                else i--;
    
            }
            PrintArray(MatrixFour);
        }

    }    
           

    
       