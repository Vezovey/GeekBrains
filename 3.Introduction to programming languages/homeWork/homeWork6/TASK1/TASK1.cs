// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
1.Пользователь задаёт величину массива
2.Пользователь вводит числа в массив
*/



int[] makeArray(int userSize)
{
    int[] array = new int[userSize];
    for (int i = 0; i < userSize; i++)
    {
        Console.Write($"Input your number{i + 1}:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void printArray(int[] printArr)
{
    for (int i = 0; i < printArr.Length; i++)
    {
        Console.Write(printArr[i] + " ");
    }
    Console.WriteLine(" ");
}

int posNum(int[] inNum)
{
    int sum = 0;
    int i = 0;
    while (i < inNum.Length)
    {
        if (inNum[i] > 0)
            sum = sum + 1;
            i++;
    }
    return sum;
}

Console.WriteLine("Input your massive size: ");
int massSize = Convert.ToInt32(Console.ReadLine());



int[] result = makeArray(massSize);
printArray(result);
int itog = posNum(result);
Console.WriteLine($"Pos num {itog}");

