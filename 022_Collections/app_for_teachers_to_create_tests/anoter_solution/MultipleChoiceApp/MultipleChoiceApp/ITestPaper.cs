using System;
using System.Collections.Generic;

namespace MultipleChoiceApp
{
 public interface ITestPaper
 {
  string SubjectName { get; set; }

  string TestPaperName { get; set; }

  List<IQuestion> Questions { get; set; }
 }
}
