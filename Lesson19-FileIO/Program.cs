class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        
        string fileName = "numbers.txt";

        StreamWriter writer;
        try
        {
            writer = new StreamWriter(fileName);
            for(int c = 0; c < 5; c++)
            {
                writer.WriteLine(c + 1);
            }
            writer.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Something went wrong: {e.Message}");
        }

        StreamReader reader;
        
    }
}