using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models1
{
    public partial class HighSchoolContext : DbContext
    {
        public void AddStudent(Student student)
        {
            using (var db = new HighSchoolContext())
            {
                db.Students.Add(student);
                db.SaveChanges(); 
            }
                
        }
    }
}
