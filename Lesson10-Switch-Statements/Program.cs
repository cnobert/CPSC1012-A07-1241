#region intro text
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
#endregion

#region switch statements
//logically the same as stacked if/else statements

Console.Write("What grade did you earn? ");
// string grade = Console.ReadLine()[0] + "";
//string grade = Console.ReadLine()[0].ToString();
string grade = Console.ReadKey().KeyChar.ToString();
Console.WriteLine();
string output = "";
switch(grade.ToUpper())
{
    case "A":
        output = "Congratulations!";
        break;
    case "B":
        output = "Very good!";
        break;
    case "C":
        output = "So so!";
        break;
    case "D":
        output = "At least you passed.";
        break;
    case "F":
        output = "Sorry, you fail.";
        break;
    default:
        output = "Invalid grade. Try again.";
        break;
}
Console.WriteLine(output);

#endregion

#region outro text
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");

#endregion
