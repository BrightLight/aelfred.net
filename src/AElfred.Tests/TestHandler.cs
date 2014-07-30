namespace AElfred.Net.Tests {
  using System;
  using System.IO;

  public class TestHandler : DefaultHandler, IDisposable {
    public TextWriter OutCharacters;

    public TestHandler() {
      OutCharacters = new StringWriter();
    }

    public override void Characters(char[] ch, int start, int length) {
      OutCharacters.Write(ch, start, length);
    }

    public void Dispose() {
      OutCharacters.Dispose();
    }
  }
}