Console.WriteLine("Enter 2 numbers and explore which one is larger!");
int a, b;
Console.WriteLine("Enter the firts number - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number - ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} larger than {b}");
}
else
{
    Console.WriteLine($"{b} larger than {a}");
}