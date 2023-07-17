void paligram(int numv)
{
    int ed = numv % 10;
    int fed = numv / 10000;
if (ed == fed)
    {
        ed = numv % 100 / 10;
        fed = numv / 1000 % 10;
    }
    if (ed == fed)
        {
        Console.WriteLine("Your number is paligram");
        }
else
    {
    Console.WriteLine("Your number is not paligram");
    }
}
Console.WriteLine("Write your number: ");
int numw = Convert.ToInt32(Console.ReadLine());

paligram(numw);