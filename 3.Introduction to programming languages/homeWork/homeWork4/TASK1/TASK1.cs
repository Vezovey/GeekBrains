int NaturalNumber (int from, int to)
{
   int result = 1;
   int y = 0;

    for (int i = from; y<to; y++)
    {
       result = result * i;
    }
     return result;
}



Console.WriteLine("Input your number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your natural number {numberA} on {numberB} = {NaturalNumber(numberA, numberB)}");