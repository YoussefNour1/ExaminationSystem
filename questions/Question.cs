namespace ExaminationSystem.Questions
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }

        public abstract void Display();

        public override string ToString()
        {
            return $"{Header}\t\tMarks: {Marks} marks\nBody: {Body}";
        }

        public override bool Equals(object obj)
        {
            return obj is Question question &&
                   Header == question.Header &&
                   Body == question.Body &&
                   Marks == question.Marks;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Header, Body, Marks);
        }

        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            return Marks.CompareTo(other.Marks);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}