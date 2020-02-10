using CaseConverter.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CaseConverter.Converters
{
  /// <summary>
  /// <see cref="SpaceCaseConverter"/>のテストクラスです。
  /// </summary>
  [TestClass]
    public class SpaceCaseConverterTest : CaseConverterTestBase<SpaceCaseConverter>
    {
        [TestMethod]
        public void ConvertTest()
        {
            ConvertTest("Hoge Fuga Piyo", "Hoge", "H");
        }
    }
}
