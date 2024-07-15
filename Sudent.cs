namespace ExaminationSystem
{
    // Student class to handle notifications
    public class Student
    {
        public string Name { get; set; }

        public void OnExamStarted(string message)
        {
            Console.WriteLine($"Notification for {Name}: {message}");
        }
    }

}