Console.Write("Enter a number corresponding to the day of the week and find out which one is a day off ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");
