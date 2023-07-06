// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber < secondNumber)
{
    Console.WriteLine($"{secondNumber} more than {firstNumber}");;
}
else
{
    
    if(firstNumber == secondNumber)
    {
        Console.WriteLine($"{firstNumber} equal {secondNumber}");
    }
    else
    {
        Console.WriteLine($"{firstNumber} more than {secondNumber}");
    }
}
