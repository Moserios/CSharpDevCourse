using System;
using System.Collections.Generic;

namespace CreateTests
{
    internal class Program
    {
        static void Main()
        {
            //Create a C# app that helps teachers to create tests with MCQ (Multiple Choice Questions)
            //and then students can answer those questions and also the system find outs marks secured of the student.

            //Process flow:
            //Step 1: First, system should accept two test papers; each test paper contains 10 MCQ.
            //Each question has four options; one question has only one correct answer(correct option).

            TestPaper tp1 = new TestPaper()
            {
                SubjectName = "Calculus",
                TestPaperName = "Math",
                Questions = new List<IQuestion>()
            };

            void Q1_Add(){
                Question q1 = new Question()
                {
                    QuestionText = "What is the result: 5 + 3",
                    CorrectAnswerLetter = 'B'
                };

                Option op10 = new Option() { OptionText = "6" };
                Option op11 = new Option() { OptionText = "8" };
                Option op12 = new Option() { OptionText = "3" };
                Option op13 = new Option() { OptionText = "53" };
                q1.AddOption(op10);
                q1.AddOption(op11);
                q1.AddOption(op12);
                q1.AddOption(op13);
                tp1.Questions.Add(q1);
            }

            void Q2_Add()
            {
                Question q1 = new Question()
                {
                    QuestionText = "What is the result: 5 - 3",
                    CorrectAnswerLetter = 'C'
                };

                Option op10 = new Option() { OptionText = "3" };
                Option op11 = new Option() { OptionText = "-2" };
                Option op12 = new Option() { OptionText = "2" };
                Option op13 = new Option() { OptionText = "5-3" };
                q1.AddOption(op10);
                q1.AddOption(op11);
                q1.AddOption(op12);
                q1.AddOption(op13);
                tp1.Questions.Add(q1);
            }

            void Q3_Add()
            {
                Question q1 = new Question()
                {
                    QuestionText = "What is the result: 5 * 3",
                    CorrectAnswerLetter = 'D'
                };

                Option op10 = new Option() { OptionText = "5.3" };
                Option op11 = new Option() { OptionText = "12" };
                Option op12 = new Option() { OptionText = "125" };
                Option op13 = new Option() { OptionText = "15" };
                q1.AddOption(op10);
                q1.AddOption(op11);
                q1.AddOption(op12);
                q1.AddOption(op13);
                tp1.Questions.Add(q1);
            }

            void Q4_Add()
            {
                Question q1 = new Question()
                {
                    QuestionText = "What is the result: 5 / 3",
                    CorrectAnswerLetter = 'A'
                };

                Option op10 = new Option() { OptionText = "1.667" };
                Option op11 = new Option() { OptionText = "1" };
                Option op12 = new Option() { OptionText = "1.2" };
                Option op13 = new Option() { OptionText = "0.667" };
                q1.AddOption(op10);
                q1.AddOption(op11);
                q1.AddOption(op12);
                q1.AddOption(op13);
                tp1.Questions.Add(q1);
            }

            Q1_Add();
            Q2_Add();
            Q3_Add();
            Q4_Add();


            TestPaper tp2 = new TestPaper()
            {
                SubjectName = "Geography",
                TestPaperName = "Capitals of the countries",
                Questions = new List<IQuestion>()
            };

            void Q11_Add()
            {
                Question q1 = new Question()
                {
                    QuestionText = "What is the capital of USA",
                    CorrectAnswerLetter = 'B'
                };

                Option op10 = new Option() { OptionText = "New York" };
                Option op11 = new Option() { OptionText = "Washington D.C." };
                Option op12 = new Option() { OptionText = "London" };
                Option op13 = new Option() { OptionText = "New Delhi" };
                q1.AddOption(op10);
                q1.AddOption(op11);
                q1.AddOption(op12);
                q1.AddOption(op13);
                tp2.Questions.Add(q1);
            }

            void Q12_Add()
            {
                Question q1 = new Question()
                {
                    QuestionText = "What is the capital of Canada",
                    CorrectAnswerLetter = 'D'
                };

                Option op10 = new Option() { OptionText = "Toronto" };
                Option op11 = new Option() { OptionText = "Montreal" };
                Option op12 = new Option() { OptionText = "Canberra" };
                Option op13 = new Option() { OptionText = "Ottawa" };
                q1.AddOption(op10);
                q1.AddOption(op11);
                q1.AddOption(op12);
                q1.AddOption(op13);
                tp2.Questions.Add(q1);
            }

            void Q13_Add()
            {
                Question q1 = new Question()
                {
                    QuestionText = "What is the capital of Japan",
                    CorrectAnswerLetter = 'C'
                };

                Option op10 = new Option() { OptionText = "Osaka" };
                Option op11 = new Option() { OptionText = "Kyoto" };
                Option op12 = new Option() { OptionText = "Tokio" };
                Option op13 = new Option() { OptionText = "Taipei" };
                q1.AddOption(op10);
                q1.AddOption(op11);
                q1.AddOption(op12);
                q1.AddOption(op13);
                tp2.Questions.Add(q1);
            }

            void Q14_Add()
            {
                Question q1 = new Question()
                {
                    QuestionText = "What is the capital of Sweden",
                    CorrectAnswerLetter = 'A'
                };

                Option op10 = new Option() { OptionText = "Stockholm" };
                Option op11 = new Option() { OptionText = "Gothenburg" };
                Option op12 = new Option() { OptionText = "Oslo" };
                Option op13 = new Option() { OptionText = "Helsinki" };
                q1.AddOption(op10);
                q1.AddOption(op11);
                q1.AddOption(op12);
                q1.AddOption(op13);
                tp2.Questions.Add(q1);
            }

            Q11_Add();
            Q12_Add();
            Q13_Add();
            Q14_Add();


            Student stud1 = new Student()
            {
                RollNo = 1,
                StudentName = "Sergey"
            };

            stud1.TestPapers.Add(tp1);
            stud1.TestPapers.Add(tp2);

            int testPaperNumber = 0;
            while (testPaperNumber < stud1.TestPapers.Count)
            {
                int questionNumber = 0;
                while (questionNumber < stud1.TestPapers[testPaperNumber].Questions.Count)
                {
                    Console.Clear();
                    Console.WriteLine(stud1.TestPapers[testPaperNumber].TestPaperName);
                    Console.WriteLine(stud1.TestPapers[testPaperNumber].SubjectName);
                    Console.WriteLine(stud1.TestPapers[testPaperNumber].Questions[questionNumber].QuestionText);
                    foreach (Option opt in stud1.TestPapers[testPaperNumber].Questions[questionNumber].Options)
                    {
                        Console.WriteLine($"{opt.OptionLetter}: {opt.OptionText}");
                    }
                    Console.WriteLine("Enter the answer letter: ");
                    string answer = Console.ReadLine().ToUpper();
                    stud1.TestPapers[testPaperNumber].Questions[questionNumber].OptionSelectedByStudent = Convert.ToChar(answer);
                    if (stud1.TestPapers[testPaperNumber].Questions[questionNumber].CorrectAnswerLetter == stud1.TestPapers[testPaperNumber].Questions[questionNumber].OptionSelectedByStudent)
                    {
                        stud1.TestPapers[testPaperNumber].Questions[questionNumber].MarksSecured = 5;
                    }
                    else
                    {
                        stud1.TestPapers[testPaperNumber].Questions[questionNumber].MarksSecured = 0;
                    }
                    questionNumber++;
                }
                testPaperNumber++;
            }


            Console.Clear();
            foreach (TestPaper testPaper in stud1.TestPapers)
            {
                int totalMarks = 0;
                Console.WriteLine($"\nTesting results for {testPaper.SubjectName}:");

                foreach (Question q in testPaper.Questions)
                {
                    Console.WriteLine($"Question: {q.QuestionText} ? correct answer: {q.CorrectAnswerLetter}. Your answer: {q.OptionSelectedByStudent}.  {q.MarksSecured} mark.");
                    totalMarks += q.MarksSecured;
                }
                Console.WriteLine($"Final mark for {testPaper.SubjectName}: {totalMarks / testPaper.Questions.Count}");
            }
            Console.ReadKey();
        }
    }


