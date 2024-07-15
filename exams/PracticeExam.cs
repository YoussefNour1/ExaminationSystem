namespace ExaminationSystem.Exams
{
    public class PracticeExam: Exam
    {
        public override void ShowExam()
        {
            foreach (var QAP in QuestionAnswerDict)
            {
                QAP.Key.Display();
                Console.WriteLine("Correct Answer: ");
                QAP.Value.DisplayAnwers();
                Console.WriteLine();
            }
        }
    }
}