using System.Globalization;

Console.WriteLine();
Console.WriteLine();

#region Loose Ends (toUpper, toLower, +=, -=)

// string number01 = "100";
// int otherNumber = 10;
// //"+" is the concatenation operator because at least one of the operands is a string
// Console.WriteLine(number01 + otherNumber);
// Console.WriteLine(int.Parse(number01) + otherNumber);
// Console.WriteLine(otherNumber + "");

// Console.Write("What's the name of the city/place you were born in? ");
// string cityName = Console.ReadLine();
// Console.WriteLine("The city/place that you were born, in all capital letters, is: " + cityName.ToUpper());
// Console.WriteLine(cityName + ", in all lower case letters, is " + cityName.ToLower());
// //you wouldn't do the following, I'm just showing you for the giggles
// Console.WriteLine("thIs IS MIxed Case".ToUpper());

int age = 10;
age = age + 5;
age += 5; //same as age = age + 5
age -= 5; //same as age = age - 5
age++; // same as age = age + 1, alse the same as age += 1
age--; // same as age = age - 1, also the same as age -= 1
age /= 2; // same as age = age / 2
age *= 2; // same as age = age * 2

//prints out 14?
//Console.WriteLine(age);

#endregion

#region Escape Characters
//to insert certain characters into our strings, we use the escape character, \
// They yelled: "boo".
//Console.WriteLine("They yelled: \"boo!\"");

//commone escape characters include:
//backslash \\
//double quote \"
//tab \t
//newline character \n
//Console.WriteLine("Here is the character for a backslash \\");
//Console.WriteLine("They yelled...\n\n\n\n\"boo!\"");

//Console.WriteLine("It\'s alright!"); //Console.WriteLine("It's alright!");
char singleQuote = '\'';
#endregion

#region String Interpolation
//example taken from this course doc https://lms.nait.ca/d2l/le/content/25527/viewContent/1173587/View

int firstNum = 150;
double secondNum = 1234.56789;
Console.WriteLine("firstNum: " + 150 + "\nsecondNum: " + secondNum);

//string interpolation
Console.WriteLine($"firstNum: {firstNum} \nsecondNum: {secondNum}");
Console.WriteLine($"firstNum: {firstNum:0000} \nsecondNum: {secondNum:00000.00}");
Console.WriteLine($"firstNum: ${firstNum:#,##0.00} \nsecondNum: ${secondNum:#,##0.00}");

#endregion
Console.WriteLine();
Console.WriteLine();