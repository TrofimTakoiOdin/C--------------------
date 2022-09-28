 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число столбцов: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] Matrix = new int[x, y];
            Console.WriteLine();
            Initialize2DArray(Matrix);
            Console.WriteLine();
            PrintArray(Matrix);
            SmallestRowSum(Matrix);
 
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
 
        static void Initialize2DArray(int[,] Matrix)
        {
            
            Random rand = new Random();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = rand.Next(1, 15);
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
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
    
        static void SmallestRowSum(int[,] Mas)
        {
            int i, j, Total, TempTotal, MinStrNum, MinTotal;
            MinStrNum = 0;
            for (i = 1; i < Mas.GetLength(0); i++)
            {
                Total = 0;
                TempTotal = 0;
                for (j = 0; j < Mas.GetLength(1); j++)
                {
                    Total += Mas[i, j];
                    TempTotal += Mas[i - 1, j];
                    if (Total <= TempTotal)
                    {
                        MinTotal = Total;
                        MinStrNum = i;
                    }
                    else MinStrNum = i - 1;
                }
                
            }
            Console.WriteLine($"Строка с наименьшей суммой элементов: {MinTotal}");
        }
    }
       