Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");

const double BaseCostA = 9.95;
const double BaseCostB = 13.95;
const double BaseCostC = 19.95;
const double HourlyA = 2.00;
const double HourlyB = 1.00;
const int ThresholdA = 10;
const int ThresholdB = 20;


char continueYN = 'n';
char internetPackage;
double totalCost = 0;
do
{
    do //only exit loop if they enter correct input ('A', 'B', or 'C')
    {
        Console.Write("\nEnter the package letter (A, B, or C): ");
        internetPackage = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
    } while(internetPackage != 'A' && internetPackage != 'B' && internetPackage != 'C');

    int hoursUsed = 0;
    bool validInput = false;
    switch(internetPackage)
    {
        case 'A':
            do
            {
                try
                {
                    Console.Write("You selected Package A.\nEnter the hours used: ");
                    hoursUsed = int.Parse(Console.ReadLine());
                    validInput = true; //if we've reached this line, we know the number was valid
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Oops, {e.Message}, try again!");
                }
            } while(validInput != true);

            if(hoursUsed > ThresholdA)//if more than 10 hours
            {
                //this: (hoursUsed - ThresholdA) gives us the number of hourse above 10 that they've used
                totalCost = (hoursUsed - ThresholdA) * HourlyA + BaseCostA;
            }
            else
            {
                totalCost = BaseCostA;
            }
            break;
        case 'B':
            do
            {
                try
                {
                    Console.Write("You selected Package B.\nEnter the hours used: ");
                    hoursUsed = int.Parse(Console.ReadLine());
                    validInput = true; //if we've reached this line, we know the number was valid
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Oops, {e.Message}, try again!");
                }
            } while(validInput != true);

            if(hoursUsed > ThresholdB)
            {
                totalCost = (hoursUsed - ThresholdB) * HourlyB + BaseCostB;
            }
            else
            {
                totalCost = BaseCostB;
            }
            break;
        case 'C':
            totalCost = BaseCostC;
            break;
        default:
            break;
    }
    Console.WriteLine($"The total cost of the package is: {totalCost:c}");
    do
    {    
        Console.Write("\nWould you like to try again? [y/n]");
        //continueYN = char.ToLower(Console.Readeline()[0]);
        continueYN = char.ToLower(Console.ReadKey().KeyChar);
    } while(continueYN != 'y' && continueYN != 'n');
} while(continueYN != 'n');

Random rando = new Random();
double min = 1.1;
double max = 1.7;
double theNumber = min + rando.NextDouble() * (max - min);
Console.WriteLine($"Here's a random number between {min} and {max}: {theNumber:n}");

Console.WriteLine("\n\nThank you, and good bye!\n\n");