using ExaminationSystem.Answers;
using ExaminationSystem.Exams;
using ExaminationSystem.Questions;

namespace ExaminationSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create students
            Student student1 = new Student { Name = "Alice" };
            Student student2 = new Student { Name = "Bob" };

            // Create subject
            Subject subject = new Subject("Math");
            subject.Students.Add(student1);
            subject.Students.Add(student2);

            // Select Exam Type
            Console.WriteLine("Select Exam Type: 1 for Practice, 2 for Final");
            int choice = int.Parse(Console.ReadLine());

            Exam exam = null;
            if (choice == 1)
            {
                exam = new PracticeExam("1 hour", 5);
            }
            else if (choice == 2)
            {
                exam = new FinalExam("2 hours", 10);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            // Subscribe students to the exam start event
            foreach (var student in subject.Students)
            {
                exam.ExamStarted += student.OnExamStarted;
            }

            // Exam details
            Console.WriteLine("Enter exam time (e.g., 1 hour): ");
            exam.Time = Console.ReadLine();

            Console.WriteLine("Enter number of questions: ");
            exam.NumberOfQuestions = int.Parse(Console.ReadLine());

            // Create a question list with a log file
            QuestionList questionList = new QuestionList($"{exam.GetType().Name}_Questions.log");

            for (int i = 0; i < exam.NumberOfQuestions; i++)
            {
                Console.WriteLine($"Enter details for question {i + 1}:");

                Console.WriteLine("Select question type: 1 for True/False, 2 for Choose One, 3 for Choose All");
                int questionType = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter question header: ");
                string header = Console.ReadLine();

                Console.WriteLine("Enter question body: ");
                string body = Console.ReadLine();

                Console.WriteLine("Enter question marks: ");
                int marks = int.Parse(Console.ReadLine());

                Question question = null;
                AnswerList answerList = new AnswerList();

                if (questionType == 1)
                {
                    Console.WriteLine("Enter correct answer (true/false): ");
                    bool correctAnswer = bool.Parse(Console.ReadLine());
                    question = new TrueOrFalseQuestion(header, body, marks, correctAnswer);
                    answerList.Add(new Answer(correctAnswer.ToString()));
                }
                else if (questionType == 2)
                {
                    Console.WriteLine("Enter the number of options: ");
                    int optionCount = int.Parse(Console.ReadLine());
                    List<string> options = new List<string>();
                    for (int j = 0; j < optionCount; j++)
                    {
                        Console.WriteLine($"Enter option {j + 1}: ");
                        options.Add(Console.ReadLine());
                    }
                    Console.WriteLine("Enter correct answer: ");
                    string correctAnswer = Console.ReadLine();
                    question = new ChooseOneQuestion(header, body, marks, options, correctAnswer);
                    answerList.Add(new Answer(correctAnswer));
                }
                else if (questionType == 3)
                {
                    Console.WriteLine("Enter the number of options: ");
                    int optionCount = int.Parse(Console.ReadLine());
                    List<string> options = new List<string>();
                    for (int j = 0; j < optionCount; j++)
                    {
                        Console.WriteLine($"Enter option {j + 1}: ");
                        options.Add(Console.ReadLine());
                    }
                    Console.WriteLine("Enter the number of correct answers: ");
                    int correctAnswerCount = int.Parse(Console.ReadLine());
                    List<string> correctAnswers = new List<string>();
                    for (int j = 0; j < correctAnswerCount; j++)
                    {
                        Console.WriteLine($"Enter correct answer {j + 1}: ");
                        correctAnswers.Add(Console.ReadLine());
                        answerList.Add(new Answer(correctAnswers[j]));
                    }
                    question = new ChooseAll(header, body, marks, options, correctAnswers);
                }
                else
                {
                    Console.WriteLine("Invalid question type.");
                    return;
                }

                exam.QuestionAnswerDict.Add(question, answerList);
                questionList.Add(question); // Add question to the question list with logging
            }

            // Start the exam
            exam.StartExam();


        }
    }

}