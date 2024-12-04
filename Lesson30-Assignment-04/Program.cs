﻿//Conrad Nobert - Assignment 04 - Fall 2024
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        string firstName = PromptString("Please enter first name: ");
        string lastName = PromptString("Please enter last name: ");
        int orderCount = PromptInt("Please enter # of orders:");
        double totalSales = PromptDouble("Please enter total value of orders, in $:");
        Customer c01 = new Customer(firstName, lastName, orderCount, totalSales);
    }

    #region prompt methods
    static string PromptString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
    
    static int PromptInt(string prompt)
    {
        int theInt = 0;
        bool validInt = false;
        do
        {
            try
            {
                Console.Write(prompt);
                theInt = int.Parse(Console.ReadLine());
                validInt = true;
            }
            catch
            {
                Console.Write("Please enter a valid number. Try again: ");
            }
        }
        while (!validInt);

        return theInt;
    }
    static double PromptDouble(string prompt)
    {
        double theDouble = 0;
        bool validDouble = false;
        do
        {
            try
            {
                Console.Write(prompt);
                theDouble = double.Parse(Console.ReadLine());
                validDouble = true;
            }
            catch
            {
                Console.Write("Please enter a valid number. Try again: ");
            }
        }
        while (!validDouble);
        
        return theDouble;
    }
    #endregion
}
class Customer
{
    #region fields
    private string _firstName;
    private string _lastName;
    private int _orderCount;
    private double _totalSales;
    #endregion

    #region properties
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new Exception("First name cannot be empty.");
            }
            _firstName = value.Trim();
        }
    }
    public string LastName
    {
        get 
        { 
            return _lastName; 
        }
        set 
        { 
            //data validation goes here
            _lastName = value; 
        }
    }

    public int OrderCount
    {
        get 
        { 
            return _orderCount; 
        }
        set 
        { 
            _orderCount = value; 
        }
    }

    public double TotalSales
    {
        get 
        { 
            return _totalSales; 
        }
        set 
        { 
            _totalSales = value; 
        }
    }
    
    //TODO: write the AverageOrder property -it's read only, it returns the average order
    //and it does not blow up if there are zero orders
    public double AverageOrder
    {
        get
        {
            return 1.0;//placeholder code
        }
    }
    
    public string CustomerTier
    {
        get
        {
            //the "if" statement that determines "Bronze", "Silver", or "Gold"
            //only one return
            return "placeholder";
        }
    }

    #endregion
    
    #region methods
    public Customer(string firstName, string lastName, int orderCount, double totalSales)
    {
        //assign each of the four parameters to the fields, using the properties
    }


    #endregion

}