using System;
using System.Collections.Generic;

namespace MultipleChoiceApp
{
 public class Student : IStudent
 {
  private int rollNo;
  private string studentName;
  private List<ITestPaper> testPapers;

  public int RollNo { get => rollNo; set => rollNo = value; }
  public string StudentName { get => studentName; set => studentName = value; }
  public List<ITestPaper> TestPapers { get => testPapers; set => testPapers = value; }
 }
}
