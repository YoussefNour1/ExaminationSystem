namespace ExaminationSystem.Exams
{
    public class FinalExam(string time, int numberOfQuestions):Exam(time, numberOfQuestions)
    {
        public override void ShowExam()
        {
            foreach (var QAP in QuestionAnswerDict)
            {
                QAP.Key.Display();
                
            }
        }
    }
}