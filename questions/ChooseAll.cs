// Choose all class that iherit from question class
namespace ExaminationSystem.Questions
{
    public class ChooseAll: Question
    {
        public List<string> Options { get; set; } = new List<string>();
        public List<int> CorrectAnswerIndexes { get; set; } = new List<int>();

        public ChooseAll()
        {
            
        }

        public ChooseAll(string Header, string Body,int Marks, List<string> _Options , List<int> _CorrectAnswerIndexes): base(Header, Body,  Marks)
        {
            Options = _Options;
            CorrectAnswerIndexes = _CorrectAnswerIndexes;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nChoose all:\n{string.Join("\n", Options.Select((x, i) => $"{i + 1}. {x}"))}\nCorrect Answers: {string.Join(", ", CorrectAnswerIndexes.Select(x => Options[x]))}";
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