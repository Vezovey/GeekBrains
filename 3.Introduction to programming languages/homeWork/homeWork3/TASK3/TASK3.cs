void functionCoub(int number)
{
for (int temp = 1; temp <= number; temp++)
{
    double num = Math.Pow(temp, 3);
    Console.Write( num + " " );
}
}

Console.WriteLine("Input your number:");
int num = Convert.ToInt32(Console.ReadLine());
functionCoub(num);


