using System;
using System.Linq;

namespace LINQ_ToLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var GroupByMS = Student.GetStudents().ToLookup(s => s.Branch);
            //Using Query Syntax
            var GroupByQS = (from std in Student.GetStudents()
                             select std).ToLookup(x => x.Branch);
            //It will iterate through each group
            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group
                foreach (var student in group)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" + student.Gender);
                }
            }

            Console.Read();
        }
    }
}
