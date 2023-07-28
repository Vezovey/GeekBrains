// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] makeArray ()
{
Console.WriteLine("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of Collumns: ");
int userColl = Convert.ToInt32(Console.ReadLine());

double [,] newArray = new double [userRows , userColl];
for (int i = 0; i < userRows; i++)
{
    for (int j = 0; j < userColl; j++)
    {
        newArray[i,j] = Math.Round((new Random().Next(1, 10) + new Random().NextDouble()),2);
    }
}
return newArray;
}

void printArray (double [,] randArray)
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



printArray(makeArray());

