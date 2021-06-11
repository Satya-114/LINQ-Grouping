using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_ToLookup
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
        {
            new Student { ID = 1001, Name = "Preety", Gender = "Female",
                                         Branch = "CSE", Age = 20 },
            new Student { ID = 1002, Name = "Rakshith", Gender = "Male",
                                         Branch = "ETC", Age = 21  },
            new Student { ID = 1003, Name = "Pranaya", Gender = "Male",
                                         Branch = "CSE", Age = 21  },
            new Student { ID = 1004, Name = "Anurag", Gender = "Male",
                                         Branch = "CSE", Age = 20  },
            new Student { ID = 1005, Name = "Hina", Gender = "Female",
                                         Branch = "ETC", Age = 20 }
            };
        }
    }
}
