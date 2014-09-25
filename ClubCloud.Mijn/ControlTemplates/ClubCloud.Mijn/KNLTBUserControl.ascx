<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KNLTBUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.KNLTBUserControl" %>
<!--
<script type="text/javascript">
    function pageLoad() {
        $create(
            Sys.UI.DataView,
            {
                autoFetch: "true",
                dataProvider: "~/_vti_bin/ClubCloud.Service/ClubCloud.svc",
                fetchOperation: "HelloWorld",
            },
              {},
              {},
              $get("companyListView")
          );
    }
</script>
-->
<asp:UpdatePanel ID="udp_knltb" runat="server" >
    <ContentTemplate>
        <asp:image imageurl="/_layouts/15/images/ClubCloud.Mijn/mijnknltb.png" runat="server" alt="MijnKNLTB" />
        <asp:panel runat="server" ID="pnl_secure" Visible="False">
            <i class="icon-lock-1 special"></i>U moet ingelogd zijn om uw instellingen te kunnen wijzigen.
            <asp:LinkButton ID="btn_login" Text="Inloggen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/_zimbra/default.aspx'; return false" runat="server" /><br />
        </asp:panel>
        <fieldset>
        <asp:panel runat="server" ID="pnl_knltb">
        <asp:Label ID="lbl_knltbid" runat="server" Text="KNLTB nummer:" ></asp:Label> 
        <asp:TextBox ID="tbx_knltbid" runat="server" Enabled="False" CssClass="text-input"></asp:TextBox> 

        <asp:Label ID="lbl_knltbpw" runat="server" Text="KNLTB Wachtwoord :" ></asp:Label> 
        <asp:TextBox ID="tbx_knltbpw" runat="server" TextMode="Password" OnTextChanged="tbx_knltbpw_TextChanged" CssClass="text-input" CausesValidation="True" ></asp:TextBox>
        <asp:RequiredFieldValidator ControlToValidate="tbx_knltbpw" ErrorMessage="Vul uw MijnKNLTB  wachtwoord in." Text="*" runat="server"/>

        <asp:CheckBox ID="cbx_knltb" runat="server" Text="Akkoord met voorwaarden" TextAlign="Right" Width="80%" />
        <asp:LinkButton ID="btn_knltbpw" runat="server" Text="Opslaan" Enabled="True" CssClass="button small alignright" OnClick="btn_knltbpw_Click" /><br />
        <asp:ValidationSummary ID="vds_knltb" runat="server" OnDataBinding="btn_knltbpw_Click" DisplayMode="SingleParagraph" />
        </asp:panel>
        </fieldset>
        <p><br /></p>
        <asp:panel runat="server" ID="pnl_information">
        <p>Om uw gegevens te synchroniseren moet een toegang hebben tot uw mijnknltb omgegeving.<br />
        Toegang aanvragen : <asp:LinkButton ID="lbn_aanvragen" Text="Toegang aanvragen" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: 'https://services.mijnknltb.nl/RequestAccess.aspx', title: 'Aanvragen toegang MijnKNLTB', showClose: true});" runat="server" /><br />
        Wachtwoord vergeten : <asp:LinkButton ID="lbn_vergeten" Text="Wachtwoord vergeten" OnClientClick="javascript:SP.UI.ModalDialog.showModalDialog({url: 'https://services.mijnknltb.nl/', title: 'Mijn KNLTB Wachtwoord Herstellen',showClose: true});" runat="server" /><br />
        </p>
        </asp:panel>
    </ContentTemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_knltb_progress" runat="server" AssociatedUpdatePanelID="udp_knltb">
<ProgressTemplate>
    Bezig met verwerken.
</ProgressTemplate>
</asp:UpdateProgress>
