namespace P05.Courses
{
    class Course
    {
        public Course(string courseName, List<string> students)
        {
            CourseName = courseName;
            Students = students;

        }

        public string CourseName { get; set; }
        public List<string> Students { get; set; }

        public override string ToString()
        {
            return $"{CourseName}: {Students.Count}\n" +
                    string.Join(Environment.NewLine, Students.Select(student => $"-- {student}"));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> coursesMap = new Dictionary<string, Course>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] instructions = input.Split(" : ");
                string courseName = instructions[0];
                string studentName = instructions[1];
                List<string> students = new List<string>();
                Course course = new Course(courseName, students);

                if (!coursesMap.ContainsKey(courseName))
                {
                    coursesMap.Add(courseName, course);
                }

                coursesMap[courseName].Students.Add(studentName);
            }

            foreach (KeyValuePair<string, Course> kvp in coursesMap)
            {
                Console.WriteLine($"{kvp.Value}");
            }
        }
    }
}