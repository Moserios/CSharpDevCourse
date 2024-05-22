//The 'Question' class contains the following members:
//A public field to store questionText(string)
//A public field to store optionA(string)
//A public field to store optionB(string)
//A public field to store optionC(string)
//A public field to store optionD(string)
//A public field to store correctAnswerLetter(char). It should be either 'A' , 'B', 'C' or 'D'. Its value can't be any other than these.

//A private static field to store defaultCorrectAnswerLetter. Eg: 'X'.Its value can be any other letter. If no value is initialized into correctAnswerLetter field, then assign it to the value of defaultCorrectAnswerLetter i.e correctAnswerLetter=defaultCorrectAnswerLetter.

//A public constructor that receives no parameters. It initializes questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.

//A public constructor that receives questionText as parameter and initializes questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.

//A public constructor that initializes questionText, optionA, optionB, optionC, optionD and correctAnswerText; receive all values as parameters.

//A public method that returns true, if at least the question has two options; that means, at least two options are not null. For example, the options A, B, C are filled with some text; but the option D is null. So there are three options in the question. Our requirement is, at least there should be two options. So this question is 'valid'. So the method should return true in this case.



using System;
using System.Diagnostics.Eventing.Reader;

//class Question
//{
//    public string questionText;
//    public string optionA;
//    public string optionB;
//    public string optionC;
//    public string optionD;
//    public char correctAnswerLetter;
//    private static char defaultCorrectAnswerLetter = 'X';
public class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter = 'O';
    private static char defaultCorrectAnswerLetter = 'X';


    //    public Question()
    //    {
    //        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
    //    }
    public Question()
    {
        this.questionText = null;
        this.optionA = null;
        this.optionB = null;
        this.optionC = null;
        this.optionD = null;

        if (this.correctAnswerLetter == 'O')
        {
            this.correctAnswerLetter = Question.defaultCorrectAnswerLetter;
        }
    }

    //    public Question(string questionText)
    //    {
    //        //TO DO: Initialize questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
    //    }
    public Question(string questionText)
    { 
        this.questionText = questionText;
        this.optionA = null;
        this.optionB = null;
        this.optionC = null;
        this.optionD = null;
        if (this.correctAnswerLetter == 'O')
        {
            this.correctAnswerLetter = Question.defaultCorrectAnswerLetter;
        }
    }


    //    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    //    {
    //        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD and correctAnswerText. Validate the value of correctAnswerLetter. It should either 'A', 'B', 'C' or 'D' only
    //    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        this.questionText = questionText;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.optionD = optionD;

        if(correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D')
        { 
            this.correctAnswerLetter = correctAnswerLetter; 
        }
        else
        {
            System.Console.WriteLine($"Only value A, B, C or D is possible as Correct Answer Letter. You provided letter {correctAnswerLetter}.");
            this.correctAnswerLetter = Question.defaultCorrectAnswerLetter;
        }
    }



    //    public bool AreOptionsValid()
    //    {
    //        //TO DO: Return true, if at least two options are not null
    //    }
    //}
    public bool validQuestion()
    {
        int questionCount = 0;
        string[] options = {this.optionA, this.optionB, this.optionC, this.optionD};
        for(int i = 0; i < options.Length; i++)
        {
            if (options[i] != null)
            {
                questionCount += 1;
            }
        }

        if (questionCount >= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}