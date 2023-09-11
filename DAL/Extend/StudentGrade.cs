using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models1
{
    public partial class StudentGrade
    {
        public  void AddScoreToAStudent(int studentId , int score)
        {
            using (var db = new HighSchoolContext())
            {
                db.StudentGrades.Add(new StudentGrade() { Score = score, StudentId = studentId });
                db.SaveChanges();
            }
        }
    }
}
