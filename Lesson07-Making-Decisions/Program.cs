Console.WriteLine("<----------------------->");

#region first "if" statement
// bool isBig = true;

// //in the parentheses we put a Boolean expression, which is
// //an expression that evaluates to true or false
// if(isBig == true)
// {
//     Console.WriteLine("It is BIG!");
// }
// else
// {
//     Console.WriteLine("It is NOT big");
// }

#endregion

#region nested "if" statement

bool hasMoney = false;
bool isHungry = true;

if(isHungry == true)
{
    if(hasMoney == true)
    {
        Console.WriteLine("I'm buying myself a burger!");
    }
    else
    {
        Console.WriteLine("I am hungry but I have no money.");
        Console.WriteLine("No burger for me.");
    }
}
else
{
    Console.WriteLine("I'm not hungry, so it's all good that I have no money.");
}
//exercise: run the above code three times, each time changing the variables so that
//a different message is written to the console
#endregion

#region "if" statement with compound boolean expression

#endregion
Console.WriteLine("<----------------------->");