Console.WriteLine("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
   
    if ( number < 100 )
    Console.WriteLine("Your number is not correct");    
    
    int makeThreeNumber (int number)
    {
    while (number > 999)    
    {
    number /= 10;
    }
    return number % 10;
    }
    
    Console.WriteLine($"You num is:" +  makeThreeNumber(number));  