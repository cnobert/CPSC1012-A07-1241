Console.WriteLine("-----------------------");
Console.WriteLine("-----------------------");

#region Question 1 from Sequence Structure Programming Exercises

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your annual salary:");
double salary = double.Parse(Console.ReadLine());
// Console.WriteLine($"My name is {name}, my age is {age}, and I hope to earn ${salary:#,##0.00}");
Console.WriteLine($"My name is {name}, my age is {age}, and I hope to earn ${salary:n}");
#endregion

Console.WriteLine("-----------------------");
Console.WriteLine("-----------------------");