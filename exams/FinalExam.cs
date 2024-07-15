namespace ExaminationSystem.Exams
{
    public class FinalExam:Exam
    {
        public override void ShowExam()
        {
            foreach (var QAP in QuestionAnswerDict)
            {
                QAP.Key.Display();
                Console.WriteLine("Answers: ");
                QAP.Value.DisplayAnwers();
                Console.WriteLine();
            }
        }
    }
}