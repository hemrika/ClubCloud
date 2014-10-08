<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BetalingenUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.BetalingenUserControl" %>
<script src="/_layouts/15/ClubCloud.SignalR/jquery.min.js" type="text/javascript"></script>
<script src="/_layouts/15/ClubCloud.SignalR/jquery.signalR.min.js" type="text/javascript"></script>
<script src="/_layouts/15/ClubCloud.SignalR/json2.min.js" type="text/javascript"></script>
<script src="~/signalr/hubs" type="text/javascript"></script>
<asp:UpdatePanel ID="udp_betalingen" runat="server"  >
    <ContentTemplate>
        <asp:panel runat="server" ID="pnl_secure" Visible="False">
            <i class="icon-lock-1 special"></i>U moet ingelogd zijn om uw instellingen te kunnen wijzigen.
            <asp:LinkButton ID="btn_login" Text="Inloggen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/_zimbra/default.aspx'; return false" runat="server" /><br />
        </asp:panel>
        <fieldset>
        <asp:panel runat="server" ID="pnl_betalingen" GroupingText="Betalings instellingen:"  >
            <asp:CheckBox id="betalingen_overboeking" runat="server" Checked="False" Text="Betaling per machtiging" ></asp:CheckBox><br />
            Instellen : <asp:LinkButton ID="btn_machtiging" Text="Machtiging instellen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: '../Machtiging.aspx', title: 'Machtigingen instellen', showClose: true});" runat="server" /><br />
            <asp:CheckBox id="betalingen_ideal" runat="server" Checked="False" Text="Betaling per iDEAL" ></asp:CheckBox><br />
            Instellen : <asp:LinkButton ID="btn_ideal" Text="iDEAL instellen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: '../ideal.aspx', title: 'iDEAL instellen', showClose: true});" runat="server" /><br />
            <asp:CheckBox id="betalingen_paypal" runat="server" Checked="False" Text="Betaling per PayPal" ></asp:CheckBox><br />
            Instellen : <asp:LinkButton ID="btn_paypal" Text="PayPal instellen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: '../paypal.aspx', title: 'PayPal instellen', showClose: true});" runat="server" /><br />
            <asp:CheckBox id="betalingen_factuur" runat="server" Checked="False" Text="Betaling per factuur" ></asp:CheckBox><br />
            Instellen : <asp:LinkButton ID="btn_factuur" Text="Facturatie instellen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: '../factuur.aspx', title: 'Factuur instellen', showClose: true});" runat="server" /><br />
            <br />
            <asp:LinkButton ID="btn_betaling" runat="server" Text="Opslaan" Enabled="True" CssClass="button small alignright" OnClick="btn_betaling_Click" />
            <asp:ValidationSummary ID="vds_betalingen" runat="server" OnDataBinding="btn_betaling_Click"  DisplayMode="SingleParagraph" />
        </asp:panel>
        </fieldset>
    </ContentTemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_betalingen_progress" runat="server" AssociatedUpdatePanelID="udp_betalingen">
<ProgressTemplate>
    Bezig met verwerken.    
</ProgressTemplate>
</asp:UpdateProgress>
