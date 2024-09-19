Console.WriteLine("-----------------------");
Console.WriteLine("-----------------------");

#region Question 1 from Sequence Structure Programming Exercises

// Console.WriteLine("Enter your name:");
// string name = Console.ReadLine();
// Console.WriteLine("Enter your age:");
// int age = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter your annual salary:");
// double salary = double.Parse(Console.ReadLine());
// // Console.WriteLine($"My name is {name}, my age is {age}, and I hope to earn ${salary:#,##0.00}");
// Console.WriteLine($"My name is {name}, my age is {age}, and I hope to earn ${salary:n}");
#endregion

#region Question 2 from Sequence Structure Programming Exercises

Console.WriteLine("Enter the radius and length of a cylinder:");
double radius = double.Parse(Console.ReadLine());
double length = double.Parse(Console.ReadLine());

// double area = radius * radius * 3.14;
// double area = radius * radius * Math.PI;
double area = Math.Pow(radius, 2) * Math.PI;

Console.WriteLine($"The area is {area:#0.0000}");
Console.WriteLine($"The volume is {area * length:#0.0}");

#endregion 
Console.WriteLine("-----------------------");
Console.WriteLine("-----------------------");