using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Students
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string[] studentInput = Console.ReadLine().Split();
                if (studentInput[0] == "END")
                {
                    break;
                }
                string name = studentInput[0];
                string egn = studentInput[1];
                string facultyId = studentInput[2];
                double[] grades = new double[studentInput.Length - 5];
                double avgGrade = double.Parse(studentInput[studentInput.Length - 1]);


                for (int i = 3; i < studentInput.Length - 2; i++)
                {
                    grades[i - 3] = double.Parse(studentInput[i]);
                }

                Student student = new Student(name, egn, facultyId, grades, avgGrade);

                students.Add(student);
            }


            foreach (var student in students)
            {
                ConvertStudentInformationToFile(students);
                double avgGradex2 = CalculateAvgGrade(student.grades);
                Console.WriteLine(student.studentName);
                Console.Write(avgGradex2);
                Console.WriteLine();

            }
            Console.WriteLine(StudentsBornBeforeChosenDate(students));



        }
        private static void ConvertStudentInformationToFile(List<Student> students)
        {
            StringBuilder sb = new StringBuilder();
            string path = "../../../Student.txt";
            foreach (var student in students)
            {
                using (StreamWriter fs = File.CreateText(path))
                {
                    sb.AppendLine(student.studentName);
                    sb.AppendLine(student.studentEGN);
                    sb.AppendLine(student.studentFacultyId);

                    sb.Append(string.Join(" ", student.grades));
                    sb.AppendLine();

                    fs.WriteLine(sb.ToString().TrimEnd());
                }
            }



        }

        private static double CalculateAvgGrade(double[] grades)
        {
            double result = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                result += grades[i];
            }

            return result / grades.Length;
        }

        private static string StudentsBornBeforeChosenDate(List<Student> students)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var student in students)
            {
                int month = int.Parse(student.studentEGN.Substring(2, 2)) - 40;
                int day = int.Parse(student.studentEGN.Substring(4, 2));

                if (month == 01)
                {
                    if (day == 17)
                    {
                        sb.AppendLine(student.studentName);
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
