// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (secondNumber >= max) max = secondNumber;
if (thirdNumber >= max) max = thirdNumber;
{
    Console.WriteLine($"This is the biggest number {max}");
}
