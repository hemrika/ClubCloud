<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:Extension="urn:Extension" exclude-result-prefixes="msxsl Extension" >
	<xsl:output method="html" indent="yes" doctype-public="html" />
	<xsl:variable name="Tracking" select="/Properties/Tracking"/>
	<xsl:variable name="Online" select="/Properties/Online"/>
	<xsl:variable name="Vereniging" select="/Properties/ClubCloud_Vereniging"/>
	<xsl:variable name="Gebruiker" select="/Properties/ClubCloud_Gebruiker"/>
	<xsl:variable name="Aanmelden" select="/Properties/Aanmelden"/>
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
				<meta name="viewport" content="width=device-width" />
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
				<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" style="padding: 0; margin: 0;">
					<tr>
						<td align="center">
              <xsl:if test="$Online/WebVersion != ''">
                <xsl:variable name="url" >
                  <xsl:text disable-output-escaping="yes"><![CDATA[<a name="Online bekijken" id="online bekijken" media="all" href="]]></xsl:text>
                  <xsl:value-of disable-output-escaping="yes" select="$Online/WebVersion" />
                  <xsl:text disable-output-escaping="yes" ><![CDATA[" > Online bekijken </a>]]></xsl:text>
                </xsl:variable>
                <xsl:value-of select="$url" disable-output-escaping="yes" />
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
				<xsl:call-template name="formatGoogleCollect" >
					<xsl:with-param name="TrackingId" select="$Tracking/TrackingId" />
					<xsl:with-param name="ClientId" select="$Tracking/ClientId" />
					<xsl:with-param name="RecipientId" select="$Tracking/RecipientId" />
					<xsl:with-param name="CampaignSource" select="$Tracking/CampaignSource" />
					<xsl:with-param name="CampaignName" select="$Tracking/CampaignName" />
				</xsl:call-template>
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
                    <td height="10" style="padding:0; line-height: 0;"><!-- VERTICAL SPACER--></td>
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
                                    <a href="https://www.clubcloud.nl/default.aspx" style="color:#297DED; background: none;">
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
                                <td class="center" align="left" style="padding-top: 20px; padding-right:8px; margin: 10; font-weight:bold; font-size:18px ; color:#ffffff; font-family: 'Open Sans', Arial, sans-serif; line-height: 18px;mso-line-height-rule: exactly;">
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
                      <table class="table-inner" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
                        <tr>
                          <td valign="middle" style="padding: 90px 0px;">
                            <table width="100%" border="0" align="left" cellpadding="0" cellspacing="0">
                              <!-- START OF HEADING-->
                              <tr>
                                <td class="center" align="center" style="padding-bottom: 20px ; font-weight: bold; font-family:  'Open Sans', Arial, sans-serif; color:#646464; font-size:30px; line-height:42px; mso-line-height-rule: exactly;">
                                    ClubCloud
                                    <br />
                                    De slimme keuze voor <xsl:value-of select="$Vereniging/Naam"/> ( <xsl:value-of select="$Vereniging/Nummer"/> )
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
                                    Bedankt voor het aanmelden bij ClubCloud.<br/>
                                    Er zal spoedig contact met u worden opgenomen.<br/>
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
	<xsl:template match="VERENIGING">
		<!-- START OF VERENIGING BLOCK-->
		<table data-templateapp="Vereniging Block" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
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
											<td align="center" valign="top" style="padding-top: 20px;">
											<table border="0" align="center" cellpadding="0" cellspacing="0" style="margin: 0;">
												<tr>
													<td align="center" style="padding-bottom: 3px; font-weight: bold; font-family: 'Open Sans', Arial, sans-serif; color: #767676; font-size: 24px; line-height: 42px; mso-line-height-rule: exactly;">
													Aanmelding voor <xsl:value-of select="$Vereniging/Naam"/> ( <xsl:value-of select="$Vereniging/Nummer"/> )
													</td>
												</tr>
											</table>
											</td>
										</tr>
										<tr>
											<td>
											<table class="table-inner" align="center" cellpadding="0" cellspacing="0" border="0">
												<tr>
													<td height="20" style="padding: 0; line-height: 0;">
													</td>
												</tr>
											</table>
											</td>
										</tr>
										<tr>
											<td align="center" style="padding-top: 0px; margin: 0; font-weight: normal; font-weight: normal; font-size: 13px; color: #797979; font-family: 'Open Sans', Arial, sans-serif; line-height: 23px; mso-line-height-rule: exactly;">
											<span>KvK nummer: <xsl:value-of select="$Vereniging/KvKnummer"/></span><br />
											<span>KvK plaats: <xsl:value-of select="$Vereniging/KvKplaats"/></span><br />
											<span>Bank Nummer: <xsl:value-of select="$Vereniging/BankNummer"/></span><br />
											<span>Bank Iban: <xsl:value-of select="$Vereniging/BankIban"/></span><br />
											<span>Bank Plaats: <xsl:value-of select="$Vereniging/BankPlaats"/></span><br />
											<span>Telefoon Overdag: <xsl:value-of select="$Vereniging/TelefoonOverdag"/></span><br />
											<span>Telefoon Avond: <xsl:value-of select="$Vereniging/TelefoonAvond"/></span><br />
											<span>Email: <xsl:value-of select="$Vereniging/EmailKNLTB"/></span><br />																																
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
				</td>
			</tr>
		</table>
		<!-- END OF VERENIGING BLOCK-->
	</xsl:template>
	<xsl:template match="GEBRUIKER">
		<!-- START OF GEBRUIKER BLOCK-->
		<table data-templateapp="Gebruiker Block" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
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
											<td align="center" valign="top" style="padding-top: 20px;">
											<table border="0" align="center" cellpadding="0" cellspacing="0" style="margin: 0;">
												<tr>
													<td align="center" style="padding-bottom: 3px; font-weight: bold; font-family: 'Open Sans', Arial, sans-serif; color: #767676; font-size: 24px; line-height: 42px; mso-line-height-rule: exactly;">
													Aangemeld door <xsl:value-of select="$Gebruiker/Volledigenaam"/> ( <xsl:value-of select="$Gebruiker/Bondsnummer"/> )													
													</td>
												</tr>
											</table>
											</td>
										</tr>
										<tr>
											<td>
											<table class="table-inner" align="center" cellpadding="0" cellspacing="0" border="0">
												<tr>
													<td height="20" style="padding: 0; line-height: 0;">
													</td>
												</tr>
											</table>
											</td>
										</tr>
										<tr>
											<td align="center" style="padding-top: 0px; margin: 0; font-weight: normal; font-weight: normal; font-size: 13px; color: #797979; font-family: 'Open Sans', Arial, sans-serif; line-height: 23px; mso-line-height-rule: exactly;">
											<span>Telefoon Overdag: <xsl:value-of select="$Gebruiker/TelefoonOverdag"/></span><br />
											<span>Telefoon Avond: <xsl:value-of select="$Gebruiker/TelefoonAvond"/></span><br />
											<span>Email: <xsl:value-of select="$Gebruiker/EmailKNLTB"/></span><br />																																
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
				</td>
			</tr>
		</table>
		<!-- END OF GEBRUIKER BLOCK-->
	</xsl:template>
	<xsl:template match="OPMERKINGEN">
		<!-- START OF OPMERKINGEN BLOCK-->
		<table data-templateapp="Opmerkingen Block" bgcolor="#eaeaea" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
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
											<td align="center" valign="top" style="padding-top: 20px;">
											<table border="0" align="center" cellpadding="0" cellspacing="0" style="margin: 0;">
												<tr>
													<td align="center" style="padding-bottom: 3px; font-weight: bold; font-family: 'Open Sans', Arial, sans-serif; color: #767676; font-size: 18px; line-height: 28px; mso-line-height-rule: exactly;">
													Akkoord gegaan voor <xsl:value-of select="$Vereniging/Naam"/> ( <xsl:value-of select="$Vereniging/Nummer"/> )													</td>
												</tr>
											</table>
											</td>
										</tr>
										<tr>
											<td>
											<table class="table-inner" align="center" cellpadding="0" cellspacing="0" border="0">
												<tr>
													<td height="20" style="padding: 0; line-height: 0;">
													</td>
												</tr>
											</table>
											</td>
										</tr>
										<tr>
											<td align="center" style="padding-top: 0px; margin: 0; font-weight: normal; font-weight: normal; font-size: 13px; color: #797979; font-family: 'Open Sans', Arial, sans-serif; line-height: 23px; mso-line-height-rule: exactly;">
											<span>Op <xsl:value-of select="Extension:Now()"/> heeft uw </span><br />
											<span><xsl:value-of select="$Vereniging/Naam"/> ( <xsl:value-of select="$Vereniging/Nummer"/> )</span><br />
											<span>zich aangemeld door <xsl:value-of select="$Gebruiker/Volledigenaam"/> ( <xsl:value-of select="$Gebruiker/Bondsnummer"/> )</span><br />																																											
											<span>Akkoord gegaan op <xsl:value-of select="$Aanmelden/Datum"/></span><br />																																																						
											<span>Computer : <xsl:value-of select="$Aanmelden/IP"/></span><br />																																																																												
											<span>Opmerkingen <xsl:value-of select="$Aanmelden/Opmerkingen"/></span><br />																																																																	</td>
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
				</td>
			</tr>
		</table>
		<!-- END OF OPMERKINGEN BLOCK-->
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
                                    Welkom bij volgende generatie voor uw vereniging
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF HEADING-->

                              <!-- START OF TEXT-->
                              <tr>
                                <td class="center" align="center" style="padding: 0px; margin: 0; font-weight:normal; font-weight:normal; font-size:13px ; color:#616161; font-family:  'Open Sans', Arial, sans-serif; line-height: 23px;mso-line-height-rule: exactly;">
                                  <span>
                                    Binnenkort kunt u gebruik gaat maken van ClubCloud.
                                  </span>
                                </td>
                              </tr>
                              <!-- END OF TEXT-->
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

                                    &#169; <xsl:value-of select="Extension:Year()"/> ClubCloud Alle Rechten Voorbehouden.
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
	<xsl:template name="formatGoogleCollect" >
		<xsl:param name="TrackingId" />
		<xsl:param name="ClientId" />
		<xsl:param name="RecipientId" />
		<xsl:param name="CampaignSource" />
		<xsl:param name="CampaignName" />
		<xsl:variable name="url" >
      <xsl:text disable-output-escaping="yes"><![CDATA[<img src="https://www.google-analytics.com/collect?v=1&tid=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$TrackingId" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&cid=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$ClientId"/>
      <xsl:text disable-output-escaping="yes"><![CDATA[=event&ec=email&ea=open&el=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$RecipientId" />
      <xsl:text disable-output-escaping="yes"><![CDATA[&cs=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$CampaignSource" />
      <xsl:text disable-output-escaping="yes" ><![CDATA[&cm=email&cn=]]></xsl:text>
      <xsl:value-of disable-output-escaping="yes" select="$CampaignName"/>
      <xsl:text disable-output-escaping="yes" ><![CDATA[" >]]></xsl:text>
    </xsl:variable>
		<xsl:value-of select="$url" disable-output-escaping="yes" />
	</xsl:template>
</xsl:stylesheet>