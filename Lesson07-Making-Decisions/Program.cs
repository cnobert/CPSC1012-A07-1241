Console.WriteLine("<----------------------->");

#region first "if" statement

// bool isBig = true;

// //in the parentheses we put a Boolean expression, which is
// //an expression that evaluates to true or false
// if(isBig)
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
// else
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
// exercise: run the above code four times, each time changing the variables so that
// a different message is written to the console
#endregion

#region "if" statement with compound boolean expression

// bool hasMoney = true;
// bool isHungry = false;

// //hasMoney == true, isHungry == true
// if(hasMoney && isHungry)
// {
//     Console.WriteLine("I'm buying myself a burger!");
// }
// //hasMoney == true, isHungry = false
// else if(hasMoney && !isHungry)
// {
//     Console.WriteLine("I have money, but I'm not hungry.");
// }
// //hasMoney == false, isHungry == true
// else if(!hasMoney && isHungry)
// {
//     Console.WriteLine("I am hungry but I have no money.");
//     Console.WriteLine("No burger for me.");
// }
// else if(!hasMoney && !isHungry)
// {
//     Console.WriteLine("I'm not hungry, so it's all good that I have no money.");
// }
//exercise: run the above code four times, each time changing the variables so that
//a different message is written to the console
#endregion

#region Question 01, Decision Making Exercises 02 doc

//https://lms.nait.ca/d2l/le/content/25527/viewContent/1173615/View
//Write a program that will prompt for a number and display “positive” if it is 
//greater than zero,
//“negative” if it is less than zero, and “zero” if it is equal to zero
Console.Write("Enter a whole number: ");
int theAnswer = int.Parse(Console.ReadLine());

if(theAnswer > 0)
{
    Console.WriteLine("positive");
}
else if (theAnswer < 0)
{
    Console.WriteLine("negative");
}
else // if(theAnswer == 0)
{
    Console.WriteLine("zero");
}
#endregion

#region notes on boolean operators
/*
    == equality operator (if both sides equal, returns true)
    != does not equal
    && "and" operator (if both sides true, returns true)
    || "or" operator (if one side true, returns true))
    ! "not" operator (returns the opposite of the value it operates on)
    < "strictly less than" (if left side strictly less, returns true))
    > "strictly greater than" (if left side stricty great than, returns true))
    <= "less than or equal to" (if left side less than or equal to, returns true)
    >= "great than or equal to" (if left side greater than or equal to, returns true))
*/
#endregion
Console.WriteLine("<----------------------->");