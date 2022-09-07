Console.WriteLine("Enter a number and explore if it is even or odd!");
int a;
a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"{a} is even");
}
else
{
    Console.WriteLine($"{a} is odd");
}
