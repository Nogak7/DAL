
using DAL.Models1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BL
{
    public static class Helper
    {
        public static bool IsStudentExist(string name)
        {
            using (var db = new HighSchoolContext()) 
            {
                if( (db.Students.Where(x => x.Name == name).FirstOrDefault()) != null) 
                    return true;
                return false;
            }
        }
        public static int GetIdByStudentName(string name)
        {
            using (var db = new HighSchoolContext())
            {
                Student s = db.Students.Where(x => x.Name == name).FirstOrDefault();
                int id = s.Id;
                return id;
            }

        }
    }
}
