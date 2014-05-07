<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BetalingenUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.BetalingenUserControl" %>
<asp:UpdatePanel ID="udp_betalingen" runat="server">
    <ContentTemplate>
        <asp:panel runat="server" ID="pnl_secure" Visible="False">
            <i class="icon-lock-1 special"></i>U moet ingelogd zijn om uw instellingen te kunnen wijzigen.
            <asp:LinkButton ID="btn_login" Text="Inloggen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: 'https://mijn.clubcloud.nl/_zimbra/default.aspx', title: 'Inloggen op MijnClubCloud', showClose: true});" runat="server" /><br />
        </asp:panel>
        <fieldset>
        <asp:panel runat="server" ID="pnl_betalingen">
            <asp:CheckBox id="betalingen_overboeking" runat="server" Checked="False" Text="Betaling per machtiging" ></asp:CheckBox><br />
            Instellen : <asp:LinkButton ID="btn_machtiging" Text="Machtiging instellen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: 'https://mijn.clubcloud.nl/Machtiging.aspx', title: 'Overboekingen instellen', showClose: true});" runat="server" /><br />
            <asp:CheckBox id="betalingen_ideal" runat="server" Checked="False" Text="Betaling per iDEAL" ></asp:CheckBox><br />
            Instellen : <asp:LinkButton ID="btn_ideal" Text="iDEAL instellen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: 'https://mijn.clubcloud.nl/ideal.aspx', title: 'iDEAL instellen', showClose: true});" runat="server" /><br />
            <asp:CheckBox id="betalingen_paypal" runat="server" Checked="False" Text="Betaling per PayPal" ></asp:CheckBox><br />
            Instellen : <asp:LinkButton ID="btn_paypal" Text="PayPal instellen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: 'https://mijn.clubcloud.nl/paypal.aspx', title: 'PayPal instellen', showClose: true});" runat="server" /><br />
            <asp:CheckBox id="betalingen_factuur" runat="server" Checked="False" Text="Betaling per factuur" ></asp:CheckBox><br />
            Instellen : <asp:LinkButton ID="btn_factuur" Text="Facturatie instellen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: 'https://mijn.clubcloud.nl/factuur.aspx', title: 'Factuur instellen', showClose: true});" runat="server" /><br />
            <br />
            <asp:Button ID="btn_betaling" runat="server" Text="Opslaan" Enabled="True" CssClass="button big blue" OnClick="btn_betaling_Click" />
        </asp:panel>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>