    //Step 2: System should allow one student to attempt both the test papers.
    //While student answers each question, it should display the question text with list of options.

    //Example:
    //    What is the capital of U.S.A.
    //    A) New York
    //    B) Washington D.C.
    //    C) London
    //    D) New Delhi

    //It should accept student's choice. Eg:  B
    //Step 3: System should automatically compare the correct answer with student's choice; find out marks secured of each question.
    //It should display all questions respective correct answer, student's choice, marks secured and finally total marks secured for test paper.
    //Overall, one student should answer two test papers.


    // classes
    //class TestPaper : Represents a test with a set of questions.
    //interface ITestPaper
    class TestPaper : ITestPaper
    {
        public string SubjectName { get; set; }
        public string TestPaperName { get; set; }
        public List<IQuestion> Questions { get; set; }
    }

    //class Question : Represents a single question with a set of options and also stores the student's choice along with marks secured by the student.
    //    interface IQuestion
    class Question : IQuestion
    {
        private List<IOption> ReplyOptions = new List<IOption>();
        public string QuestionText { get; set; }
        public List<IOption> Options 
        { 
            get
            { 
                return ReplyOptions; 
            }
            set
            {
                ReplyOptions = value;
                //Option newOption = new Option();
                //int records = ReplyOptions.Count;
                //char letter = ' ';
                //Console.WriteLine($"default letter: {letter}");
                //switch (records)
                //{
                //    case 0: letter = 'A'; break;
                //    case 1: letter = 'B'; break;
                //    case 2: letter = 'C'; break;
                //    case 3: letter = 'D'; break;
                //    default: letter = 'F'; break;
                //}
                //newOption.OptionLetter = letter;
                //ReplyOptions.Add(newOption);
            }
        }

