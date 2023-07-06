using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AchievmentsOfPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            StreamReader reader = new StreamReader("students.txt");
            string row = reader.ReadLine();
            while (row != null)
            {
                List<string> studentInfo = row.Split(',').ToList();
                Student current = new Student(studentInfo[0], int.Parse(studentInfo[1]), int.Parse(studentInfo[2]), int.Parse(studentInfo[3]));
                students.Add(current);
                row = reader.ReadLine();
            }
            StreamWriter writer = new StreamWriter("output.txt");
            using (writer)
            {
                 foreach (Student st in students)
                 {
                   double average = (st.BelGrade + st.MathGrade + st.InfoGrade) / 3.0;
                   writer.WriteLine($"{st.Name} - {average}");
                 }
            }
            //a
        }
    }
}
