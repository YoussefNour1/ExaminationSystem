namespace ExaminationSystem.Questions
{
    public abstract class Question(string? header, string? body, int? marks)
    {
        public string? Header { get; set; } = header;
        public string? Body { get; set; } = body;
        public int? Marks { get; set; } = marks;

        public override int GetHashCode()
        {
            return HashCode.Combine(Header, Body, Marks);
        }

        public override string ToString()
        {
            return $"{Header}: \t{Marks} marks\n{Body}";
        }

        public override bool Equals(object? other)
        {
            if(other is Question obj)
            {
                return Header == obj.Header && Body == obj.Body && Marks == obj.Marks;
            }
            return false;
        }


    }
}