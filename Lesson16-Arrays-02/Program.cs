Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

const int NumStudents = 5;

string[] studentNames; //declares a variable that can refer to a string array, but doesn't quite yet
studentNames = new string[NumStudents]; //instantiates (creates) a string array, and makes studentNames refer to it

int[] studentMathGrades = new int[NumStudents];


char continueYN = 'n';
int studentCounter = 0;
do
{
    Console.Write($"Enter the name for student {studentCounter + 1} ");
    studentNames[studentCounter] = Console.ReadLine();

    bool inputIsValid = false;
    do
    {
        try
        {
            Console.Write($"Enter the math grade for {studentNames[studentCounter]} ");
            studentMathGrades[studentCounter] = int.Parse(Console.ReadLine());
            if(studentMathGrades[studentCounter] >= 0 && studentMathGrades[studentCounter] <= 100)
            {
                inputIsValid = true;
            }
            else
            {
                Console.WriteLine("The grade you entered is not between 0 and 100. Try again.");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("The grade you entered is not a number. Try again.");
        }
    } while(!inputIsValid);

    do
    {
        Console.Write("Would you like to add more student data?" );
        continueYN = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
    } while(continueYN != 'n' && continueYN != 'y');
    //they want to continue, so increment the counter and check for potential out of bounds
    if(continueYN == 'y')
    {
        studentCounter++;
        if(studentCounter >= studentNames.Length)
        {
            continueYN = 'n';
            Console.WriteLine("You have entered the maximum number of students. Thank you.");
        }
    }
} while(continueYN != 'n');

Console.WriteLine("You entered the following data:");
for(int c = 0; c < studentNames.Length; c++)
{
    Console.WriteLine($"{c + 1}. {studentNames[c]} got {studentMathGrades[c]} in math.");
}

Console.Write($"Which student's info would you like to view? "
                + $"Enter a number between 1 and {studentNames.Length}: ");
//TODO: add a loop that checks for invalid input
int studentIndex = int.Parse(Console.ReadLine());
studentIndex--;
if(studentIndex >= 0 && studentIndex < studentNames.Length)
{
    Console.WriteLine($"{studentIndex + 1}. {studentNames[studentIndex]} "
                        + $"got {studentMathGrades[studentIndex]} in math.");
}