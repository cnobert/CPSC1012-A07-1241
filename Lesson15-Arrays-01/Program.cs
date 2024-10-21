Console.WriteLine("\n\n\n\n\n\n");

//declare and instantiate an array of 5 integers.
int[] ages;
ages = new int[5]; //the "new" keyword allocates memory
ages[0] = 11;
ages[1] = 32;
ages[2] = 55;
ages[3] = 90;
ages[4] = 1;

// Console.WriteLine($"The first person in the array is {ages[0]} years old.");

// for(int c = 0; c < ages.Length; c++)
// {
//     Console.WriteLine($"The person in the {c} slot of the array is {ages[c]} years old.");
// }

//exercise: print the values of the array from the 4th slot to the 0th slot
// for(int c = ages.Length - 1; c >= 0; c--)
// {
//     Console.WriteLine($"The person in the {c} slot of the array is {ages[c]} years old.");
// }

double[] marks = new double[5];
marks[0] = 79.2;
marks[1] = 84.5;
marks[2] = 65;
marks[3] = 91;
marks[4] = 74;

//exercise: calculate the average of the marks in the array
// double sumOfMarks = 0;
// for(int c = 0; c < marks.Length; c++)
// {   
//     sumOfMarks += marks[c];
// }
// Console.WriteLine($"The average of the marks is {sumOfMarks/marks.Length}");

//exercise: print out the biggest mark in the array 
double biggestMark = 0;
// for(int c = 0; c < marks.Length; c++)
// {
//     if(marks[c] > biggestMark)
//     {
//         biggestMark = marks[c];
//     }
// }
Array.Sort(marks); //Array.Clear(marks)
//if marks.Length is bigger than 0, we know the array is not empty
if(marks.Length > 0)
{
    biggestMark = marks[marks.Length - 1];
}
Console.WriteLine($"The biggest mark in the array is {biggestMark}");