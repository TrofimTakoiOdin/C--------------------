internal class Program
{
    private static void Main(string[] args)
    {

    }    
    string[] EnterAndSplitString()
    {
        Console.Write("Введите числа через пробел, запятую или / : ");
        return Console.ReadLine()!.Split(' ', ',', '/');
    }
    int[] ParseInput(string[] nums)
    {
        int[] integerNums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            integerNums[i] = int.Parse(nums[i])!;
        }
        return integerNums;
    }
    void FromNtoOne(int num)
    {
        if (num > 0)
        {
            Console.Write($"{num} ");
            FromNtoOne(num - 1);
        }
        else
        {
            Console.WriteLine();
            return;
        }
    }
    int BetweenNumsSum(int a, int b)
    {
        int total = 0;
        if (a == b)
        {
            return a;
        }
        total += b;
        return BetweenNumsSum(a, b - 1) + total;

    }
    int Akkerman(int x, int y)
    {
        if (x == 0) return y + 1;
        else if (x > 0 && y == 0) return Akkerman(x - 1, 1);
        return Akkerman(x - 1, Akkerman(x, y - 1));
    }
    
}