class Program
{
    static void Main(string[] args)
    {

        Student s01 = new Student("Jimmy McNulty", 81, 79);
        Student s02 = new Student("Avon Barksdale", 88, 91);
        Student s03 = new Student("Stringer Bell", 99, 98);

        List<Student> students = new List<Student>();
        students.Add(s01);
        students[0].Print();
        s01.MathMark = 99;
        students[0].Print();
        Console.WriteLine("---------");
        students.Add(s02);
        students.Add(s03);
        students.Add(new Student("Kima Gregs", 51, 98));
        foreach(Student s in students)
        {
            s.Print();
        }
        students.Remove(s01);
        students.Remove(s03);
        //students.RemoveAt()
        //students.RemoveAt(0); removes the instance that is at index zero in the list
        Console.WriteLine("---------");
        foreach(Student s in students)
        {
            s.Print();
        }
        
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

    public double AverageMark
    {
        //this property is read-only, so there is no "setter"
        get
        {
            return (MathMark + ScienceMark) / 2;
        }
    }

    public string StudentRanking
    {
        get
        {
            string ranking = "Failing";
            if(AverageMark >= 90)
            {
                ranking = "Honours with distinction";
            }
            else if(AverageMark >= 80)
            {
                ranking = "Honours";
            }
            else if(AverageMark >= 50)
            {
                ranking = "Passing";
            }
            return ranking;
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