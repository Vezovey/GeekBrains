//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int divNumber = number % 2;
if (divNumber == 0)
{
    Console.WriteLine($"Yes. {divNumber} an even number");
}
else
{
    Console.WriteLine($"No. {divNumber} not an even number");
}

