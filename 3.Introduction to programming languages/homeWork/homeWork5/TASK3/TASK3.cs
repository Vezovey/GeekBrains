// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] makeArray (int userSize)
{
    double [] array = new double [userSize];
    for(int i = 0; i < userSize; i++)
    {
        array[i] = new Random().Next(1, 10) + new Random().NextDouble();
    }
    return array;
}

void printArray (double [] printArr)
{
    for(int i = 0; i < printArr.Length; i ++)
    {
        Console.Write($"{printArr[i]:F2} ", " ");
    }
    Console.WriteLine(" ");
}

double magic (double[] randomArr)
{
    double min = randomArr[0];
    double max = randomArr[0];
    int i = 0;
    while(i < randomArr.Length)
    {
        if(max < randomArr[i])
           max = randomArr[i];
        if(min > randomArr[i])
           min = randomArr[i];
        i++;
    }
    return max - min;
}

Console.WriteLine("input your massive size: ");
int userSize = Convert.ToInt32(Console.ReadLine());

double [] readyArray = makeArray(userSize);
printArray(readyArray);
Console.Write($"Difference between maximum and minimum value: {magic(readyArray):f2}");
