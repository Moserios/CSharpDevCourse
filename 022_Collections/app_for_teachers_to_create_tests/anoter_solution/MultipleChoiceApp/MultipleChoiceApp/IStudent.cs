using System;
using System.Collections.Generic;

namespace MultipleChoiceApp
{
 public interface IStudent
 {
  int RollNo { get; set; }

  string StudentName { get; set; }

  List<ITestPaper> TestPapers { get; set; }
 }
}
