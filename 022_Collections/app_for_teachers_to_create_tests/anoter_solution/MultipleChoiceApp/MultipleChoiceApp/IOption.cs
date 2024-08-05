using System;
using System.Collections.Generic;

namespace MultipleChoiceApp
{
 public interface IOption
 {
  char OptionLetter { get; set; }

  string OptionText { get; set; }
 }
}
