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

int [,] sumReturn (int [,] readyArray)
{
for (int j = 0; j< readyArray.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < readyArray.GetLength(0) ; i++)
    {
        sum = sum + readyArray[i,j];
    }
Console.WriteLine($"Your result Collumn {j+1}:{sum/readyArray.GetLength(0):f2} ");
}
return readyArray;
}


Console.WriteLine("Enter count of rows: ");
int userRows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of Collumns: ");
int userColl1 = Convert.ToInt32(Console.ReadLine());

int [,] result = sumReturn(makeArray(userRows1, userColl1));
Console.WriteLine();
printArray(result);