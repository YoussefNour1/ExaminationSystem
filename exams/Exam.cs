using ExaminationSystem.Answers;
using ExaminationSystem.Questions;

namespace ExaminationSystem.Exams
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public string Time { get; set; }
        public string Mode { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, AnswerList> QuestionAnswerDict { get; set; } = [];
        public delegate void ExamStartedHandler(string message);
        public event ExamStartedHandler ExamStarted;
        public Exam(string time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Mode = "Queued";
        }
        public abstract void ShowExam();
        public void StartExam()
        {
            Mode = "Starting";
            OnExamStarted("The exam is now starting!");
            Console.WriteLine($"\nThis is an exam  with duration: {Time}");
            ShowExam();
        }
        protected virtual void OnExamStarted(string message)
        {
            ExamStarted?.Invoke(message);
        }
        public override string ToString()
        {
            return $"Duration: {Time}, NumberOfQuestions: {NumberOfQuestions}, Mode: {Mode}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Time, NumberOfQuestions, Mode);
        }
        public bool Equals(Exam other)
        {
            return Time == other.Time && NumberOfQuestions == other.NumberOfQuestions && Mode == other.Mode;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Exam? other)
        {
            if (other == null) return 1;
            return NumberOfQuestions.CompareTo(other.NumberOfQuestions);
        }
    }
}