using System;
using System.Collections.Generic;

namespace _hometask_Class;
 public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int[] HomeworkGrades { get; set; }
    public int[] ProjectGrades { get; set; }
    public int[] QuizGrades { get; set; }
    public int FinalGrade { get; set; }
    public bool[] Continuity { get; set; }

    public string GetStudentStatus()
    {
        double totalGrade = HomeworkGrades.Average() * 0.2 + ProjectGrades.Average() * 0.2 + QuizGrades.Average() * 0.2 + FinalGrade * 0.3 + (Continuity.Count(c => c) / (double)Continuity.Length) * 10;

        if (totalGrade >= 95)
            return "HighHonour";
        else if (totalGrade >= 85)
            return "Honour";
        else if (totalGrade >= 65)
            return "Normal";
        else
            return "Fail";
    }
}

