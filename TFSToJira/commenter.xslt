<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" >
  <xsl:output method = "text"/>
  <xsl:template match="/" >
    <xsl:text>Changeset [</xsl:text><xsl:value-of select="//Number"/><xsl:text>|</xsl:text><xsl:value-of select="//Artifact[@ArtifactType='Changeset']/Url" /><xsl:text>] by [~</xsl:text><xsl:value-of select="substring(//Committer,5)"/><xsl:text>]: </xsl:text>
    <xsl:value-of select="//Comment" /> 
  </xsl:template>
</xsl:stylesheet>