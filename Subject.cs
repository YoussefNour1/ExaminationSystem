namespace ExaminationSystem
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Subject(string subjectName)
        {
            SubjectName = subjectName;
        }
    }
}