        public void AddOption(IOption option)
        {
            char letter = ' ';
            switch (ReplyOptions.Count)
            {
                case 0: letter = 'A'; break;
                case 1: letter = 'B'; break;
                case 2: letter = 'C'; break;
                case 3: letter = 'D'; break;
                default: letter = 'F'; break;
            }
            option.OptionLetter = letter;
            ReplyOptions.Add(option);
        }

        public char CorrectAnswerLetter { get; set; }
        public char OptionSelectedByStudent { get; set; }
        public int MarksSecured { get; set; }

        int OptionCounter = 0;
    }

    //class Option : Represents an option of a question.The option letter should be auto-generated as "A", "B" etc.
    //    interface IOption
    class Option : IOption
    {
        public char OptionLetter { get; set; }
        public string OptionText { get; set; }
    }

    //class Student : Represents a student along with the test papers attempted by him.
    //    interface IStudent
    class Student : IStudent
    {
        private List<ITestPaper> testPapers = new List<ITestPaper>();

        public int RollNo 
        { get ; set ; }
        public string StudentName 
        { get; set; }
        public List<ITestPaper> TestPapers 
        {
            get
            { return this.testPapers; }
            set
            { this.testPapers.Add((ITestPaper)value); } 
        }
    }


    // Interfaces
    interface ITestPaper
    {
        string SubjectName { get; set; }
        string TestPaperName { get; set; }
        List<IQuestion> Questions { get; set; }
    }

    interface IQuestion
    {
        string QuestionText { get; set; }
        List<IOption> Options { get; set; }
        char CorrectAnswerLetter { get; set; }
        char OptionSelectedByStudent { get; set; }
        int MarksSecured { get; set; }
    }

    interface IOption
    {
        char OptionLetter { get; set; }
        string OptionText { get; set; }
    }

    interface IStudent
    {
        int RollNo { get; set; }
        string StudentName { get; set; }
        List<ITestPaper> TestPapers { get; set; }
    }
}
