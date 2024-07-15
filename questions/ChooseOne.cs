// choose one answer class that iherit from question class
namespace ExaminationSystem.Questions
{
    public class ChooseOneQuestion : Question
    {
        public List<string> Options { get; set; } = new List<string>();
        public int CorrectAnswerIndex { get; set; } = 0;

        public ChooseOneQuestion()
        {
            
        }
        public ChooseOneQuestion(string Header, string Body, int Marks, List<string> _Options, int _CorrectAnswerIndex): base(Header, Body, Marks)
        {
            Options = _Options;
            CorrectAnswerIndex = _CorrectAnswerIndex;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nChoose one:\n{string.Join("\n", Options.Select((x, i) => $"{i + 1}. {x}"))}\nCorrect Answer: {Options[CorrectAnswerIndex]}";
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}: {Body}");
            foreach (var option in Options)
            {
                Console.WriteLine(option);
            }
        }
    }
}