using ExaminationSystem.Answers;
using ExaminationSystem.Questions;

namespace ExaminationSystem.Exams
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public string Time { get; set; }
        public string Mode { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, AnswerList> QuestionAnswerDict { get; set; }
        public abstract void ShowExam();

        public override string ToString()
        {
            return $"ExamType: {Mode}, Duration: {Time}, NumberOfQuestions: {NumberOfQuestions}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Time, NumberOfQuestions, Mode);
        }
        public bool Equals(Exam other){
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