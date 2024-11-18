class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

        // string[] studentNames = new string[100];
        // int[] mathMarks = new int[100];
        // int[] englishMark = new int[100];
        // int[] scienceMark = new int[100];

        Student[] students = new Student[100];

    }
}
class Student 
{
    //"private" means that nothing outside of the class can access
    //these data members directly
    private string _name;
    private int _mathMark;

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
            _mathMark = value;
        }
   }
}