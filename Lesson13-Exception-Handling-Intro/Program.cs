#region intro text
Console.WriteLine();
Console.WriteLine();
#endregion

#region Class Notes for 2024-10-10
/*
    Quiz - On Thursday, October 17
        pre-condition loop vs post-condition loop
        pre-test loop vs post-test loop
    
    Relational and boolean operators
        relational operators <, >, <=, >=, ==, !=
            they compare two numeric expressions
        boolean operators &&, ||, !
            they operate on boolean operands
        Order of operations
            1.  *, /, %, +, - (follow the math rules)
            2. <, >, <=, >=, ==, != (left to right)
            3. !, &&, || ("!" is evaluated first, then "&&", then "||")

        Examples:
        10 < 10             ------> false
        !(10 < 10)          ------> true
        15 > 5 && 7 == 7    ------> true
        !(20 >= 20)         ------> false
        12 != 12 || 9 <= 10 ------> true
        25 % 5 == 0 && 30 / 6 == 5 ------> true
        !(18 == 18) && 10 < 20 ------> false
        (7 + 3) == 10 || (5 * 5) == 26 ------> true
*/

#endregion

#region exceptions and errors
/*
1.  syntax error
    example: int theNum!ber = 0;
2.  logic error
    example: Write a program that prompts for an int from the user
    and outputs whether or not it is between 16 and 1045
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.Readline());

    //logic error! should be num > 16 && num < 1045
    if(num < 16 && num > 1045)
    {
        //output something
    }
3. Runtime error
    when certain unavoidable situations come up during runtime

*/

// try
// {
//     Console.Write("Enter a number: ");
//     int num = int.Parse(Console.ReadLine());
//     Console.WriteLine($"You successfully entered the number {num}");
// }
// catch(Exception theException)
// {
//     Console.WriteLine("There was an exception, here is the message:");
//     Console.WriteLine(theException.Message);
// }

int userAge = 0;
bool validInput = false;

do
{
    Console.Write("How old are you? Please enter a whole number. ");
    try
    {
        //dangerous code goes here
        userAge = int.Parse(Console.ReadLine());
        validInput = true; //this line of code is only reached if the input is valid
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("Please try again.");
    }
} while(validInput == false); //while (!validInput)



#endregion
#region outro text
Console.WriteLine();
Console.WriteLine();
#endregion
