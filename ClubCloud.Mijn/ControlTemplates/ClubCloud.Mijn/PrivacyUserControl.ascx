<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PrivacyUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.PrivacyUserControl" %>
<asp:UpdatePanel ID="udp_privacy" runat="server">
    <contenttemplate>
        <asp:panel runat="server" ID="pnl_secure" Visible="False">
            <i class="icon-lock-1 special"></i>U moet ingelogd zijn om uw instellingen te kunnen wijzigen.
            <asp:LinkButton ID="btn_login" Text="Inloggen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/_zimbra/default.aspx'; return false" runat="server" /><br />
        </asp:panel>
        <fieldset>
        <asp:panel runat="server" ID="pnl_privacy" GroupingText="Zichtbaar voor :" >
            <asp:CheckBox id="privacy_club" runat="server" Checked="True" Text="Vereniging" Enabled="false" ></asp:CheckBox>
            <br />
            <asp:CheckBox id="privacy_leden_club" runat="server" Checked="False" Text="Vereniging leden" ></asp:CheckBox><br />
            <asp:CheckBox id="privacy_leden_clubcloud" runat="server" Checked="False" Text="ClubCloud leden" ></asp:CheckBox><br />
            <asp:CheckBox id="privacy_competitie_club" runat="server" Checked="False" Text="Competitie clubs" ></asp:CheckBox><br />
            <asp:CheckBox id="privacy_competitie_leden" runat="server" Checked="False" Text="Competitie tegenstanders" ></asp:CheckBox><br />
            <asp:CheckBox id="privacy_toernooi_club" runat="server" Checked="False" Text="Toernooi organisatoren" ></asp:CheckBox><br />            
            <asp:CheckBox id="privacy_toernooi_leden" runat="server" Checked="False" Text="Toernooi tegenstanders" ></asp:CheckBox><br />
            <br />
            <asp:Button ID="privacy_save" runat="server" Text="Opslaan" OnClick="privacy_save_Click" /><br />
            <br />
        </asp:panel>
        </fieldset>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_privacy_progress" runat="server" AssociatedUpdatePanelID="udp_privacy">
    <progresstemplate>
    Bezig met verwerken.    
</progresstemplate>
</asp:UpdateProgress>
