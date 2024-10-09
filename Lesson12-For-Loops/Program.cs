#region intro text
Console.WriteLine();
Console.WriteLine();
#endregion

#region review

// int count = 0;
// while(count < 10)
// {
//     Console.Write(count++ + " "); //count++ is the same as count = count + 1;
//     //++count first increases the variable by 1, then uses the new (increased) value
//     //count++ uses the value, and only then does it increase the value of the variable by 1
// }
// Console.WriteLine();
// //used in menus, and not many other places
// char answerYN = 'n';
// string city;
// do
// {
//     Console.WriteLine();
//     Console.Write("What city do you live in? ");
//     city = Console.ReadLine();
//     //this could be a calculation or more questions
//     if(city == "Edmonton" || city.Equals("Winnipeg"))
//     {
//         Console.WriteLine("Enjoy the winter!");
//     }
//     else
//     {
//         Console.WriteLine("Sounds warm.");
//     }
//     Console.Write("Would you like to continue? [y/n] ");
//     answerYN = char.ToLower(Console.ReadKey().KeyChar);
// }while(answerYN != 'n');
#endregion

#region for loops
//everything you can do with a "for" loop, 
//you can do with a "while" loop
/*
    for(initialize variable; condition; increment)
    {
        //do stuff
    }
*/
// for(int c = 0; c < 10; c++)
// {
//     Console.Write(c + " ");
// }

//exercise: write a "for" loop that outputs the numbers 
//from 103 down to 4
// for(int c = 103; c >= 4; c--)
// {
//     Console.Write(c + " ");
// }

//exercise: Display the characters
//prompt the user for a string, and then print it out vertically
//"Oilers"
//  "O   i   l   e   r   s"
//  [0]  [1] [2] [3] [4] [5]
//O
//i
//l
//e
//r
//s
Console.Write("Enter a string: ");
string theString = Console.ReadLine();
//try changing the below to c <= theString.Length
//and ask yourself why it throws an ArrayIndexOutOfBounds Exception
for(int c = 0; c < theString.Length; c++)
{
    Console.WriteLine(theString[c]);
}



#endregion

#region outro text
Console.WriteLine();
Console.WriteLine();
#endregion
