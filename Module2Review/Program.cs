// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
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

//Add grades to each AddGrade Methods
kelly.AddGrade(86.2);
kelly.AddGrade(88, 91.1, 93);

josh.AddGrade(90.1);
josh.AddGrade(94.5, 88, 89);

max.AddGrade(92);
max.AddGrade(92.3, 84, 90);

em.AddGrade(89);
em.AddGrade(93, 95.5, 94);

//Loop through to show each student info.
foreach (var student in students)
{
    Console.WriteLine($"Student Name: {student.Name}\nStudent ID: {student.Id}\nAverage: {student.CalculateAverageGrade()}\n{student.Name}'s individual grades:");
    foreach (double grade in student.Grades)
    {
        Console.WriteLine(grade);
    }
}
//Create a course and set values to the properties
var csharp = new Course(); 
csharp.CourseName = "CSharp";
csharp.CourseCode = "123CSharp";

//Add two students to the course
csharp.EnrollStudents("em");
csharp.EnrollStudents("josh");

//Display the course info and students enrolled in it.
Console.WriteLine($"Course Name: {csharp.CourseName}\nCourse Code: {csharp.CourseCode}\nStudents enrolled:");
foreach(var participant in csharp.EnrolledStudents)
{
    Console.WriteLine(participant);
}