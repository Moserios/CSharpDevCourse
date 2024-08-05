using System;
using System.Collections.Generic;

namespace MultipleChoiceApp
{
 public interface IQuestion
 {
  string QuestionText { get; set; }

  List<IOption> Options { get; set; }

  char CorrectAnswerLetter { get; set; }

  char OptionSelectedByStudent { get; set; }

  int MarksSecured { get; set; }
 }
}
