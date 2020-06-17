using System;
using System.ComponentModel.DataAnnotations;

namespace cf_Sunset.Models
{
  public class SkylineModel
  {
    [Required]
    [DataType(DataType.Text,ErrorMessage="Building Height data is invalid.")]
    [RegularExpression(@"[-+]?(?:[0-9]+,)*[0-9]+(?:\.[0-9]+)?",ErrorMessage="Building Height format is invalid. It must be in the format #,#,#,#")]
    public string skylineString {get; set;}
  }

}

