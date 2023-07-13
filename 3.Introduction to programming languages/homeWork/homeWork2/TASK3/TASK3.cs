
Console.WriteLine("Choose a day of the week: ");
int number_week = Convert.ToInt32(Console.ReadLine());

if (number_week > 7)
Console.WriteLine("Selected number is more than days per week ");

if (number_week < 6)
Console.WriteLine(" Will have to work ");

if (number_week >5 && number_week <= 7)
Console.WriteLine(" Day off ");
