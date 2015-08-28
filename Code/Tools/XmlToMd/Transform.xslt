<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:user="urn:my-scripts" version="1.0">
  <msxsl:script language="C#" implements-prefix="user">
    <![CDATA[
     public string GetNamespace(string value){
       if(string.IsNullOrWhiteSpace(value))
       {
           return string.Empty;
       }
       var index = value.IndexOf('(');
       if(index == -1)
       {
           index = value.Length - 1;
       }
       index = value.LastIndexOf('.', index);
       if(index == -1)
       {
          return value;
       }
       return value.Substring(2, index - 2);
     }
     public string GetMethod(string value){
       if(string.IsNullOrWhiteSpace(value))
       {
           return string.Empty;
       }
       var index = value.IndexOf('(');
       if(index == -1)
       {
           index = value.Length - 1;
       }
       index = value.LastIndexOf('.', index);
       if(index == -1)
       {
          return value;
       }
       return value.Substring(index + 1);
     }
     public string GetProperty(string value){
       if(string.IsNullOrWhiteSpace(value))
       {
           return string.Empty;
       }
       var index = value.IndexOf('(');
       if(index == -1)
       {
           index = value.Length - 1;
       }
       index = value.LastIndexOf('.', index);
       if(index == -1)
       {
          return value;
       }
       return value.Substring(index + 1);
     }
     public string GetField(string value){
       if(string.IsNullOrWhiteSpace(value))
       {
           return string.Empty;
       }
       var index = value.IndexOf('(');
       if(index == -1)
       {
           index = value.Length - 1;
       }
       index = value.LastIndexOf('.', index);
       if(index == -1)
       {
          return value;
       }
       return value.Substring(index + 1);
     }
     public string GetEvent(string value){
       if(string.IsNullOrWhiteSpace(value))
       {
           return string.Empty;
       }
       var index = value.IndexOf('(');
       if(index == -1)
       {
           index = value.Length - 1;
       }
       index = value.LastIndexOf('.', index);
       if(index == -1)
       {
          return value;
       }
       return value.Substring(index + 1);
     }
      ]]>
  </msxsl:script>
  <xsl:output method="text" omit-xml-declaration="yes" encoding="utf-8" indent="yes" media-type="text/plain" />
  <xsl:variable name="newline2" select="'&#10;&#10;'"/>
  <xsl:template match="doc">
    <xsl:apply-templates select="assembly"/>
    <xsl:apply-templates select="members"/>
  </xsl:template>
  <xsl:template match="assembly">
    <xsl:value-of select="concat('# Documentation for ', ./name/text(), $newline2)"/>
  </xsl:template>
  <xsl:template match="members">
    <xsl:apply-templates select="member"/>
  </xsl:template>
  <xsl:template match="member">
    <xsl:variable name="token" select="substring(@name, 1, 1)"/>
    <xsl:choose>
      <xsl:when test="$token = 'T'">
        <xsl:call-template name="renderType">
          <xsl:with-param name="member" select="."/>
        </xsl:call-template>
      </xsl:when>
      <xsl:when test="$token = 'M'">
        <xsl:call-template name="renderMethod">
          <xsl:with-param name="member" select="."/>
        </xsl:call-template>
      </xsl:when>
      <xsl:when test="$token = 'P'">
        <xsl:call-template name="renderProperty">
          <xsl:with-param name="member" select="."/>
        </xsl:call-template>
        <xsl:apply-templates select="param"/>
      </xsl:when>
      <xsl:when test="$token = 'F'">
        <xsl:call-template name="renderField">
          <xsl:with-param name="member" select="."/>
        </xsl:call-template>
      </xsl:when>
      <xsl:when test="$token = 'E'">
        <xsl:call-template name="renderEvent">
          <xsl:with-param name="member" select="."/>
        </xsl:call-template>
      </xsl:when>
    </xsl:choose>
  </xsl:template>
  <xsl:template match="param">
    <xsl:value-of select="concat('##### ', @name, $newline2, normalize-space(text()), $newline2)"/>
  </xsl:template>
  <xsl:template match="returns">
    <xsl:value-of select="concat('##### returns', $newline2, @name, $newline2, normalize-space(text()), $newline2)"/>
  </xsl:template>
  <xsl:template name="renderType">
    <xsl:variable name="cleanName" select="substring(@name, 3)"/>
    <xsl:value-of select="concat('## ', $cleanName, $newline2, normalize-space(./summary/text()), $newline2, '### Members', $newline2)"/>
  </xsl:template>
  <xsl:template name="renderMethod">
    <xsl:variable name="cleanName" select="user:GetMethod(@name)"/>
    <xsl:value-of select="concat('#### ', $cleanName, $newline2, normalize-space(./summary/text()), $newline2)"/>
    <xsl:apply-templates select="param"/>
    <xsl:apply-templates select="returns"/>
  </xsl:template>
  <xsl:template name="renderProperty">
    <xsl:variable name="cleanName" select="user:GetProperty(@name)"/>
    <xsl:value-of select="concat('#### ', $cleanName, $newline2, normalize-space(./summary/text()), $newline2)"/>
  </xsl:template>
  <xsl:template name="renderField">
    <xsl:variable name="cleanName" select="user:GetField(@name)"/>
    <xsl:value-of select="concat('#### ', $cleanName, $newline2, normalize-space(./summary/text()), $newline2)"/>
  </xsl:template>
  <xsl:template name="renderEvent">
    <xsl:variable name="cleanName" select="user:GetEvent(@name)"/>
    <xsl:value-of select="concat('#### ', $cleanName, $newline2, normalize-space(./summary/text()), $newline2)"/>
  </xsl:template>
</xsl:stylesheet>