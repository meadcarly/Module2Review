namespace Module2Review;

public class Course //New class per Bonus instructions
{
    //Two properties
    public string CourseName { get; set; } 
    public string CourseCode { get; set; }

    //Field of type list
    public List<string> EnrolledStudents;

    //Default constructor with the list initialized in the scope
    public Course()
    {
        EnrolledStudents = new List<string>();
    }

    //Method to add students to the course
    public void EnrollStudents(string student)
    {
        EnrolledStudents.Add(student);
    }
}