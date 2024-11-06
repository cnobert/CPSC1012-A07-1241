class Program
{
    static void Main(string[] args)
    {
        #region declare arrays and load test data
        
        const int ArraySize = 30;

        //the following few lines contain test data - you can use this technique in the assignment if you like
        //in this example, logicalSize equals countOfEntries in the assignment
        int logicalSize = 20;

        //20 names
        string[] names = { "Akira", "Beatriz", "Chen", "Dmitri", "Elena", "Fatima", "Giovanni", "Hiroshi", "Isabel", "Javier", "Khaled", "Leila", "Ming", "Nina", "Omar", "Priya", "Ravi", "Sofia", "Tomoko", "Youssef" };

        int[] favouriteNumbers = new int[ArraySize];

        //loads up the favouriteNumbers array with random values between 1 and 500
        Random random = new Random();
        for (int c = 0; c < logicalSize; c++)
        {
            favouriteNumbers[c] = random.Next(1, 500); 
        }
        #endregion
        
        for (int c = 0; c < logicalSize; c++)
        {
            Console.WriteLine($"{names[c]} has favourite number {favouriteNumbers[c]}.");
        }
    }
}