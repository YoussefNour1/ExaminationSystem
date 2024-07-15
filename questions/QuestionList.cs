
namespace ExaminationSystem.Questions
{
    public class QuestionList : List<Question>
    {
        private string _LogFile;
        public QuestionList(string LogFile)
        {
            _LogFile = LogFile;
        }
        public void AddQuestion(Question Q)
        {
            base.Add(Q);
            LogToFile(Q);
        }

        private void LogToFile(Question Q)
        {
            using (StreamWriter sw = new StreamWriter(_LogFile, true))
            {
                sw.WriteLine(Q);
            };
        }
    }
}