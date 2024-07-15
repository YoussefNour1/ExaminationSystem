// choose one answer class that iherit from question class
namespace ExaminationSystem.Questions
{
    public class ChooseOneQuestion : Question
    {
        public List<string> Options { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; }

        public ChooseOneQuestion(string Header, string Body, int Marks, List<string> _Options, string _CorrectAnswer) : base(Header, Body, Marks)
        {
            Options = _Options;
            CorrectAnswer = _CorrectAnswer;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}: ({Marks} marks)\n{Body}");
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
        }
    }
}