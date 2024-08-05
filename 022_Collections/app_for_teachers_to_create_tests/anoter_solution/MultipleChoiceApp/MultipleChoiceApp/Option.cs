using System;

namespace MultipleChoiceApp
{
 public class Option : IOption
 {
  private char optionLetter;
  private string optionText;

  public char OptionLetter { get => optionLetter; set => optionLetter = value; }

  public string OptionText { get => optionText; set => optionText = value; }
 }
}
