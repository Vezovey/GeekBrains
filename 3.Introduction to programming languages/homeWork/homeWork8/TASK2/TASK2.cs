// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] makeArray (int userRows, int userColl)
{


int [,] newArray = new int [userRows, userColl];
for (int i = 0; i < userRows; i++)
{
    for (int j = 0; j < userColl; j++)
    {
        newArray[i,j] = new Random().Next(1, 10);
    }
}
return newArray;
}

void printArray (int [,] randArray)

{
    for(int i = 0; i < randArray.GetLength(0); i++)
    {
        for(int j = 0; j < randArray.GetLength(1); j++)
        {
            Console.Write(randArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinRow (int [,] array)
{
    int [] sumArray = new int [array.GetLength(0)];

    int sum;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];

        }
        sumArray[i] = sum;
    }
int MinSumArray = sumArray[0];
int numRow = 1;
for (int v = 0; v < sumArray.Length; v++)
{
    if (sumArray[v] < MinSumArray)
    {
        MinSumArray = sumArray[v];
        numRow = v + 1;
    }
}
Console.Write($"Min row {numRow}, sum row {MinSumArray}");
}
Console.WriteLine("Enter count of rows: ");
int userRows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of Collumns: ");
int userColl1 = Convert.ToInt32(Console.ReadLine());

int [,] result = makeArray(userRows1, userColl1);
printArray(result);

MinRow(result);
