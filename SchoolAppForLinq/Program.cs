using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppForLinq
{
    class Program
    {
        static List<Students> students = new List<Students>();
        static List<Subjects> subjects = new List<Subjects>();
        static List<Marks> marks = new List<Marks>();
        static void Main(string[] args)
        {
            Seed();
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("The Total Count of Students:");
            var TotalCountOfStudents = students.Count();
            Console.WriteLine(TotalCountOfStudents);
            Console.WriteLine("The Total Count of Subjects:");
            var TotalCountOfSubjects = subjects.Count();
            Console.WriteLine(TotalCountOfSubjects);
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("The Maximum , Minimum and Average Marks in Maths");
            var MaxMaths = marks.Max(m=> m.Maths);
            Console.WriteLine(MaxMaths);
            var MinMaths = marks.Min(m => m.Maths);
            Console.WriteLine(MinMaths);
            var AvgMaths = marks.Average(m => m.Maths);
            Console.WriteLine(AvgMaths);
            Console.WriteLine("The Maximum , Minimum and Average Marks in Social");
            var MaxSocial = marks.Max(m => m.Social);
            Console.WriteLine(MaxSocial);
            var MinSocial = marks.Min(m => m.Social);
            Console.WriteLine(MinSocial);
            var AvgSocial = marks.Average(m => m.Social);
            Console.WriteLine(AvgSocial);
            Console.WriteLine("The Maximum , Minimum and Average Marks in Science");
            var MaxScience = marks.Max(m => m.Science);
            Console.WriteLine(MaxScience);
            var MinScience = marks.Min(m => m.Science);
            Console.WriteLine(MinScience);
            var AvgScience = marks.Average(m => m.Science);
            Console.WriteLine(AvgScience);
            Console.WriteLine("The Maximum , Minimum and Average Marks in English");
            var MaxEnglish = marks.Max(m => m.English);
            Console.WriteLine(MaxEnglish);
            var MinEnglish = marks.Min(m => m.English);
            Console.WriteLine(MinEnglish);
            var AvgEnglish = marks.Average(m => m.English);
            Console.WriteLine(AvgEnglish);
            Console.WriteLine("The Maximum , Minimum and Average Marks in Computers");
            var MaxComputers = marks.Max(m => m.Computers);
            Console.WriteLine(MaxComputers);
            var MinComputers = marks.Min(m => m.Computers);
            Console.WriteLine(MinComputers);
            var AvgComputers = marks.Average(m => m.Computers);
            Console.WriteLine(AvgComputers);

            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("The Student Who got Maximum Marks in Maths");
            var MaxIdMaths = marks.Where(m => m.Maths == MaxMaths);
            foreach (var user in MaxIdMaths)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("The Student Who got Minimum Marks in Maths");
            var MinIdMaths = marks.Where(m => m.Maths == MinMaths);
            foreach (var user in MinIdMaths)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("\nThe Student Who got Maximum Marks in Social");
            var MaxIdSocial = marks.Where(m => m.Social == MaxSocial);
            foreach (var user in MaxIdSocial)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("The Student Who got Minimum Marks in Social");
            var MinIdSocial = marks.Where(m => m.Social == MinSocial);
            foreach (var user in MinIdSocial)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("\nThe Student Who got Maximum Marks in Science");
            var MaxIdScience = marks.Where(m => m.Science == MaxScience);
            foreach (var user in MaxIdScience)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("The Student Who got Minimum Marks in Science");
            var MinIdScience = marks.Where(m => m.Science == MinScience);
            foreach (var user in MinIdScience)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("\nThe Student Who got Maximum Marks in English");
            var MaxIdEnglish = marks.Where(m => m.English == MaxEnglish);
            foreach (var user in MaxIdEnglish)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("The Student Who got Minimum Marks in English");
            var MinIdEnglish = marks.Where(m => m.English == MinEnglish);
            foreach (var user in MinIdEnglish)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("\nThe Student Who got Maximum Marks in Computers");
            var MaxIdComputers = marks.Where(m => m.Computers == MaxComputers);
            foreach (var user in MaxIdComputers)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("The Student Who got Minimum Marks in Computers");
            var MinIdcomputers = marks.Where(m => m.Computers == MinComputers);
            foreach (var user in MinIdcomputers)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("*******************************************************************************************");
            Console.ReadLine();
        }
        static void Seed()
        {
            students = new Data().Get();
            subjects = new Data().Get1();
            marks = new Data().Get2();
        }
    }
}
