Console.WriteLine();
Console.WriteLine();

#region Question02
// Basic Programming Exercises, Question #2
// this program calculates the number of acres in a tract of land
// const double NumFeetInAcre = 43560; //constants are named using Pascal case (or, "Title" case)

// Console.Write("Enter the number of square feet in the tract of land: ");
// double numSquareFeetProvidedByUser = double.Parse(Console.ReadLine());

// double numAcres = numSquareFeetProvidedByUser / NumFeetInAcre;
// Console.Write("The number of acres in the tract of land is: " + numAcres);

#endregion

#region Question03
//Basic Programming Exercises, Question #3
// A bag of cookies holds 26 cookies. The calorie information on the bag claims that there are 10
// servings in the bag and that each serving equals 175 calories. Write a program that lets the user
// enter the number of cookies he or she actually ate and then reports the number of total calories
// consumed.

const double NumCookiesInBag = 26, NumServingsInBag = 10, NumCaloriesInServing = 175;
const double NumCookiesInServing = NumCookiesInBag / NumServingsInBag;
const double NumCaloriesInCookie = NumCaloriesInServing / NumCookiesInServing;

Console.Write("How many cookies did you eat?");
double cookiesThatTheyAte = double.Parse(Console.ReadLine());
double caloriesThatTheyAte = NumCaloriesInCookie * cookiesThatTheyAte;
Console.WriteLine("You ingested " + caloriesThatTheyAte + " calories.");




#endregion

Console.WriteLine();
Console.WriteLine();