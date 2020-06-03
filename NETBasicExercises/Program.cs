using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aobj = new Person();
            aobj.FirstName = "Abhishek";
            aobj.LastName = "Sharma";
            aobj.Discriminator = "Student";
            aobj.Print();

            Person bobj = new Person();
            bobj.FirstName = "Kundan";
            bobj.LastName = "Sharma";
            bobj.Discriminator = "Instructor";
            bobj.Print();

            Course cou = new Course();
            cou.Print();
            Technology tec = new Technology();
            tec.Print();

            List<Person> personList = new List<Person>();
            personList.Add(new Person() { FirstName = "Abhishek", LastName = "Sharma", Discriminator = "Student" });
            personList.Add(new Person() { FirstName = "Kundan", LastName = "Sharma", Discriminator = "Instructor" });
            personList.Add(new Person() { FirstName = "Sai", LastName = "Sharma", Discriminator = "Student" });

            var InstructorCount = personList.Where(a => a.Discriminator == "Instructor").Count();
            var StudentCount = personList.Where(a => a.Discriminator == "Student").Count();

            Console.WriteLine("Instructor count {0}", InstructorCount);
            Console.WriteLine("Student count {0}", StudentCount);

            List<Course> courseList = new List<Course>();

            courseList.Add(new Course() { Title = "Asp.net", Credits = 7, Technology = "WebTech" });
            courseList.Add(new Course() { Title = "Spring", Credits = 4, Technology = "Java Framework" });
            courseList.Add(new Course() { Title = "Asp.net MVC", Credits = 2, Technology = "WebTech" });

            List<string> technologies = new List<string>();
            var Technologies = courseList.GroupBy(d => d.Technology);
            foreach (var item in Technologies)
            {
                Console.WriteLine(item.Key);
            }

            var creditCount = courseList.GroupBy(d => d.Technology).Select(f => new
            { Credits = f.Sum(ta => ta.Credits), Technology = f.Key }).ToList();

            creditCount.ForEach(row => Console.WriteLine($"Technology: {row.Technology}, Credits: {row.Credits}"));

            Console.ReadKey();
        
            Person cobj = new Person();
            cobj.FirstName = "Abhi";
            cobj.LastName = "Sharma";
            cobj.Discriminator = "Student";
            cobj.Print();
            Console.ReadKey();
        }
    }
}
