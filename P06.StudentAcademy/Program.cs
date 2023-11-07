using System.Xml.Linq;

namespace P06.StudentAcademy
{
    class Student
    {
        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {Grade:f2}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentsMap = new Dictionary<string, Student>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                Student student = new Student(studentName, studentGrade);

                if (!studentsMap.ContainsKey(studentName))
                {
                    studentsMap.Add(studentName, student);
                }
                else
                {
                    double newGrade = (studentsMap[studentName].Grade + studentGrade) / 2;
                    studentsMap[studentName].Grade = newGrade;
                }

            }

            foreach (KeyValuePair<string, Student> kvp in studentsMap)
            {
                Student student = kvp.Value;
                if (student.Grade >= 4.5)
                {
                    Console.WriteLine($"{kvp.Value}");
                }
            }
        }
    }
}