<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <html>
        <body>
          <table border ="1">
            <tr>
              <th>Brand</th>
              <th>Size</th>
              <th>Material</th>
              <th>Colour</th>
              <th>Travel</th>
              <th>Wheelsize</th>
            </tr>
            <xsl:for-each select="bikes/bike">
              <tr>
                <td>
                  <xsl:value-of select="@brand"/>
                </td>
                <td>
                  <xsl:value-of select="@size"/>
                </td>
                <td>
                  <xsl:value-of select="@material"/>
                </td>
                <td>
                  <xsl:value-of select="@colour"/>
                </td>
                <td>
                  <xsl:value-of select="@travel"/>
                </td>
                <td>
                  <xsl:value-of select="@wheelsize"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
