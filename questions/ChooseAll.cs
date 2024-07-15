// Choose all class that iherit from question class
namespace ExaminationSystem.Questions
{
    public class ChooseAll : Question
    {
        public List<string> Options { get; set; } = new List<string>();
        public List<string> CorrectAnswers { get; set; } = new List<string>();

        public ChooseAll()
        {

        }

        public ChooseAll(string Header, string Body, int Marks, List<string> _Options, List<string> _CorrectAnswers) : base(Header, Body, Marks)
        {
            Options = _Options;
            CorrectAnswers = _CorrectAnswers;
        }


        public override void Display()
        {
            Console.WriteLine($"{Header}: ({Marks} marks)\n{Body}");
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
            Console.WriteLine($"Correct answers: {string.Join(", ", CorrectAnswers)}");
        }
    }
}