Console.WriteLine("Write your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
if(user_number >= 100 && user_number < 1000)
{
  int dec = user_number % 100;
   int ed = user_number % 10;
   int result = (dec - ed) / 10;
Console.WriteLine($"{result}");
}
else 
Console.WriteLine("Your number is NOT correct");