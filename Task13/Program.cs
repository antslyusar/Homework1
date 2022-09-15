Console.Write("Enter any number an find out which digit is third");
int a = Convert.ToInt32(Console.ReadLine());
string aString = Convert.ToString(a);
if (aString.Length > 2)
{
    Console.WriteLine($"The third digit is {aString[2]}");
}
else
{
    Console.WriteLine("There is no third digit");
}