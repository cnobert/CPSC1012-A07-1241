class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    #region method signatures and overloading 
        // Console.WriteLine($"10.2 plus 20.9 equals {AddTogether(10.2, 20.8):n}");
        // Console.WriteLine($"10.2 plus 20.9 plus 10000 equals {AddTogether(10.2, 20.8, 10000):n}");
        // Console.WriteLine($"1 + 2 equals {AddTogether(1, 2)}");
    #endregion

    #region pass by value and pass by reference

    // double n01 = 10, n02 = 100;
    // Console.WriteLine($"The answer is {Multiply(n01, n02)}");
    // Console.WriteLine($"n01 is {n01}");

    // double[] numbers = new double[2];
    // numbers[0] = 10.3;
    // numbers[1] = 20;
    // Console.WriteLine($"The answer is: {MultiplyArrayValues(numbers)}");
    // Console.WriteLine($"numbers[0] = {numbers[0]} and numbers[1] = {numbers[1]}");
    #endregion
   
    #region Question 1, Method Problems 1

        PrintMenu();
        Console.Write("How old are you? ");
        double age = GetDoubleAboveZero();
        Console.WriteLine($"The admission price for you is {GetTicketPrice(age):c}");

    #endregion

    }
    static double GetTicketPrice(double age)
    {
        //do the logic for getting a ticket price
        double price = 10;;
        if(age <= 6)
        {
            price = 0;
        }
        else if(age < 18)
        {
            price = 9.80;
        }
        else if(age < 55)
        {
            price = 11.35;
        }
        return price;
    }
    static void PrintMenu()
    {
        Console.WriteLine("Children 6 and under = FREE ($0.00)\n" +
                        "Students 7 to 17 = $9.80\n" +
                        "Adults 18 to 54 = $11.35\n" +
                        "Seniors 55+ = $10.0");
    }
    static int GetIntAboveZero()
    {
        return (int) GetDoubleAboveZero();
    }
    static double GetDoubleAboveZero()
    {
        double investment = -1;
        do
        {
            try
            {
                Console.Write("Enter a number greater than zero: ");
                investment = double.Parse(Console.ReadLine());
                if (investment <= 0)
                {
                    //they entered a valid number, but it's not greater than 0
                    Console.Write("Please enter a number greater than zero. Try again: ");
                }
            }
            catch
            {
                Console.Write("Please enter a valid number. Try again: ");
            }
        }
        while (investment <= 0);
        return investment;
    }
    //assumes an array of exactly two values
    static double MultiplyArrayValues(double[] theNumbers)
    {
        double theProduct = 0;
        theNumbers[0] = 1;
        theNumbers[1] = 2;
        theProduct = theNumbers[0] * theNumbers[1];
        return theProduct;
    }
    static double Multiply(double n01, double n02)
    {
        n01 = 234987234;
        return n01 * n02;
    }
    


    static double AddTogether(double n01, double n02)
    {
        return n01 + n02;
    }
    static double AddTogether(double n01, double n02, double n03)
    {
        return n01 + n02 + n03;
    }
    static int AddTogether(int n01, int n02)
    {
        return n01 + n02;
    }
}