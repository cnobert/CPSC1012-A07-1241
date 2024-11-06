using System.Globalization;

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

        //algorithm to find the max number in this array
        int maxFavouriteNumber = favouriteNumbers[0];
        for(int c = 0; c < logicalSize; c++)
        {
            if(favouriteNumbers[c] > maxFavouriteNumber)
            {
                maxFavouriteNumber = favouriteNumbers[c];
            }
        }
        Console.WriteLine($"The max number in the favouriteNumbers array is {maxFavouriteNumber}");

        //let's find a number, rounded up to the nearest 10
        int closest10AboveMaxFavouriteNumber = (int)Math.Ceiling(maxFavouriteNumber / 10.0) * 10;
        Console.WriteLine($"The max number, rounded to the nearest 10, is {closest10AboveMaxFavouriteNumber}");
        
        //now we output the chart
        for(int outer = closest10AboveMaxFavouriteNumber; outer >= 0; outer -= 10)
        {
            //the outer loop outputs the rows
            Console.Write(outer + "\t");
            //now loop through the array and check if there is a number that belongs on this row
            for(int inner =- 0; inner < logicalSize; inner++)
            {
                int num = favouriteNumbers[inner];
                if(num > outer - 10 && num <= outer)
                {
                    Console.Write(num);
                }
                else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
        for(int c = 0; c < logicalSize; c++)
        {
            Console.Write("-----");
        }
        Console.Write("\n\t");
        for(int c = 0; c < logicalSize; c++)
        {
            Console.Write(names[c] + "\t");
        }

    }
}