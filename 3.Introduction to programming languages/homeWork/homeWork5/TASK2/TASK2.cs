//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int [] makeArray (int userSize)
{
    int [] array = new int [userSize];
    Random threeNum = new Random();
    for(int i = 0; i < userSize; i++)
    {
        array [i] = threeNum.Next(1, 100);
    }
    return array;
}

void printArray (int [] printArr)
{
    for(int i = 0; i < printArr.Length; i ++)
    {
        Console.Write(printArr[i] + " ");
    }
    Console.WriteLine(" ");
}

int sumSecondNumber (int [] sumNumber)
{
    int result = 0;
    for(int i = 0; i < sumNumber.Length; i++)
    {
        if(i % 2 == 0)
        {
            result = result + sumNumber[i];
        }
    }    
    return result;
}


Console.WriteLine("input your number: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int [] readyArray = makeArray(userSize);
printArray(readyArray);
int itog = sumSecondNumber(readyArray);
Console.WriteLine($"Sum {itog} ");