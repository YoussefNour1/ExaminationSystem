namespace ExaminationSystem.Exams
{
    public class PracticeExam(string time, int numberOfQuestions): Exam(time, numberOfQuestions)
    {
        
        public override void ShowExam()
        {
            foreach (var QAP in QuestionAnswerDict)
            {
                QAP.Key.Display();
                // Console.WriteLine($"Answer: {string.Join(", ", QAP.Value)}");
                Console.WriteLine();
            }
        }
    }
}