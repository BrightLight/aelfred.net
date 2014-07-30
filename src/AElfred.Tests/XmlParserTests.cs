namespace AElfred.Net.Tests {
  using System.IO;
  using System.Text;

  using Xunit;

  public class XmlParserTests {

    [Fact]
    public void CanDecodeUTF8() {
      const string input = "<xml>\u00E6\u00F1\u00FE</xml>";

      XmlParser parser = new XmlParser();
      SAXDriver driver = new SAXDriver();
      parser.setHandler(driver);

      using (TestHandler handler = new TestHandler()) {
        driver.ContentHandler = handler;
        using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(input))) {
          parser.DoParse(null, null, null, stream, null);
        }

        Assert.Equal("\u00E6\u00F1\u00FE", handler.OutCharacters.ToString());
      }
    }
  }
}
