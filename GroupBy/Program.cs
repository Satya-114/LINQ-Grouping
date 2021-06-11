using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var GroupByMS = Student.GetStudents().GroupBy(s => s.Branch);
            //Using Query Syntax
            IEnumerable<IGrouping<string, Student>> GroupByQS = (from std in Student.GetStudents()
                                                                 group std by std.Branch);
            //It will iterate through each groups
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
