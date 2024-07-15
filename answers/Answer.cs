namespace ExaminationSystem.Answers
{
    public class Answer(string content)
    {
        public string Content { get; set; } = content;
        public override string ToString() => Content;
    }
}