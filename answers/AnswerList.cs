namespace ExaminationSystem.Answers
{
    public class AnswerList : List<Answer>
    {
        public void DisplayAnwers(){
            foreach(Answer answer in this){
                Console.WriteLine(answer.Content);
            }
        }
    }
}