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



Student.CalculateAverageGrade();