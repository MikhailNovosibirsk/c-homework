// Задайте произвольный массив. Выведете его элементы,
//  начиная с конца. Использовать рекурсию, не использовать циклы.

int [] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1,999);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

void ArrayFromEnd(int[] arr, int i = 0)
{
    if (i == arr.Length - 1)
    {
        Console.Write($"{arr[i]} ");
        return;
    }
    else
    {
        ArrayFromEnd(arr, i + 1);
        Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(size);
PrintArray(array);
ArrayFromEnd(array);
