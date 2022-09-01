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

Console.Write("Введите целое число, индекс которого необходимо найти: ");
int UserIn = int.Parse(Console.ReadLine());
IndexOf(array,UserIn);