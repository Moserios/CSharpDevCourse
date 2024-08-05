using System;
using System.Collections.Generic;

namespace MultipleChoiceApp
{
 public class TestPaper : ITestPaper
 {
  private string subjectName;
  private string testPaperName;
  private List<IQuestion> questions;

  public string SubjectName { get => subjectName; set => subjectName = value; }

  public string TestPaperName { get => testPaperName; set => testPaperName = value; }

  public List<IQuestion> Questions { get => questions; set => questions = value; }
 }
}
