namespace Module2Review;

public class Student //Created a Student class with properties, initialized the list for Grades.
{
    public string Name { get; set; }
    public int Id { get; set; }
    public List<double> Grades { get; set; } = new List<double>(); 
    
    

    public void AddGrade(double grade) //Method to add a grade to the student
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades) //Method to add a grades array
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        double sum = 0;
        double averageGrade = 0;
        if (Grades.Count != 0)
        {
            foreach (var grade in Grades)
            {
                sum += grade;
            }

            averageGrade = sum / Grades.Count;
        }
        else
        { 
            averageGrade += 0;
        }
        
        return averageGrade;
    }
    
}