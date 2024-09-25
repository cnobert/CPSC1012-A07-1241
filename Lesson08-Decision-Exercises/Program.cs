Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
Console.WriteLine();

#region notes on boolean operators
/*
    == equality operator (if both sides equal, returns true)
    != not equal operator (if both sides are not equal, returns true)
    && "and" operator (if both sides true, returns true)
    || "or" operator (if one side true, returns true))
    ! "not" operator (returns the opposite of the value it operates on)
    < "strictly less than" (if left side strictly less, returns true))
    > "strictly greater than" (if left side stricty great than, returns true))
    <= "less than or equal to" (if left side less than or equal to, returns true)
    >= "great than or equal to" (if left side greater than or equal to, returns true))
*/
#endregion

#region "!" operator and "!=" operator

Console.Write("Enter a number: ");
int theNumber = int.Parse(Console.ReadLine());

if(theNumber != 100)
{
    Console.WriteLine("The number is not 100.");
}
else
{
    Console.WriteLine("The number IS 100!!!!!!");
}

bool isBig = true;

if(!isBig)
{
    Console.WriteLine("NOT BIG");
}
else
{
    Console.WriteLine("BIG");
}

#endregion
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
Console.WriteLine();
