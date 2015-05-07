<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="AjaxControlToolkit" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=15.1.1.100, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Reservering.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_ReserveringUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Reservering_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Reserveringen_View" />
<asp:FormView runat="server" ID="SelectReserveringform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectReserveringform_CallingDataMethods" SelectMethod="SelectReservering" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Reservering gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Reservering beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Reserveringen" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
	<span style="display:inline-block;" >
		<asp:LinkButton CssClass="button big"  ID="btn_goback_top" runat="server" Text="Terug naar Reserveringen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton CssClass="button big"  ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/></br>
	</span>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton CssClass="button big"  ID="btn_goback_bottom" runat="server" Text="Terug naar Reserveringen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton CssClass="button big"  ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
        <fieldset>
			Beschrijving : <asp:Label ID="Beschrijving" runat="server" Text='<%# Eval("Beschrijving") %>' /></br>
			Datum : <asp:Label ID="Datum" runat="server" Text='<%# Eval("Datum") %>' /></br>
			Duur : <asp:Label ID="Duur" runat="server" Text='<%# Eval("Duur") %>' /></br>
			Final : <asp:Label ID="Final" runat="server" Text='<%# Eval("Final") %>' /></br>
			<asp:HiddenField ID="Id" Value='<%# Eval("Id") %>' runat="server" />
			ReserveringSoort : <asp:Label ID="ReserveringSoort" runat="server" Text='<%# Eval("ReserveringSoort") %>' /></br>
			Tijd : <asp:Label ID="Tijd" runat="server" Text='<%# Eval("Tijd") %>' /></br>
			Baan : <asp:Label runat="server" ID="Baan" Text='<%# Eval("ClubCloud_Baan.Naam") %>' /></br>
			Gebruiker Een : <asp:Label runat="server" ID="Gebruiker_Een" Text='<%# Eval("ClubCloud_Gebruiker_Een.Volledigenaam") %>' /></br>
			Gebruiker Twee : <asp:Label runat="server" ID="Gebruiker_Twee" Text='<%# Eval("ClubCloud_Gebruiker_Twee.Volledigenaam") %>' /></br>
			Gebruiker Drie : <asp:Label runat="server" ID="Gebruiker_Drie" Text='<%# Eval("ClubCloud_Gebruiker_Drie.Volledigenaam") %>' /></br>
			Gebruiker Vier : <asp:Label runat="server" ID="Gebruiker_Vier" Text='<%# Eval("ClubCloud_Gebruiker_Vier.Volledigenaam") %>' /></br>
        </fieldset>
    </ItemTemplate>
</asp:FormView>
