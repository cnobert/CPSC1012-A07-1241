class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

        Student s01 = new Student("Jimmy McNulty", 81, 79);
        Student s02 = new Student("Avon Barksdale", 88, 91);
        Student s03 = new Student("Stringer Bell", 99, 98);

        s01.Print();
        s02.Print();
        s03.Print();

        Student.PrintDescription();
    }
}
class Student 
{
    //"private" means that nothing outside of the class can access
    //these data members directly
    private string _name; //these are called "fields" or "data members" or "member variables"
    private int _mathMark;
    private int _scienceMark;

    //the "setters" and "getters" are accessed via properties
    public string Name
    {
        get 
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
   
    public int MathMark
    {
        get
        {
            return _mathMark;
        }
        set
        {
            if(value < 0 || value > 100)
            {
                throw new Exception("The mark must be between 0 and 100.");
            }
            _mathMark = value;
        }
    }

    public int ScienceMark
    {
        get
        {
            return _scienceMark;
        }
        set
        {
            if(value < 0 || value > 100)
            {
                throw new Exception("The mark must be between 0 and 100.");
            }
            _scienceMark = value;
        }
    }

    //a constructor "constructs" an object
    //it doesn't have a return type, because it is assumed that it returns an object of the class
    //a constructor has the same name as the class
    //this constructor is a "greedy" constructor
    //a "greedy" constructor is a constructor that has a parameter 
    //for each and every property/field in the class/object.
    public Student(string name, int mathMark, int scienceMark)
    {
        Name = name;
        MathMark = mathMark;
        ScienceMark = scienceMark;
    }

    //instance method
    public void Print()
    {
        //in a method that is inside of a class, the other class methods and data members
        //are in scope
        Console.WriteLine($"{Name} got {MathMark} in math and {ScienceMark} in science.");
    }
    //class method - every instance/object shares this method
    public static void PrintDescription()
    {
        Console.WriteLine("The student class stores data about NAIT students.");
    }
}