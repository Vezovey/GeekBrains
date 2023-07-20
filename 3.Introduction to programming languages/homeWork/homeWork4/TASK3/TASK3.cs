// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] GetRandomArray (int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 99);

    }
    return result;
}

void PrintArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i] + " ");
    }
}

int[] RandomArray = GetRandomArray(8);
PrintArray(RandomArray);