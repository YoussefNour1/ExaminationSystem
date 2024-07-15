// true or false class that iherit from question class
namespace ExaminationSystem.Questions
{
    public class TrueOrFalseQuestion(string header, string body, int marks, bool correctAnswer) : Question(header, body, marks)
    {
        public bool CorrectAnswer { get; set; } = correctAnswer;

        public override string ToString()
        {
            return $"(True/False){Header} \t\tMarks:{Marks} marks\n{Body}";
        }

        public override void Display()
        {
            Console.WriteLine(this);
        }
    }
}