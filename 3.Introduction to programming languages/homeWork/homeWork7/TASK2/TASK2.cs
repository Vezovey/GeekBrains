double [,] makeArray (int userRows, int userColl)
{


double [,] newArray = new double [userRows, userColl];
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

double [,] returnResult (double [,] readyArray)
{
Console.WriteLine("enter coordinates I: ");
int coordRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter coordinates J: ");
int coordColl = Convert.ToInt32(Console.ReadLine());

int i = 0;
int j = 0;

if (coordRows >= i && coordRows <= readyArray.GetLength(0) && coordColl >=j && coordColl <= readyArray.GetLength(1) )
{
     Console.Write($"Your coordinat{readyArray[coordRows, coordColl]}");
     Console.WriteLine();
}

else 
{
    Console.WriteLine("Please enter valid coordinates no larger than the array");
}
return readyArray;
}


Console.WriteLine("Enter count of rows: ");
int userRows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of Collumns: ");
int userColl1 = Convert.ToInt32(Console.ReadLine());

double [,] result = returnResult(makeArray(userRows1, userColl1));
Console.WriteLine();
printArray(result);

