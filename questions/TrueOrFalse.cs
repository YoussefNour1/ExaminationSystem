// true or false class that iherit from question class
namespace ExaminationSystem.Questions
{
    public class TrueOrFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; } = false;
        
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