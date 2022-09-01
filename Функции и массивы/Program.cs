// Функция заполняет массив рандомными целыми числами от 1 до 9
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}   
// Функция вывода массива на экран
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Список элементов: ");
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position ++;
    }
}
// Функция ищет индекс первого вхождения элемента в массив
void IndexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            Console.WriteLine ($"Найдена позиция: {position+1}");
        }
        
        index ++;
    }
    if (position == -1)
    {
        Console.WriteLine("Нет такого значения");
    }
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);

Console.WriteLine(); 

//int UserIn = int.Parse(Console.ReadLine());

int lever = 1;
while (lever == 1)
{
    Console.WriteLine("Введите целое число, индекс которого необходимо найти: ");
    string UserIn = Console.ReadLine();
    if (int.TryParse(UserIn, out int X3) == true)
    {
        IndexOf(array,int.Parse(UserIn));
    }
    else
    {
        Console.WriteLine("Это не число!");
    }
    lever = 2;
    while (lever > 1)
    {
        Console.WriteLine("Повторить? Y/N");
        UserIn = Console.ReadLine();
        lever = 0;
        if (UserIn.ToLower() == "y")
        {
            lever = 1;
        }
        else if (UserIn.ToLower() == "n")
        {
            lever = 0;
        }
    }
}    