// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] makeArray (int userSize)
{
    int [] array = new int [userSize];
    Random threeNum = new Random();
    for(int i = 0; i < userSize; i++)
    {
        array [i] = threeNum.Next(100, 1000);
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

int posNumbers (int [] arrayNum)
{
    int count = 0;
    for(int i = 0; i < arrayNum.Length; i++)
    {
       if (arrayNum [i] % 2 == 0)
       {
        count ++;
       }
    }
    return count;
}

Console.WriteLine("input your number: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int [] readyArray = makeArray(userSize);
printArray(readyArray);
int itog = posNumbers(readyArray);
Console.WriteLine($"Your even number's {itog} ");

//1.Создание массива и запись трехзначных чисел
//2.Создать функцию вывода массива
//3.Создание функции вывода кол-во чисел в массиве
