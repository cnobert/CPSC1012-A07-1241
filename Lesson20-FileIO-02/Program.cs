
using System.ComponentModel;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        const int ArrayLength = 5;
        string[] studentNames = new string[ArrayLength];
        int[] studentMarks = new int[ArrayLength];

        int logicalSize = 3;
        studentNames[0] = "Conrad Nobert";
        studentNames[1] = "Taylor Fast";
        studentNames[2] = "Brinda Kaur";

        studentMarks[0] = 30;
        studentMarks[1] = 98;
        studentMarks[2] = 70;

        string fileName = "studentData.txt";

        FileWrite(studentNames, studentMarks, logicalSize, fileName);

    }

    static void FileWrite(string[] studentNames, int[] studentMarks, int logicalSize, string fileName)
    {
        StreamWriter writer = null;
        Console.WriteLine("-----Writing to file-----");
        try
        {
            writer = new StreamWriter(fileName);
            writer.WriteLine("Name, Mark");
            for(int c = 0; c < logicalSize; c++)
            {
                writer.WriteLine($"{studentNames[c]}, {studentMarks[c]}");
            }
            writer.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Something went wrong: {e.Message}");
        }
        Console.WriteLine("-----File written!-----");
    }
}

