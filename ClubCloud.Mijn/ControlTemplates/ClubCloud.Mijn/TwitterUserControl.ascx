﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TwitterUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.TwitterUserControl" %>
<asp:UpdatePanel ID="udp_twitter" runat="server">
    <ContentTemplate>
        <asp:panel runat="server" ID="pnl_secure" Visible="False">
            <i class="icon-lock-1 special"></i>U moet ingelogd zijn om uw instellingen te kunnen wijzigen.
            <asp:LinkButton ID="btn_login" Text="Inloggen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/_zimbra/default.aspx'; return false" runat="server" /><br />
        </asp:panel>
        <fieldset>
        <asp:panel runat="server" ID="pnl_twitter" GroupingText="Twitter intellingen :"  CssClass="etabs">
            <asp:CheckBox id="twitter_allow" runat="server" Checked="True" Text="Twitteren !!" Enabled="false" ></asp:CheckBox><br />
            <asp:CheckBox id="twitter_updates" runat="server" Checked="True" Text="Tweet prestatie informatie" ></asp:CheckBox><br />
            <asp:CheckBox id="twitter_winning" runat="server" Checked="False" Text="Tweet alleen winst ;-)" ></asp:CheckBox><br />
            <asp:CheckBox id="twitter_competitie" runat="server" Checked="True" Text="Tweet competitie informatie" ></asp:CheckBox><br />
            <asp:CheckBox id="twitter_toernament" runat="server" Checked="True" Text="Tweet toernooi informatie" ></asp:CheckBox><br />
            <br />
            <asp:Button ID="twitter_save" runat="server" Text="Opslaan" OnClick="twitter_save_Click" /><br />
            <br />
        Toegang verlenen/intrekken : <asp:LinkButton ID="lbn_aanvragen" Text="Toegang verlenen/intrekken" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: '../twitter.aspx', title: 'Aanvragen Twitter', showClose: true});" runat="server" CausesValidation="False" /><br />
        </asp:panel>
        </fieldset>
        <asp:Label ID="lbl_result" runat="server"></asp:Label>
    </ContentTemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_twitter_progress" runat="server" AssociatedUpdatePanelID="udp_twitter">
    <progresstemplate>
    Bezig met verwerken.
</progresstemplate>
    
</asp:UpdateProgress>
