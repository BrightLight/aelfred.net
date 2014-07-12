# Ælfred.Net

Ælfred.Net is a .NET port of the Ælfred (http://saxon.sourceforge.net/aelfred.html) XML Parser.

Ælfred.Net is SAX2-compatible a non-validating XML parser.

## Installation

To install [Ælfred.Net](https://www.nuget.org/packages/aelfred.net) from the [NuGet Gallery](http://www.nuget.org), run the following in the [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console)
```powershell
PM> Install-Package AElfred.Net
```

# Configuration

To use Ælfred.Net set `xmlReaderFactoryType` to `AELFred.Net.XmlReaderFactory, AElfred.Net`

``` XML
<configSections>
  <section name="sax" type="Sax.Net.Helpers.SaxConfigurationSection, Sax.Net"/>
</configSections>
<sax xmlReaderFactoryType="AELFred.Net.XmlReaderFactory, AElfred.Net"/>
```

# Usage

See [SAX.Net](http://www.github.com/rasmusjp/sax.net#usage)


# License

Ælfred.Net is licensed under [LGPL V3](LICENSE).

Microstar's (which no longer exists) original terms and conditions:

AElfred, Version 1.2
Microstar's Java-Based XML Parser
Copyright (c) 1997, 1998 by Microstar Software Ltd.
Home Page: http://www.microstar.com/XML/

AElfred is free for both commercial and non-commercial use and redistribution, provided that Microstar's copyright and disclaimer are retained intact. You are free to modify AElfred for your own use and to redistribute AElfred with your modifications, provided that the modifications are clearly documented.

DISCLAIMER

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of merchantability or fitness for a particular purpose. Please use it AT YOUR OWN RISK.
