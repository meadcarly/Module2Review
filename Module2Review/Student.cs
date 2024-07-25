namespace Module2Review;

public class Student //Created a Student class with properties, initialized the list for Grades.
{
    public string Name { get; set; }
    public int Id { get; set; }
    public static List<double> Grades { get; set; } = new List<double>(); //changed to static because the methods must be static according to the instructions, and the method must access the list.

    public static void AddGrade(double grade) //Method to add a grade to the student
    {
        Grades.Add(grade);
    }

    public static void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }
    
    
}