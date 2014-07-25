﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MijnProfielUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.MijnProfielUserControl" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:UpdatePanel ID="udp_verenigingen" runat="server">
    <contenttemplate>
        <asp:panel runat="server" ID="pnl_secure" Visible="False">
            <i class="icon-lock-1 special"></i>U moet ingelogd zijn om uw instellingen te kunnen wijzigen.
            <asp:LinkButton ID="btn_login" Text="Inloggen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/_zimbra/default.aspx'; return false" runat="server" /><br />
        </asp:panel>
        <asp:panel runat="server" ID="pnl_authorize" Visible="False">
            <div class="first">
                <i class="icon-magic special"></i>
                <div class="info">
                <h3 class="lined">Toegang verlenen</h3>
                    <p>
                        Om uw gegevens te bekijken en te wijzigingen moet u toegang verlenen tot uw KNLTB gegevens onder instellingen.<br />
                        Na het verlenen van de toegang, kunt u zelf al uw gegevens inzien en beheren.
                    </p>
                    <asp:LinkButton ID="Instellingen" Text="Instellingen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/instellingen.aspx'; return false" runat="server" CssClass="button small" /><br />
                </div>
            </div>  
        </asp:panel>
        <fieldset>
            <asp:panel runat="server" ID="pnl_profiel">
            
                <asp:Chart ID="cht_profiel" runat="server" ImageStorageMode="UseHttpHandler" ImageType="Png" CssClass="first"  BackColor="Transparent" Width="600px" >
                    <chartareas>
                        <asp:ChartArea Name="cta_profiel"  BackColor="Transparent" >
                        </asp:ChartArea>
                    </chartareas>
                </asp:Chart>
            
            </asp:panel>
        </fieldset>
    </contenttemplate>
</asp:UpdatePanel>