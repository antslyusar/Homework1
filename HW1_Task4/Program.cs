Console.WriteLine("Enter 3 numbers and explore which one is the largest!");
int a, b, c;
Console.WriteLine("Enter the firts number - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number - ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number - ");
c = Convert.ToInt32(Console.ReadLine());

int max = (Math.Max(a, Math.Max(b, c)));
Console.WriteLine($"The largest number is {max}");