/* Задача 29: Напишите метод, который задаёт массив из N элементов 
и выводит их на экран. (1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  
6, 1, 33 -> [6, 1, 33]) */


int Print(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
// получения случайных чисел
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}

int length = Print("введите длину массива: ");
int min = Print("начальное значение диапазона: ");
int max = Print("конечное значение диапазона: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);