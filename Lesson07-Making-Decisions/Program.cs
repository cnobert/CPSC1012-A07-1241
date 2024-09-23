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

// bool hasMoney = false;
// bool isHungry = false;

// if(isHungry == true)
// {
//     if(hasMoney == true)
//     {
//         Console.WriteLine("I'm buying myself a burger!");
//     }
//     else
//     {
//         Console.WriteLine("I am hungry but I have no money.");
//         Console.WriteLine("No burger for me.");
//     }
// }
// // else
// {
//     if(hasMoney == false)
//     {
//         Console.WriteLine("I'm not hungry, so it's all good that I have no money.");
//     }
//     else
//     {
//         Console.WriteLine("I have money, but I'm not hungry.");
//     }
// }
//exercise: run the above code three times, each time changing the variables so that
//a different message is written to the console
#endregion

#region "if" statement with compound boolean expression

bool hasMoney = false;
bool isHungry = false;

//hasMoney == true, isHungery == true
if(hasMoney && isHungry)
{
    Console.WriteLine("I'm buying myself a burger!");
}
//hasMoney == true, isHungry = false
else if(hasMoney && !isHungry)
{
    Console.WriteLine("I have money, but I'm not hungry.");
}
//hasMoney == false, isHungry == true
else if(!hasMoney && isHungry)
{
    Console.WriteLine("I am hungry but I have no money.");
    Console.WriteLine("No burger for me.");
}
else if(!hasMoney && !isHungry)
{
    Console.WriteLine("I'm not hungry, so it's all good that I have no money.");
}

#endregion
Console.WriteLine("<----------------------->");