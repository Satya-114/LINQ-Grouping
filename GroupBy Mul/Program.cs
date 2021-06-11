using System;
using System.Linq;

namespace GroupBy_MUL
{
    class Program
    {
        static void Main(string[] args)
        {
            var GroupByMultipleKeysMS = Student.GetStudents()
                                         .GroupBy(x => new { x.Branch, x.Gender })
                                         .OrderByDescending(g => g.Key.Branch).ThenBy(g => g.Key.Gender)
                                         .Select(g => new
                                         {
                                             Branch = g.Key.Branch,
                                             Gender = g.Key.Gender,
                                             Students = g.OrderBy(x => x.Name)
                                         });
            //Using Query Syntax
            var GroupByMultipleKeysQS = from student in Student.GetStudents()
                                        group student by new
                                        {
                                            student.Branch,
                                            student.Gender
                                        } into stdGroup
                                        orderby stdGroup.Key.Branch descending,
                                                stdGroup.Key.Gender ascending
                                        select new
                                        {
                                            Branch = stdGroup.Key.Branch,
                                            Gender = stdGroup.Key.Gender,
                                            Students = stdGroup.OrderBy(x => x.Name)
                                        };
            //It will iterate through each group
            foreach (var group in GroupByMultipleKeysQS)
            {
                Console.WriteLine($"Barnch : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");
                //It will iterate through each item of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
