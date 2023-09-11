using DAL.BL;

using DAL.Models;
using DAL.Models1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Threading.Channels;

namespace DAL
{
    public class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player()
            {
                BirthYear = 2006,
                Name = "NK",
               
            };

            using (var db = new HighScoresContext())
            {


                /*  db.Players.Add(player);
                  db.SaveChanges();

                  foreach(Game game in db.Games) 
                  {
                      Console.WriteLine($"{game.Name} - {game.GameId}");
                  }*/

                //foreach (HighScore highScore in db.HighScores)
                //{
                //    HighScore hs = db.HighScores.Include(x => x.Player).Include(x => x.Game).FirstOrDefault();
                //    Console.WriteLine(hs.Player.Name);
                //}
            }
           
            {
                Console.WriteLine( " pick one of the following option:" );
                Console.WriteLine( "to add student press \"1\" ");
                Console.WriteLine("to add grade for a student student press \"2\" ");
                Console.WriteLine("to search a student by his Id press \"3\" ");
                Console.WriteLine("to see the student's geades and his average press \"4\" ");
                Console.WriteLine("to see the best student with the hightest average press \"5\" ");
                int choice = int.Parse(Console.ReadLine()); 
                while(choice<1 || choice>5 )
                {
                    Console.WriteLine( "please enter a valid number");
                     choice = int.Parse(Console.ReadLine());
                }

                switch( choice )
                {
                    case 1:
                    {
                        Console.WriteLine("enter the new student name");
                        string name = Console.ReadLine();
                        while(!(name==null && (name[0] >= 'a' && name[0]<='z')))
                        {
                                Console.WriteLine("please enter a valid name");
                                name = Console.ReadLine();
                        }
                        Student s = new Student()
                        {
                           Name = name,
                        };
                            HighSchoolContext hsc = new HighSchoolContext();
                            hsc.AddStudent(s);

                    } break;
                    case 2:
                    {
                            Console.WriteLine(" enter student name");
                            string name = Console.ReadLine();
                            while (!(name == null && (name[0] >= 'a' && name[0] <= 'z')))
                            {
                                Console.WriteLine("please enter a valid name");
                                name = Console.ReadLine();
                            }
                            while (!(Helper.IsStudentExist(name)))
                            {
                                Console.WriteLine("this student doesn't exsist please try again");
                                name = Console.ReadLine();
                            }

                            int id = Helper.GetIdByStudentName(name);

                            Console.WriteLine( " enter the score you want to add to your student");
                            int score;
                            while (!(int.TryParse(Console.ReadLine(), out score)))
                            {
                                Console.WriteLine("enter a valid score");
                                score = int.Parse(Console.ReadLine());


                                while (score > 100 && score < 1)
                                {
                                    Console.WriteLine(" please enter a score between 1-100");
                                    score = int.Parse(Console.ReadLine());
                                }
                            }
                            StudentGrade sg = new StudentGrade();
                            sg.AddScoreToAStudent(id, score);

                    }
                        break;
                        
                }
            }
           
        }
    }
}