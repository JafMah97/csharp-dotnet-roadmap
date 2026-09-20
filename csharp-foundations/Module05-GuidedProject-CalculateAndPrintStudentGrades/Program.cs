/*

Prepare for guided project
Completed
100 XP
5 minutes
You'll be using the .NET Editor as your code development environment. You'll be writing code that uses string and numeric variables, performs calculations, and displays results to a console.

Project overview
You're developing a Student Grading application that automates the calculation of current grades for each student in a class. The parameters for your application are:

You're given a short list of four students and their five assignment grades.
Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
Final scores are calculated as an average of the five assignment scores.
Your application needs to perform basic math operations to calculate the final grades for each student.
Your application needs to output/display each student’s name and final score.
Currently, the teachers grade book shows the graded assignments for each student as follows:



Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah:   84, 96, 73, 85, 79

Jeong:  90, 92, 98, 100, 97
The teacher requires that the calculated grades for each student are displayed as follows:

Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A

*/

decimal SophiaGrade = (decimal)(93 + 87 + 98 + 95 +  100) / 5;
decimal NicolasGrade = (decimal)(80 + 83 + 82 + 88 +  85) / 5;
decimal ZahirahGrade = (decimal)(84 + 96 + 73 + 85 +  79) / 5;
decimal JeongGjade = (decimal)(90 + 92 + 98 + 100 + 97) / 5;
Console.WriteLine("Student\t\tGrade");
Console.WriteLine($"Sophia\t\t{SophiaGrade}\tA");
Console.WriteLine($"Nicolas\t\t{NicolasGrade}\tB");
Console.WriteLine($"Zahirah\t\t{ZahirahGrade}\tB");
Console.WriteLine($"Jeong\t\t{JeongGjade}\tA");