<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:Extension="urn:Extension" exclude-result-prefixes="msxsl Extension" >
  <xsl:output method="html" indent="yes" doctype-public="html" />
  <xsl:variable name="Tracking" select="/Properties/EmailTracking" />
  <xsl:variable name="Online" select="/Properties/Online" />
  <xsl:variable name="Vereniging" select="/Properties/ClubCloud_Vereniging" />
  <xsl:variable name="Gebruiker" select="/Properties/ClubCloud_Gebruiker" />
  <msxsl:script implements-prefix="Extension" language="C#">
    <![CDATA[
      public string Year()
      {
          return DateTime.Now.Year.ToString(); 
      }

      public string Now()
      {
          return DateTime.Now.ToString(); 
      }

    ]]>
  </msxsl:script>
  <xsl:template match="/">
    <html>
      <head>
        <title>
          <xsl:value-of select="Properties/Content/Subject" disable-output-escaping="yes" />
        </title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <meta name="viewport" content="width=500, initial-scale=1" />
        <style type="text/css">
          html
          {
          width: 100%;
          }

          .ClubCloud ::-moz-selection{background:#297DED;color:#646464;}
          .ClubCloud ::selection{background:#297DED;color:#646464;}

          .ClubCloud body {
          background-color: #eaeaea;
          margin: 0;
          padding: 0;
          }

          .ClubCloud .ReadMsgBody
          {
          width: 100%;
          background-color: #eaeaea;
          }
          .ClubCloud .ExternalClass
          {
          width: 100%;
          background-color: #eaeaea;
          }

          .ClubCloud a {
          color:#616161;
          text-decoration:none;
          font-weight:normal;
          font-style: normal;
          }
          .ClubCloud a:hover {
          color:#646464;
          text-decoration:none;
          font-weight:normal;
          font-style: normal;
          transition: all .25s ease-in-out;
          }

          .ClubCloud a.button.big {
          font-size: 15px;
          padding: 8px 20px;
          background-color: #0072C6;
          margin: 5px;
          }


          .ClubCloud p,
          .ClubCloud div {
          margin: 0 !important;
          color:#616161;
          }
          .ClubCloud table {
          border-collapse: collapse;
          }

          @media only screen and (max-width: 600px)  {
          .ClubCloud body { width: auto !important; }
          .ClubCloud table table{width:100% !important; }
          .ClubCloud table[class="table-wrapper"] {width: 440px !important; margin: 0 auto !important; background-repeat: repeat-y;}

          .ClubCloud table[class="table-inner"] {width: 400px !important;  margin: 0 auto !important;}
          .ClubCloud table[class="full"] {width: 400px !important;  margin: 0 auto !important;}
          .ClubCloud td[class="center"] {text-align: center !important;}
          .ClubCloud table[class="center"] {text-align: center !important;}

          .ClubCloud img[class="img_scale"] {width: 100% !important; height: auto !Important;}
          .ClubCloud img[class="divider"] {width: 100% !important; height: 10px !Important;}

          }


          @media only screen and (max-width: 480px)  {
          .ClubCloud body { width: auto !important; }
          .ClubCloud table table{width:100% !important; }
          .ClubCloud table[class="table-wrapper"] {width: 280px !important; margin: 0 auto !important;}
          .ClubCloud table[class="table-inner"] {width: 240px !important;  margin: 0 auto !important;}
          .ClubCloud table[class="full"] {width: 240px !important;  margin: 0 auto !important;}
          .ClubCloud td[class="center"] {text-align: center !important;}
          .ClubCloud table[class="center"] {text-align: center !important;}

          .ClubCloud img[class="img_scale"] {width: 100% !important; height: auto !Important;}
          .ClubCloud img[class="divider"] {width: 100% !important; height: 10px !Important;}

          }
          @media only screen and (max-width: 420px)  {
          .ClubCloud body { width: auto !important; }
          .ClubCloud table table{width:100% !important; }
          .ClubCloud table[class="table-wrapper"] {width: 220px !important; margin: 0 auto !important;}
          .ClubCloud table[class="table-inner"] {width: 200px !important;  margin: 0 auto !important;}
          .ClubCloud table[class="full"] {width: 220px !important;  margin: 0 auto !important;}
          .ClubCloud td[class="center"] {text-align: center !important;}
          .ClubCloud table[class="center"] {text-align: center !important;}

          .ClubCloud img[class="img_scale"] {width: 100% !important; height: auto !Important;}
          .ClubCloud img[class="divider"] {width: 100% !important; height: 10px !Important;}

          }

          @media only screen and (max-width: 320px)  {
          .ClubCloud body { width: auto !important; }
          .ClubCloud table table{width:100% !important; }
          .ClubCloud table[class="table-wrapper"] {width: 180px !important; margin: 0 auto !important;}
          .ClubCloud table[class="table-inner"] {width: 140px !important;  margin: 0 auto !important;}
          .ClubCloud table[class="full"] {width: 140px !important;  margin: 0 auto !important;}
          .ClubCloud td[class="center"] {text-align: center !important;}
          .ClubCloud table[class="center"] {text-align: center !important;}

          .ClubCloud img[class="img_scale"] {width: 100% !important; height: auto !Important;}
          .ClubCloud img[class="divider"] {width: 100% !important; height: 10px !Important;}

          }

        </style>
      </head>
      <body class="ClubCloud" style="padding: 0; margin: 0;">
        <xsl:call-template name="formatGoogleCollect" />
        <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" style="padding: 0; margin: 0;">
          <tr>
            <td align="center">
              <xsl:if test="$Online/WebVersion != ''">
                <a name="Online bekijken" id="Online bekijken" media="all" style="color:#297DED; background: none;">
                  <xsl:attribute name="href">
                    <xsl:call-template name="formatGoogleTrack">
                      <xsl:with-param name="url" select="$Online/WebVersion" />
                    </xsl:call-template>
                  </xsl:attribute>
                  Online bekijken
                </a>
              </xsl:if>
              <table bgcolor="transparent" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                <tr>
                  <td align="center">
                    <xsl:for-each select="Properties/Elements" >
                      <xsl:apply-templates select="."  />
                    </xsl:for-each>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
        </table>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="HEADER">
    <!-- START OF HEADER BLOCK-->
    <table data-templateapp="Header" bgcolor="#297DED" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td bgcolor="#297DED" align="center" style="">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#297DED" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <!-- START OF VERTICAL SPACER-->
                  <tr>
                    <td height="10" style="padding:0; line-height: 0;">

                    </td>
                  </tr>
                  <!-- END OF VERTICAL SPACER-->

                  <tr>
                    <td>
                      <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top">

                            <!-- START OF LOGO-->
                            <table width="140" border="0" align="left" cellpadding="0" cellspacing="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td class="center" align="left" style="margin: 0; text-transform: uppercase; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;">
                                  <span>
                                    <a style="color:#297DED; background: none;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img src="https://www.clubcloud.nl/images/logo.png" alt="ClubCloud : De slimme keuze voor uw vereniging" width="128" border="0" style="padding-left:8px; display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF LOGO-->

                            <!-- START OF SPACER-->
                            <table width="10" border="0" align="left" cellpadding="0" cellspacing="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="20" style="line-heigh:0;">
                                </td>
                              </tr>
                            </table>
                            <!-- START OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table border="0" align="left" cellpadding="0" cellspacing="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF TEXT-->
                              <tr>
                                <td class="center" align="left" style="padding-top: 30px; padding-right:8px; margin: 10; font-weight:bold; font-size:24px ; color:#ffffff; font-family: 'Open Sans', Arial, sans-serif; line-height: 18px;mso-line-height-rule: exactly;">
                                  ClubCloud : De slimme keuze voor <xsl:value-of select="$Vereniging/Naam"/>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>
                    </td>
                  </tr>

                  <!-- START OF VERTICAL SPACER-->
                  <tr>
                    <td height="10" style="padding:0; line-height: 0;">
                    </td>
                  </tr>
                  <!-- END OF VERTICAL SPACER-->
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF HEADER BLOCK-->
  </xsl:template>
  <xsl:template match="FEATURED_AREA">
    <!-- START OF FEATURED AREA BLOCK-->
    <table data-templateapp="Featured Area" bgcolor="#297DED" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td bgcolor="#297DED" align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#f9f9f9" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" >
                  <tr>
                    <td>
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="middle" style="padding: 90px 0px;">
                            <table width="100%" border="0" align="left" cellpadding="0" cellspacing="0">
                              <!-- START OF HEADING-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 20px ; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:30px; line-height:42px; mso-line-height-rule: exactly;">
                                  ClubCloud
                                  <br />
                                  De slimme keuze voor uw vereniging
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF WHITE DIVIDER-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 15px ;  margin: 0; font-weight:normal; font-size:12px ; color:#646464; font-family:  'Open Sans', Arial, sans-serif; line-height: 1;">
                                  <span>
                                    <img src="https://www.clubcloud.nl/images/white-divider.png" width="100" height="1" style="display:inline-block;" />
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF WHITE DIVIDER-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td class="center" align="center" style="padding: 0; margin: 0; font-weight:normal; font-size:14px ; color:#646464; font-family:  'Open Sans', Arial, sans-serif; line-height: 24px;mso-line-height-rule: exactly;">
                                  ClubCloud is de volgende generatie oplossing voor tennis.
                                  Met ClubCloud komen alle facetten van tennis samen in één bundel.
                                  Ontdek de nieuwe stap in tennis !!
                                </td>
                              </tr>
                              <!-- END OF TEXT-->
                            </table>
                          </td>
                        </tr>
                      </table>
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF FEATURED AREA BLOCK-->
  </xsl:template>
  <xsl:template match="CENTRECOURT">
    <!-- START OF INTRO BLOCK-->
    <table data-templateapp="Intro Block" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#ffffff" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 60px; padding-bottom: 60px;">
                            <table class="full" align="left" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td align="center" style="padding-bottom: 30px; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#767676; font-size:18px; line-height:28px; mso-line-height-rule: exactly;">
                                  <span>
                                    Digitaal Afhangen
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF QUOTE IMAGE-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 10px ;  margin: 0; font-weight:normal; font-size:12px ; color:#ffffff; font-family:  'Open Sans', Arial, sans-serif; line-height: 1;">
                                  <span>
                                    <img src="https://www.clubcloud.nl/images/quote.png" width="18" height="17" style="display:inline-block;" />
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF QUOTE IMAGE-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td align="center" style="padding-top: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Met een Afhangbord kan je jouw leden nog meer van dienst zijn. Leden kunnen eenvoudig een baan afhangen op het tennispark. Rommelen met speeltijden en een slechte baanbezetting ondanks de drukte, behoren tot het verleden.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td align="center" valign="top" style="padding-top: 20px;">
                                  <table border="0" align="center" cellpadding="0" cellspacing="0" style="margin: 0;">
                                    <tr>
                                      <td align="center" valign="middle" style="padding-top: 3px; padding-right: 15px; font-weight: normal; font-size: 13px; line-height: 0; font-family:  'Open Sans', Arial, sans-serif; color:#297DED; margin: 0 !important; ">
                                        <span>
                                          <img src="https://www.clubcloud.nl/images/left-stripe.png" width="40" height="1" style="display:inline-block;" />
                                        </span>
                                      </td>

                                      <td align="center" valign="top" style="padding: 0; font-weight: normal; font-size: 13px; line-height: 18px; font-family:  'Open Sans', Arial, sans-serif; color:#297DED; margin: 0 !important; ">
                                        <a href="#" style="background: none; font-weight: normal; font-style: normal; color:#297DED;">
                                          CentreCourt - centrecourt.nl
                                        </a>
                                      </td>

                                      <td align="center" valign="middle" style="padding-top: 3px; padding-left: 15px; font-weight: normal; font-size: 13px; line-height: 0; font-family:  'Open Sans', Arial, sans-serif; color:#297DED; margin: 0 !important; ">
                                        <span>
                                          <img src="https://www.clubcloud.nl/images/right-stripe.png" width="40" height="1" style="display:inline-block;" />
                                        </span>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                          </td>
                        </tr>
                      </table>
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF INTRO BLOCK-->
  </xsl:template>
  <xsl:template match="HALF_COLUMN_FEATURES">
    <!-- START OF 1/2 COL FEATURES BLOCK-->
    <table data-templateapp="1/2 Column Features" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#ffffff" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <!-- START OF HEADING TABLE-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 0px; padding-bottom: 0px;">
                            <table class="full" align="left" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 0px; text-transform: uppercase; font-weight: bold;font-family:  'Open Sans', Arial, sans-serif; color:#767676; font-size:18px; line-height:28px; mso-line-height-rule: exactly;">
                                  <span>
                                    Onderdelen
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->
                            </table>
                          </td>
                        </tr>
                      </table>
                      <!-- END OF HEADING TABLE-->

                      <!-- START OF #1 ROW FEATURES-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 40px; padding-bottom: 30px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="255" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="32" valign="top" class="center" align="left" style="padding-right: 20px; font-weight: normal;font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:24px; line-height:34px; ">
                                  <span>
                                    <img src="https://www.clubcloud.nl/images/FeatureIcon_TeamWebsite_60x40.png" width="32" />
                                  </span>
                                </td>

                                <td width="203" valign="middle" class="center" align="left">
                                  <table cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td align="left" style="padding: 0px; text-transform: uppercase; font-weight: bold;font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                        <span>
                                          Digitaal Afhangen
                                        </span>
                                      </td>
                                    </tr>

                                    <tr>
                                      <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          Digitaal afhangen hoort bij een moderne tennis vereniging. Via ClubCloud kunt u digitaal gaan afhangen via een groot en gebruiksvriendelijk scherm of via mobiele applicaties.
                                        </span>
                                      </td>
                                    </tr>

                                    <!-- START BUTTON-->
                                    <tr>
                                      <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <table align="left" cellpadding="0" cellspacing="0" border="0">
                                          <tr>
                                            <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                              <span>
                                                <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                              </span>
                                            </td>

                                            <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                              <span>
                                                <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                                  <xsl:attribute name="href">
                                                    <xsl:call-template name="formatGoogleTrack">
                                                      <xsl:with-param name="url">https://www.clubcloud.nl/afhangen.aspx</xsl:with-param>
                                                    </xsl:call-template>
                                                  </xsl:attribute>
                                                  Meer weten
                                                </a>
                                              </span>
                                            </td>
                                          </tr>
                                        </table>
                                      </td>
                                    </tr>
                                    <!-- END BUTTON-->
                                  </table>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="10" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="40"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="255" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="32" valign="top" class="center" align="left" style="padding-right: 20px; font-weight: normal;font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:24px; line-height:34px; ">
                                  <span>
                                    <img src="https://www.clubcloud.nl/images/business-enterprise-reporting.gif" width="32"/>
                                  </span>
                                </td>

                                <td width="203" valign="middle" class="center" align="left">
                                  <table cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td align="left" style="padding: 0px; text-transform: uppercase; font-weight: bold;font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                        <span>
                                          ClubCloud Beheer
                                        </span>
                                      </td>
                                    </tr>

                                    <tr>
                                      <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          ClubCloud helpt bij een beter beheer. Krachtige en gebruiksvriendelijke verenigingsbeheer, ledenbeheer, communicatie etc..
                                        </span>
                                      </td>
                                    </tr>

                                    <!-- START BUTTON-->
                                    <tr>
                                      <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <table align="left" cellpadding="0" cellspacing="0" border="0">
                                          <tr>
                                            <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                              <span>
                                                <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                              </span>
                                            </td>

                                            <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                              <span>
                                                <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                                  <xsl:attribute name="href">
                                                    <xsl:call-template name="formatGoogleTrack">
                                                      <xsl:with-param name="url">https://www.clubcloud.nl/beheer.aspx</xsl:with-param>
                                                    </xsl:call-template>
                                                  </xsl:attribute>
                                                  Meer weten
                                                </a>
                                              </span>
                                            </td>
                                          </tr>
                                        </table>
                                      </td>
                                    </tr>
                                    <!-- END BUTTON-->
                                  </table>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>
                      <!-- END OF #1 ROW FEATURES-->

                      <!-- START OF #2 ROW FEATURES-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 0px; padding-bottom: 0px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="255" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="32" valign="top" class="center" align="left" style="padding-right: 20px; font-weight: normal;font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:24px; line-height:34px; ">
                                  <span>
                                    <img src="https://www.clubcloud.nl/images/FeatureIcon_Group_60x40.png" width="32" />
                                  </span>
                                </td>

                                <td width="203" valign="middle" class="center" align="left">
                                  <table cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td align="left" style="padding: 0px; text-transform: uppercase; font-weight: bold;font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                        <span>
                                          ClubCloud Mijn
                                        </span>
                                      </td>
                                    </tr>

                                    <tr>
                                      <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          De ClubCloud Mijn omgeving geeft uw leden inzicht en de mogelijkheden om gegevens in te zien en te wijzigen.
                                        </span>
                                      </td>
                                    </tr>

                                    <!-- START BUTTON-->
                                    <tr>
                                      <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <table align="left" cellpadding="0" cellspacing="0" border="0">
                                          <tr>
                                            <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                              <span>
                                                <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                              </span>
                                            </td>

                                            <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                              <span>
                                                <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                                  <xsl:attribute name="href">
                                                    <xsl:call-template name="formatGoogleTrack">
                                                      <xsl:with-param name="url">https://www.clubcloud.nl/mijn.aspx</xsl:with-param>
                                                    </xsl:call-template>
                                                  </xsl:attribute>
                                                  Meer weten
                                                </a>
                                              </span>
                                            </td>
                                          </tr>
                                        </table>
                                      </td>
                                    </tr>
                                    <!-- END BUTTON-->
                                  </table>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="10" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="40"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="255" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="32" valign="top" class="center" align="left" style="padding-right: 20px; font-weight: normal;font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:24px; line-height:34px; ">
                                  <span>
                                    <img src="https://www.clubcloud.nl/images/FeatureIcon_Support_60x40.png" width="32" />
                                  </span>
                                </td>

                                <td width="203" valign="middle" class="center" align="left">
                                  <table cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td align="left" style="padding: 0px; text-transform: uppercase; font-weight: bold;font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                        <span>
                                          ClubCloud Kosten
                                        </span>
                                      </td>
                                    </tr>

                                    <tr>
                                      <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          ClubCloud hanteert een eenvoudig en transparant model. Geen variabele kosten, een vast bedrag voor alles.
                                        </span>
                                      </td>
                                    </tr>

                                    <!-- START BUTTON-->
                                    <tr>
                                      <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <table align="left" cellpadding="0" cellspacing="0" border="0">
                                          <tr>
                                            <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                              <span>
                                                <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                              </span>
                                            </td>

                                            <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                              <span>
                                                <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                                  <xsl:attribute name="href">
                                                    <xsl:call-template name="formatGoogleTrack">
                                                      <xsl:with-param name="url">https://www.clubcloud.nl/kosten.aspx</xsl:with-param>
                                                    </xsl:call-template>
                                                  </xsl:attribute>
                                                  Meer weten
                                                </a>
                                              </span>
                                            </td>
                                          </tr>
                                        </table>
                                      </td>
                                    </tr>
                                    <!-- END BUTTON-->
                                  </table>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>
                      <!-- END OF #2 ROW FEATURES-->

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF 1/2 COL FEATURES BLOCK-->
  </xsl:template>
  <xsl:template match="THIRD_COLUMN_SCREENSHOT_PRODUCTS">
    <!-- START OF 1/3 COLUMN SCREENSHOT PRODUCTS BLOCK-->
    <table data-templateapp="1/3 Column Screenshot Products" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#297DED" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <!-- START OF HEADING TABLE-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 0px; padding-bottom: 0px;">
                            <table class="full" align="left" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 0px; text-transform: uppercase; font-weight: bold;font-family:  'Open Sans', Arial, sans-serif; color:#ffffff; font-size:18px; line-height:28px; mso-line-height-rule: exactly;">
                                  <span>
                                    Our Featured Works
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->
                            </table>
                          </td>
                        </tr>
                      </table>
                      <!-- END OF HEADING TABLE-->

                      <!-- START OF #1 ROW PPRODUCT TABLE-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 30px; padding-bottom: 30px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="160" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="center" style="margin: 0; font-size:13px ; color:#adb2bb; font-family:  'Open Sans', Arial, sans-serif; line-height: 0;">
                                  <span>
                                    <a style="color:#0079ff;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img src="https://www.clubcloud.nl/images/portfolio1.png" alt="product1" width="160" height="107" border="0" style="display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->

                              <!-- START OF CAPTION-->
                              <tr>
                                <td width="160" class="caption" align="center" style="background: url('https://www.clubcloud.nl/images/caption-bg.png')#297DED no-repeat center; margin: 0; padding: 5px 10px; font-size:14px ; color:#ffffff; font-family:  'Open Sans', Arial, sans-serif; line-height: 24px;">
                                  <span>
                                    Some caption
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF CAPTION-->
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="30" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="30"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF MIDDLE COLUMN-->
                            <table class="full" align="left" width="160" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="center" style="margin: 0; font-size:13px ; color:#adb2bb; font-family:  'Open Sans', Arial, sans-serif; line-height: 0;">
                                  <span>
                                    <a style="color:#0079ff;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img src="https://www.clubcloud.nl/images/portfolio2.png" alt="product2" width="160" height="107" border="0" style="display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->

                              <!-- START OF CAPTION-->
                              <tr>
                                <td width="160" class="caption" align="center" style="background: url('https://www.clubcloud.nl/images/caption-bg.png')#297DED no-repeat center; margin: 0; padding: 5px 10px; font-size:14px ; color:#ffffff; font-family:  'Open Sans', Arial, sans-serif; line-height: 24px;">
                                  <span>
                                    Some caption
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF CAPTION-->
                            </table>
                            <!-- END OF MIDDLE COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="10" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="30"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="160" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="center" style="margin: 0; font-size:13px ; color:#adb2bb; font-family:  'Open Sans', Arial, sans-serif; line-height: 0;">
                                  <span>
                                    <a style="color:#0079ff;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img src="https://www.clubcloud.nl/images/portfolio3.png" alt="product3" width="160" height="107" border="0" style="display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->

                              <!-- START OF CAPTION-->
                              <tr>
                                <td width="160" class="caption" align="center" style="background: url('https://www.clubcloud.nl/images/caption-bg.png')#297DED no-repeat center; margin: 0; padding: 5px 10px; font-size:14px ; color:#ffffff; font-family:  'Open Sans', Arial, sans-serif; line-height: 24px;">
                                  <span>
                                    Some caption
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF CAPTION-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>
                      <!-- END OF #1 ROW PPRODUCT TABLE-->

                      <!-- START OF #2 ROW PPRODUCT TABLE-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 0px; padding-bottom: 0px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="160" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="center" style="margin: 0; font-size:13px ; color:#adb2bb; font-family:  'Open Sans', Arial, sans-serif; line-height: 0;">
                                  <span>
                                    <a style="color:#0079ff;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img src="https://www.clubcloud.nl/images/portfolio3.png" alt="product3" width="160" height="107" border="0" style="display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->

                              <!-- START OF CAPTION-->
                              <tr>
                                <td width="160" class="caption" align="center" style="background: url('https://www.clubcloud.nl/images/caption-bg.png')#297DED no-repeat center; margin: 0; padding: 5px 10px; font-size:14px ; color:#ffffff; font-family:  'Open Sans', Arial, sans-serif; line-height: 24px;">
                                  <span>
                                    Some caption
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF CAPTION-->
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="30" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="30"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF MIDDLE COLUMN-->
                            <table class="full" align="left" width="160" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="center" style="margin: 0; font-size:13px ; color:#adb2bb; font-family:  'Open Sans', Arial, sans-serif; line-height: 0;">
                                  <span>
                                    <a style="color:#0079ff;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img src="https://www.clubcloud.nl/images/portfolio2.png" alt="product2" width="160" height="107" border="0" style="display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->

                              <!-- START OF CAPTION-->
                              <tr>
                                <td width="160" class="caption" align="center" style="background: url('https://www.clubcloud.nl/images/caption-bg.png')#297DED no-repeat center; margin: 0; padding: 5px 10px; font-size:14px ; color:#ffffff; font-family:  'Open Sans', Arial, sans-serif; line-height: 24px;">
                                  <span>
                                    Some caption
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF CAPTION-->
                            </table>
                            <!-- END OF MIDDLE COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="10" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="30"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="160" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="center" style="margin: 0; font-size:13px ; color:#adb2bb; font-family:  'Open Sans', Arial, sans-serif; line-height: 0;">
                                  <span>
                                    <a style="color:#0079ff;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img src="https://www.clubcloud.nl/images/portfolio1.png" alt="product1" width="160" height="107" border="0" style="display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->

                              <!-- START OF CAPTION-->
                              <tr>
                                <td width="160" class="caption" align="center" style="background: url('https://www.clubcloud.nl/images/caption-bg.png')#297DED no-repeat center; margin: 0; padding: 5px 10px; font-size:14px ; color:#ffffff; font-family:  'Open Sans', Arial, sans-serif; line-height: 24px;">
                                  <span>
                                    Some caption
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF CAPTION-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>
                      <!-- END OF #2 ROW PPRODUCT TABLE-->

                      <!-- START OF BUTTON TABLE-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 40px; padding-bottom: 0px;">
                            <table class="full" align="left" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START BUTTON-->
                              <tr>
                                <td class="center" align="center" valign="top" style="padding-top: 0; ">
                                  <table border="0" align="center" cellpadding="0" cellspacing="0" style="margin: 0;  border-radius:3px;">
                                    <tr>
                                      <td align="center" valign="middle" style="border: 1px solid #ffffff; border-radius: 5px; display:inline-block; padding: 10px 25px; font-weight: bold; font-size: 18px; line-height: 28px; font-family: 'Open Sans', Helvetica, Arial, sans-serif; color:#ffffff; margin: 0 !important; ">
                                        <a style="font-weight: bold; font-style: normal; color:#ffffff; text-decoration: none;">
                                          <xsl:attribute name="href">
                                            <xsl:call-template name="formatGoogleTrack">
                                              <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                            </xsl:call-template>
                                          </xsl:attribute>
                                          View more products
                                        </a>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                          </td>
                        </tr>
                      </table>
                      <!-- END OF BUTTON TABLE-->

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- START OF 1/3 COLUMN SCREENSHOT PRODUCTS BLOCK-->
  </xsl:template>
  <xsl:template match="HALF_COLUMN_TOP_IMAGE">
    <!-- START OF 1/2 COLUMN TOP IMAGE-->
    <table data-templateapp="1/2 Column Top Image" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#ffffff" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding:0px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="255" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td align="left" style="padding-bottom: 20px; margin: 0; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;">
                                  <span>
                                    <a style="color:#297DED; background: none;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img class="img_scale" src="https://www.clubcloud.nl/images/business-enterprise-crossplatform.gif" alt="img-255-170-1" width="255" height="170" border="0" style="display: block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF IMAGE-->

                              <!-- START OF HEADING-->
                              <tr>
                                <td align="left" style="padding-bottom: 10px; text-transform: uppercase; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                  <span>
                                    <a class="heading_link" style="background: none; color:#646464; text-decoration: none; font-style: normal; font-weight: bold;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      Moderne omgeving
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td align="left" style="padding-top: 0; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    ClubCloud werkt op alle moderne omgevingen. Computers, Tablets en Smartphones.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <table class="center" align="left" cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                        <span>
                                          <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                        </span>
                                      </td>

                                      <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                            <xsl:attribute name="href">
                                              <xsl:call-template name="formatGoogleTrack">
                                                <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                              </xsl:call-template>
                                            </xsl:attribute>
                                            Lees meer
                                          </a>
                                        </span>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="20" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="30"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="255" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td align="left" style="padding-bottom: 20px; margin: 0; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;">
                                  <span>
                                    <a style="color:#297DED; background: none;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img class="img_scale" src="https://www.clubcloud.nl/images/business-enterprise-loss.gif" alt="img-255-170-2" width="255" height="170" border="0" style="display: block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF IMAGE-->

                              <!-- START OF HEADING-->
                              <tr>
                                <td align="left" style="padding-bottom: 10px; text-transform: uppercase; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                  <span>
                                    <a class="heading_link" style="background: none; color:#646464; text-decoration: none; font-style: normal; font-weight: bold;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      Veiligheid eerst
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td align="left" style="padding-top: 0; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    ClubCloud zorgt voor een veilige omgeving voor uw gegevens en leden. Uw gegevens zijn van u. Wij stellen ze veilig en beschermen uw privacy.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <table align="left" cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                        <span>
                                          <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                        </span>
                                      </td>

                                      <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                            <xsl:attribute name="href">
                                              <xsl:call-template name="formatGoogleTrack">
                                                <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                              </xsl:call-template>
                                            </xsl:attribute>
                                            Lees meer
                                          </a>
                                        </span>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF 1/2 COLUMN TOP IMAGE-->
  </xsl:template>
  <xsl:template match="TESTIMONIAL">
    <!-- START OF TESTIMONIAL-->
    <table data-templateapp="Testimonials" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#323a42" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <!-- START OF HEADING TABLE-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding-top: 0px; padding-bottom: 30px;">
                            <table class="full" align="left" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 0px; text-transform: uppercase; font-weight: bold;font-family:  'Open Sans', Arial, sans-serif; color:#ffffff; font-size:18px; line-height:28px; mso-line-height-rule: exactly;">
                                  <span>
                                    Testimonials
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->
                            </table>
                          </td>
                        </tr>
                      </table>
                      <!-- END OF HEADING TABLE-->

                      <!-- START OF #1 ROW TESTIMONIAL TABLE-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding:0px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="255" cellpadding="0" cellspacing="0" border="0" style="border: 2px solid #50565c; border-collapse:collapse; mso-table-lspace:0pt;">
                              <tr>
                                <td class="center" align="left" style="padding: 10px 20px 0px 20px ; margin: 0; font-weight:normal; font-style:italic; font-size:13px ; color:#dfe0e0; font-family:  Georgia, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Lorem ipsum dolor sit amet, per audiam detracto ea, hendrerit aliquando eam nam labitur.
                                  </span>
                                </td>
                              </tr>

                              <tr>
                                <td class="center" align="left" style="padding: 10px 20px; margin: 0; font-weight:normal; font-size:11px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 18px;mso-line-height-rule: exactly;">
                                  <span>
                                    <a href="#" style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                      John Doe
                                    </a>
                                  </span>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="20" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="30"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="255" cellpadding="0" cellspacing="0" border="0" style="border: 2px solid #50565c; border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td class="center" align="left" style="padding: 10px 20px 0px 20px ; margin: 0; font-weight:normal; font-style:italic; font-size:13px ; color:#dfe0e0; font-family:  Georgia, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Lorem ipsum dolor sit amet, per audiam detracto ea, hendrerit aliquando eam nam labitur.
                                  </span>
                                </td>
                              </tr>

                              <tr>
                                <td class="center" align="left" style="padding: 10px 20px; margin: 0; font-weight:normal; font-size:11px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 18px;mso-line-height-rule: exactly;">
                                  <span>
                                    <a href="#" style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                      John Doe
                                    </a>
                                  </span>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>
                      <!-- END OF #1 ROW TESTIMONIAL TABLE-->

                      <!-- START OF #2 ROW TESTIMONIAL TABLE-->
                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                        <tr>
                          <td valign="top" style="padding-top: 30px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="255" cellpadding="0" cellspacing="0" border="0" style="border: 2px solid #50565c; border-collapse:collapse; mso-table-lspace:0pt;">
                              <tr>
                                <td class="center" align="left" style="padding: 10px 20px 0px 20px ; margin: 0; font-weight:normal; font-style:italic; font-size:13px ; color:#dfe0e0; font-family:  Georgia, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Lorem ipsum dolor sit amet, per audiam detracto ea, hendrerit aliquando eam nam labitur.
                                  </span>
                                </td>
                              </tr>

                              <tr>
                                <td class="center" align="left" style="padding: 10px 20px; margin: 0; font-weight:normal; font-size:11px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 18px;mso-line-height-rule: exactly;">
                                  <span>
                                    <a href="#" style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                      John Doe
                                    </a>
                                  </span>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="20" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="30"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="255" cellpadding="0" cellspacing="0" border="0" style="border: 2px solid #50565c; border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td class="center" align="left" style="padding: 10px 20px 0px 20px ; margin: 0; font-weight:normal; font-style:italic; font-size:13px ; color:#dfe0e0; font-family:  Georgia, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Lorem ipsum dolor sit amet, per audiam detracto ea, hendrerit aliquando eam nam labitur.
                                  </span>
                                </td>
                              </tr>

                              <tr>
                                <td class="center" align="left" style="padding: 10px 20px; margin: 0; font-weight:normal; font-size:11px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 18px;mso-line-height-rule: exactly;">
                                  <span>
                                    <a href="#" style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                      John Doe
                                    </a>
                                  </span>
                                </td>
                              </tr>
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>
                      <!-- END OF #2 ROW TESTIMONIAL TABLE-->

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF TESTIMONIAL-->
  </xsl:template>
  <xsl:template match="ONE_THIRD_TWO_THIRD_COLUMN_LEFT_IMAGE">
    <!-- START OF 1/3 AND 2/3 COLUMN LEFT IMAGE BLOCK-->
    <table data-templateapp="1/3 and 2/3 Column Left Image" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#ffffff" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding: 0px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="160" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="left" style="margin: 0; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;">
                                  <span>
                                    <a style="color:#297DED; background: none;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/beheer.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img class="img_scale" src="https://www.clubcloud.nl/images/business-enterprise-reporting.gif" alt="img-160-147-1" width="160" height="147" border="0" style="display: block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="20" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="40"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="350" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td align="left" style="padding-bottom: 10px; text-transform:uppercase; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#767676; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                  <span>
                                    <a class="heading_link" style="color:#646464; text-decoration: none; font-style: normal; font-weight: bold;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/beheer.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      Makkelijk is het gebruik.
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td align="left" style="padding: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Vanaf elke locatie bij uw gegevens komen en uw vereniging beheren.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <table align="left" cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                        <span>
                                          <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                        </span>
                                      </td>

                                      <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                            <xsl:attribute name="href">
                                              <xsl:call-template name="formatGoogleTrack">
                                                <xsl:with-param name="url">https://www.clubcloud.nl/beheer.aspx</xsl:with-param>
                                              </xsl:call-template>
                                            </xsl:attribute>
                                            Meer over beheer
                                          </a>
                                        </span>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF 1/3 AND 2/3 COLUMN LEFT IMAGE BLOCK-->
  </xsl:template>
  <xsl:template match="TWO_THIRD_ONE_THIRD_COLUMN_RIGHT_IMAGE">
    <!-- START OF 2/3 AND 1/3 COLUMN RIGHT IMAGE BLOCK-->
    <table data-templateapp="2/3 and 1/3 Column Right Image" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#ffffff" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding: 0px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="350" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td align="left" style="padding-bottom: 10px; text-transform:uppercase; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#767676; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                  <span>
                                    <a class="heading_link" style="color:#646464; text-decoration: none; font-style: normal; font-weight: bold;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/beheer.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      Direct verbinding met de KNLTB
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td align="left" style="padding: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    ClubCloud is direct verbonden met de ServIt omgeving. Geen mailtjes meer sturen of bestanden uploaden.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <table align="left" cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                        <span>
                                          <img align="left" src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" style="display: inline-block;" />
                                        </span>
                                      </td>

                                      <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                            <xsl:attribute name="href">
                                              <xsl:call-template name="formatGoogleTrack">
                                                <xsl:with-param name="url">https://www.clubcloud.nl/beheer.aspx</xsl:with-param>
                                              </xsl:call-template>
                                            </xsl:attribute>
                                            Meer over beheer
                                          </a>
                                        </span>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="20" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="40"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="160" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="left" style="margin: 0; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;">
                                  <span>
                                    <a style="color:#297DED; background: none;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/beheer.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img class="img_scale" src="https://www.clubcloud.nl/images/knltb_logo.png" alt="knltb_logo" width="160" height="147" border="0" style="display: block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF 2/3 AND 1/3 COLUMN RIGHT IMAGE BLOCK-->
  </xsl:template>
  <xsl:template match="CALL_TO_ACTION">
    <!-- START OF CALL TO ACTION BLOCK-->
    <table data-templateapp="Call To Action" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#ffffff" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding: 0px;">
                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 20px; text-transform:uppercase; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#ffffff; font-size:24px; line-height:34px; mso-line-height-rule: exactly;">
                                  <span>
                                    For your better email campaign
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td class="center" align="center" style="padding: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#ffffff; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Lorem ipsum dolor sit amet, elitr latine est no, aperiri euismod omnesque et sea, laudem option conceptam cu sed. Eu movet quaerendum ius, te eam solum dicit.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td class="center" align="center" valign="top" style="padding-top: 30px; ">
                                  <table border="0" align="center" cellpadding="0" cellspacing="0" style="margin: 0;  border-radius:3px;">
                                    <tr>
                                      <td align="center" valign="middle" style="display:inline-block; border: 1px solid #ffffff; border-radius: 5px; padding: 10px 25px; font-weight: bold; font-size: 18px; line-height: 28px; font-family: 'Open Sans', Helvetica, Arial, sans-serif; color:#ffffff; margin: 0 !important; ">
                                        <a href="#" style="font-weight: bold; font-style: normal; color:#ffffff; text-decoration: none;">
                                          Buy this template
                                        </a>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF CALL TO ACTION BLOCK-->
  </xsl:template>
  <xsl:template match="HALF_COLUMN_LEFT_IMAGE">
    <!-- START OF 1/2 COLUMN LEFT IMAGE BLOCK-->
    <table data-templateapp="1/2 Column Left Image" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#ffffff" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding: 0px;">
                            <!-- START OF LEFT COLUMN-->
                            <table class="full" align="left" width="255" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="left" style="margin: 0; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;">
                                  <span>
                                    <a href="#" style="color:#297DED; background: none;">
                                      <img class="img_scale" src="https://www.clubcloud.nl/images/img-255-234.png" alt="img-255-234" width="255" height="234" border="0" style="display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->
                            </table>
                            <!-- END OF LEFT COLUMN-->

                            <!-- START OF SPACER-->
                            <table width="20" align="left" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <tr>
                                <td width="100%" height="30"></td>
                              </tr>
                            </table>
                            <!-- END OF SPACER-->

                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="255" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td align="left" style="padding-bottom: 10px; text-transform:uppercase; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#767676; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                  <span>
                                    <a class="heading_link" href="#" style="color:#646464; text-decoration: none; font-style: normal; font-weight: bold;">
                                      Clean &amp; Minimalist Design
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td align="left" style="padding: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Lorem ipsum dolor sit amet, elitr latine est no, aperiri euismod omnesque et sea, laudem option conceptam cu sed.
                                  </span>
                                  <br />
                                  <br />
                                  <span>
                                    Lorem ipsum dolor sit amet, elitr latine est no, aperiri euismod omnesque et sea, laudem option conceptam cu sed.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td align="left" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <table align="left" cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                        <span>
                                          <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                        </span>
                                      </td>

                                      <td align="left" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                            <xsl:attribute name="href">
                                              <xsl:call-template name="formatGoogleTrack">
                                                <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                              </xsl:call-template>
                                            </xsl:attribute>
                                            Read More
                                          </a>
                                        </span>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF 1/2 COLUMN LEFT IMAGE BLOCK-->
  </xsl:template>
  <xsl:template match="FULL_WIDTH_COLUMN">
    <!-- START OF 1/1 (FULL WIDTH) COLUMN BLOCK-->
    <table data-templateapp="1/1 (Full Width) Column" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#ffffff" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding: 0px;">
                            <table class="full" align="left" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt;">
                              <!-- START OF IMAGE-->
                              <tr>
                                <td class="center" align="left" style="margin: 0; padding-bottom: 30px; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;">
                                  <span>
                                    <a style="color:#297DED; background: none;">
                                      <xsl:attribute name="href">
                                        <xsl:call-template name="formatGoogleTrack">
                                          <xsl:with-param name="url">https://www.clubcloud.nl/afhangen.aspx</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:attribute>
                                      <img class="img_scale" src="https://www.clubcloud.nl/images/scherm.png" alt="scherm" width="500" border="0" style="display: inline-block;" />
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- START OF IMAGE-->

                              <!-- START OF HEADING-->
                              <tr>
                                <td align="center" style="padding-bottom: 10px; text-transform:uppercase; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#767676; font-size:14px; line-height:24px; mso-line-height-rule: exactly;">
                                  <span>
                                    <a class="heading_link" href="#" style="color:#646464; text-decoration: none; font-style: normal; font-weight: bold;">
                                      De volgende stap in digitaal afhangen.
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td align="center" class="center" style="padding: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    ClubCloud maakt gebruik van een groot scherm met intuïtieve software.<br/>
                                    Alle informatie is groot en duidelijk zichtbaar.<br/>
                                    Club Informatie en eigen sponsoren groot weergegeven. <br/>
                                    Overzichtelijk baanschema's en bezetting. <br/>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td align="center" style="padding-top: 10px; margin: 0; font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <table align="center" cellpadding="0" cellspacing="0" border="0">
                                    <tr>
                                      <td width="12" align="left" valign="middle" style="padding-right: 5px;">
                                        <span>
                                          <img src="https://www.clubcloud.nl/images/link-icon.png" width="12" height="12" />
                                        </span>
                                      </td>

                                      <td align="center" valign="top" style="font-weight:normal; font-size:13px ; color:#797979; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                        <span>
                                          <a style="color:#297DED; text-decoration: none; font-style: normal; font-weight: normal;">
                                            <xsl:attribute name="href">
                                              <xsl:call-template name="formatGoogleTrack">
                                                <xsl:with-param name="url">https://www.clubcloud.nl/afhangen.aspx</xsl:with-param>
                                              </xsl:call-template>
                                            </xsl:attribute>
                                            Lees meer over afhangen
                                          </a>
                                        </span>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                          </td>
                        </tr>
                      </table>

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF 1/1 (FULL WIDTH) COLUMN BLOCK-->
  </xsl:template>
  <xsl:template match="BOTTOM_CALL_TO_ACTION">
    <!-- START OF BOTTOM CALL TO ACTION BLOCK-->
    <table data-templateapp="Bottom Call To Action" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#f9f9f9" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding: 0px;">
                            <!-- START OF RIGHT COLUMN-->
                            <table class="full" align="right" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF HEADING-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 20px;font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#616161; font-size:24px; line-height:34px; mso-line-height-rule: exactly;">
                                  <span>
                                    Stap nu over naar de volgende generatie
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td class="center" align="center" style="padding: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#616161; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Kies ook voor de nieuwe generatie voor uw vereniging. Voor maar &#8364; 240,- per jaar een complete en moderne omgeving.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->

                              <!-- START BUTTON-->
                              <tr>
                                <td class="center" align="center" valign="top" style="padding-top: 30px; ">
                                  <table border="0" align="center" cellpadding="0" cellspacing="0" style="margin: 0;  border-radius:3px;">
                                    <tr>
                                      <td align="center" valign="middle" style="border: 1px solid #616161; border-radius: 5px; display:inline-block; padding: 10px 25px; font-weight: bold; font-size: 18px; line-height: 28px; font-family: 'Open Sans', Helvetica, Arial, sans-serif; color:#616161; margin: 0 !important; ">
                                        <a style="font-weight: bold; font-style: normal; color:#616161; text-decoration: none;">
                                          <xsl:attribute name="href">
                                            <xsl:call-template name="formatGoogleTrack">
                                              <xsl:with-param name="url">https://www.clubcloud.nl/default.aspx</xsl:with-param>
                                            </xsl:call-template>
                                          </xsl:attribute>
                                          Kom snel meer te weten
                                        </a>
                                      </td>
                                    </tr>
                                  </table>
                                </td>
                              </tr>
                              <!-- END BUTTON-->
                            </table>
                            <!-- END OF RIGHT COLUMN-->
                          </td>
                        </tr>
                      </table>

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF BOTTOM CALL TO ACTION BLOCK-->
  </xsl:template>
  <xsl:template match="FOOTER">
    <!-- START OF FOOTER-->
    <table data-templateapp="Footer" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td valign="top" align="center">
                <table class="table-wrapper" bgcolor="#297DED" width="90%" border="0" align="center" cellpadding="0" cellspacing="0" style="">
                  <tr>
                    <td>
                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->

                      <table class="table-inner" width="540" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="top" style="padding: 0px;">
                            <table class="full" align="right" width="540" cellpadding="0" cellspacing="0" border="0" style="border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;">
                              <!-- START OF SOCIAL ICONS-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 10px; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#ffffff; font-size:14px; line-height:24px; ">
                                  <span>
                                    <a href="tel:0302686077" style="color:#ededed; text-decoration: none; background: none;">
                                      <span style="display: inline-block;">Telefoon: 030-2686077</span>
                                    </a>
                                    <br/>
                                    <a href="mailto:info@clubcloud.nl" style="color:#ededed; text-decoration: none; background: none;">
                                      <span style="display: inline-block;">Email: info@clubcloud.nl</span>
                                    </a>
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF SOCIAL ICONS-->

                              <!-- START OF COPYRIGHT-->
                              <tr>
                                <td class="center" align="center" style="padding: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:12px ; color:#5a646f; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    &#169; 2015 ClubCloud Alle Rechten Voorbehouden.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF COPYRIGHT-->

                            </table>
                          </td>
                        </tr>
                      </table>

                      <!-- START OF VERTICAL SPACER-->
                      <table class="table-inner" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                          <td height="60" style="padding:0; line-height: 0;">

                          </td>
                        </tr>
                      </table>
                      <!-- END OF VERTICAL SPACER-->
                    </td>
                  </tr>
                </table>

                <!-- START OF VERTICAL SPACER-->
                <table class="table-wrapper" width="540" align="center" cellpadding="0" cellspacing="0" border="0">
                  <tr>
                    <td height="60" style="padding:0; line-height: 0;">

                    </td>
                  </tr>
                </table>
                <!-- END OF VERTICAL SPACER-->
              </td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
    <!-- END OF FOOTER-->
  </xsl:template>
  <!-- Format Date function -->
  <xsl:template name="formatDate">
    <xsl:param name="dateTime" />
    <xsl:variable name="date" select="substring-before($dateTime, 'T')" />
    <xsl:variable name="year" select="substring-before($date, '-')" />
    <xsl:variable name="month" select="substring-before(substring-after($date, '-'), '-')" />
    <xsl:variable name="day" select="substring-after(substring-after($date, '-'), '-')" />
    <xsl:value-of select="concat($year, '/', $month, '/', $day)" />
  </xsl:template>
  <!-- Format Google Collect function -->
  <xsl:template name="formatGoogleCollect">
    <xsl:variable name="collecturl">
      <xsl:text disable-output-escaping="yes"><![CDATA[<img src="https://www.google-analytics.com/collect?v=1]]></xsl:text>
      <xsl:text disable-output-escaping="yes"><![CDATA[&tid=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/TrackingId" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&cid=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/ClientId" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&t=event]]></xsl:text>
      <xsl:text disable-output-escaping="yes"><![CDATA[&ec=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/CampagneMedium" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&ea=open]]></xsl:text>
      <xsl:text disable-output-escaping="yes"><![CDATA[&el=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/RecipientId" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&cs=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/CampaignSource" />
      <xsl:text disable-output-escaping="yes" ><![CDATA[&cm=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/CampagneMedium" />
      <xsl:text disable-output-escaping="yes" ><![CDATA[&cn=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/CampaignName" />
      <xsl:text disable-output-escaping="yes" ><![CDATA[" >]]></xsl:text>
    </xsl:variable>
    <xsl:value-of select="$collecturl" disable-output-escaping="yes" />
  </xsl:template>
  <!-- Format Google Track function -->
  <xsl:template name="formatGoogleTrack">
    <xsl:param name="url" />
    <xsl:variable name="trackingurl">
      <xsl:if test="$url != ''">
        <xsl:value-of select="$url" disable-output-escaping="yes"/>
      </xsl:if>
      <xsl:text disable-output-escaping="yes"><![CDATA[?utm_source=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/CampaignSource" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&utm_medium=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/CampagneMedium" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&utm_term=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/RecipientId" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&utm_campaign=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$Tracking/CampaignName" />
    </xsl:variable>
    <xsl:value-of select="$trackingurl" disable-output-escaping="yes" />
  </xsl:template>
</xsl:stylesheet>