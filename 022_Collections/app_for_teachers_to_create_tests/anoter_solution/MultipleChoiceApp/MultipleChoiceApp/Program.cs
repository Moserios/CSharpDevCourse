using System;
using System.Collections.Generic;

namespace MultipleChoiceApp
{
 internal class Program
 {
  static void Main(string[] args)
  {
   // Step 1: Create two test papers with 10 MCQs each
   Console.WriteLine("Enter details for Test Paper 1:");
   ITestPaper testPaper1 = CreateTestPaperFromInput();
   Console.WriteLine("Enter details for Test Paper 2:");
   ITestPaper testPaper2 = CreateTestPaperFromInput();

   // Step 2: Allow one student to attempt both test papers
   Console.WriteLine("Enter student details:");
   IStudent student = CreateStudentFromInput();

   Console.WriteLine("Student: " + student.StudentName);
   Console.WriteLine();

   // Attempt test paper 1
   Console.WriteLine("Test Paper 1 - " + testPaper1.SubjectName + " - " + testPaper1.TestPaperName);
   TakeTestPaper(testPaper1);
   Console.WriteLine();

   // Attempt test paper 2
   Console.WriteLine("Test Paper 2 - " + testPaper2.SubjectName + " - " + testPaper2.TestPaperName);
   TakeTestPaper(testPaper2);

   // Step 3: Display marks secured for each test paper
   Console.WriteLine("Marks secured for " + testPaper1.TestPaperName + ": " + CalculateMarksSecured(testPaper1));
   Console.WriteLine("Marks secured for " + testPaper2.TestPaperName + ": " + CalculateMarksSecured(testPaper2));

   Console.ReadLine();
  }


  static ITestPaper CreateTestPaperFromInput()
  {
   ITestPaper testPaper = new TestPaper();

   Console.Write("Enter subject name: ");
   testPaper.SubjectName = Console.ReadLine();

   Console.Write("Enter test paper name: ");
   testPaper.TestPaperName = Console.ReadLine();

   testPaper.Questions = new List<IQuestion>();
   for (int i = 1; i <= 10; i++)
   {
    Console.WriteLine("Enter details for Question " + i + ":");
    IQuestion question = CreateQuestionFromInput();
    testPaper.Questions.Add(question);
   }

   return testPaper;
  }


  static IQuestion CreateQuestionFromInput()
  {
   IQuestion question = new Question();

   Console.Write("Enter question text: ");
   question.QuestionText = Console.ReadLine();

   question.Options = new List<IOption>();
   for (char optionLetter = 'A'; optionLetter <= 'D'; optionLetter++)
   {
    Console.Write("Enter option " + optionLetter + ": ");
    string optionText = Console.ReadLine();
    IOption option = new Option
    {
     OptionLetter = optionLetter,
     OptionText = optionText
    };
    question.Options.Add(option);
   }

   Console.Write("Enter correct answer letter: ");
   question.CorrectAnswerLetter = char.ToUpper(Console.ReadKey().KeyChar);

   return question;
  }


  static IStudent CreateStudentFromInput()
  {
   IStudent student = new Student();

   Console.Write("Enter roll number: ");
   student.RollNo = int.Parse(Console.ReadLine());

   Console.Write("Enter student name: ");
   student.StudentName = Console.ReadLine();

   student.TestPapers = new List<ITestPaper>();

   return student;
  }


  static void TakeTestPaper(ITestPaper testPaper)
  {
   foreach (IQuestion question in testPaper.Questions)
   {
    Console.WriteLine(question.QuestionText);
    foreach (IOption option in question.Options)
    {
     Console.WriteLine(option.OptionLetter + ". " + option.OptionText);
    }

    Console.WriteLine("Enter your choice: ");
    question.OptionSelectedByStudent = Console.ReadLine().ToUpper()[0];
   }
  }

  static int CalculateMarksSecured(ITestPaper testPaper2)
  {
   int marksSecured = 0;
   foreach (IQuestion question in testPaper2.Questions)
   {
    if (question.CorrectAnswerLetter.ToString().Equals(question.OptionSelectedByStudent.ToString(), StringComparison.OrdinalIgnoreCase))
    {
     marksSecured++;
    }
   }

   return marksSecured;
  }
 }
}

