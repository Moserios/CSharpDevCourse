using System.Collections.Generic;

namespace MultipleChoiceApp
{
 public class Question : IQuestion
 {
  private string questionText;
  private List<IOption> options;
  private char correctAnswerLetter;
  private char optionSelectedByStudent;
  private int marksSecured;

  public string QuestionText { get => questionText; set => questionText = value; }

  public List<IOption> Options { get => options; set => options = value; }

  public char CorrectAnswerLetter { get => correctAnswerLetter; set => correctAnswerLetter = value; }

  public char OptionSelectedByStudent { get => optionSelectedByStudent; set => optionSelectedByStudent = value; }

  public int MarksSecured { get => marksSecured; set => marksSecured = value; }
 }
}
