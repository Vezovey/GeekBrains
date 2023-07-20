// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Func(int numOst)
{
int count = Convert.ToString(numOst).Length;
int lastEd = numOst % 10;
int MiddleEd = numOst % 100 / 10;
int FirstEd = numOst / 100;
int Result = 0;
    for (int i = 0; i < count; i++ )
    {
    Result = FirstEd + MiddleEd + lastEd;
    }
    return Result;
}

Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum your number {num} equals = {Func(num)}");