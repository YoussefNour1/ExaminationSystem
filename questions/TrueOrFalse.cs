// true or false class that iherit from question class
namespace ExaminationSystem.Questions
{
    public class TrueOrFalseQuestion : Question
    {
        public bool Answer { get; set; } = false;
        public TrueOrFalseQuestion(string Header, string Body, int Marks, bool _Answer) : base(Header, Body, Marks)
        {
            Answer = _Answer;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nTrue or False: {Answer}";
        }
    }
}