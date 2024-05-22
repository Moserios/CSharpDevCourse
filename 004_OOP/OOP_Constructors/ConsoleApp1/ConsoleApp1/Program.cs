//There is a quiz application, where it contains loads of MCQs (Multiple Choice Questions).
//Each question would have two, three or four options - like option A, B, C, D.

//Eg:
//Question: What is the capital of the USA?
//Option A: London
//Option B: New York
//Option C: Washington, D.C.
//Option D: San Diego
//Correct Answer Letter: 'C'


using System;

class Quiz
{
    public static void Main()
    {
        //Create objects for 'Question' class as follows, in Main method:
        //Create the first object of Question class and pass no arguments to the constructor.

        Question q1 = new Question();

        //Create the second object of Question class and pass value for questionText only to the constructor.
        Question q2 = new Question("Here is a first question text should be!");


        //Create the third object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
        Question q3 = new Question("Who is the first president of the USA?", "Obama", "Clinton", "Washington", "Churchill", 'C');

        //Create the fourth object for Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
        //Note: Use object initializer, anywhere, when you feel a need.
        Question q4 = new Question() {questionText="Who is the founder of General Relativity theory?", optionA="Bor", optionB="Newton", optionC="Maxwell", optionD="Einstein"};


        System.Console.WriteLine($"Q1:{q1.questionText}, {q1.optionA}, {q1.optionB}, {q1.optionC}, {q1.optionD}, {q1.correctAnswerLetter}");
        System.Console.WriteLine($"Q2:{q2.questionText}, {q2.optionA}, {q2.optionB}, {q2.optionC}, {q2.optionD}, {q2.correctAnswerLetter}");
        System.Console.WriteLine($"Q3:{q3.questionText}, {q3.optionA}, {q3.optionB}, {q3.optionC}, {q3.optionD}, {q3.correctAnswerLetter}");
        System.Console.WriteLine($"Q4:{q4.questionText}, {q4.optionA}, {q4.optionB}, {q4.optionC}, {q4.optionD}, {q4.correctAnswerLetter}");
        
        System.Console.ReadKey();
    }
}