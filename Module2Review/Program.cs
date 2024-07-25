// See https://aka.ms/new-console-template for more information

using Module2Review;

List<Student> students = new List<Student>(); //Created a list of students

//Created 4 instances of students with dot notation
var kelly = new Student();
kelly.Name = "Kelly";
kelly.Id = 001;

var josh = new Student();
josh.Name = "Josh";
josh.Id = 002;

var max = new Student();
max.Name = "Max";
max.Id = 003;

var em = new Student();
em.Name = "Em";
em.Id = 004;

//Populate the list with instances
students.Add(kelly);
students.Add(josh);
students.Add(max);
students.Add(em);

kelly.AddGrade(86.2);
kelly.AddGrade(88, 91.1, 93);

josh.AddGrade(90.1);
josh.AddGrade(94.5, 88, 89);

max.AddGrade(92);
max.AddGrade(92.3, 84, 90);

em.AddGrade(89);
em.AddGrade(93, 95.5, 94);

foreach (var student in students)
{
    Console.WriteLine($"Student Name: {student.Name}\nStudent ID: {student.Id}\nAverage: {student.CalculateAverageGrade()}\n{student.Name}'s individual grades:");
    foreach (double grade in student.Grades)
    {
        Console.WriteLine(grade);
    }
}
