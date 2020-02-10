// ----------------------------------------------------------------------
// <author>Samyn Axel</author>
// <date>10/02/2020</date>
// <project>CaseConverter</project>
// ----------------------------------------------------------------------

namespace CaseConverter.Converters
{
  using System.Collections.Generic;
  using System.Globalization;
  using System.Linq;
  using Utils;

  public class SpaceCaseConverter : ICaseConverter
  {
    public string Convert(IEnumerable<string> words)
    {
      if (words == null)
      {
        return string.Empty;
      }

      return string.Join(" ", words.Select(word => StringUtil.ToFirstUpper(word)));
    }
  }
}