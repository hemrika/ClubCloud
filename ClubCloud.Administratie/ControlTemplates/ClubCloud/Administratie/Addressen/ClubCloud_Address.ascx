<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Address.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_AddressUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Address_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Addressen_View" />
<asp:UpdatePanel ID="udp_profiel" runat="server" UpdateMode="Always">
    <contenttemplate>
<asp:FormView runat="server" ID="SelectAddressform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectAddressform_CallingDataMethods" SelectMethod="SelectAddress" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Address gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Address beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Addressen" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
	<span style="display:inline-block;" >
		<asp:LinkButton CssClass="button big"  ID="btn_goback_top" runat="server" Text="Terug" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton CssClass="button big"  ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/></br>
	</span>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton CssClass="button big"  ID="btn_goback_bottom" runat="server" Text="Terug " CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton CssClass="button big"  ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
        <fieldset>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			AddressGeheim : <asp:Label ID="AddressGeheim" runat="server" Text='<%# Eval("AddressGeheim") %>' /></br>
			Fax : <asp:Label ID="Fax" runat="server" Text='<%# Eval("Fax") %>' /></br>
			Gemeente : <asp:Label ID="Gemeente" runat="server" Text='<%# Eval("Gemeente") %>' /></br>
			GeoLocation : <asp:Label ID="GeoLocation" runat="server" Text='<%# Eval("GeoLocation") %>' /></br>
			Gewijzigd : <asp:Label ID="Gewijzigd" runat="server" Text='<%# Eval("Gewijzigd") %>' /></br>
			Latitude : <asp:Label ID="Latitude" runat="server" Text='<%# Eval("Latitude") %>' /></br>
			Longitude : <asp:Label ID="Longitude" runat="server" Text='<%# Eval("Longitude") %>' /></br>
			Naam : <asp:Label ID="Naam" runat="server" Text='<%# Eval("Naam") %>' /></br>
			Nummer : <asp:Label ID="Nummer" runat="server" Text='<%# Eval("Nummer") %>' /></br>
			Postbus : <asp:Label ID="Postbus" runat="server" Text='<%# Eval("Postbus") %>' /></br>
			Postcode : <asp:Label ID="Postcode" runat="server" Text='<%# Eval("Postcode") %>' /></br>
			Provincie : <asp:Label ID="Provincie" runat="server" Text='<%# Eval("Provincie") %>' /></br>
			Stad : <asp:Label ID="Stad" runat="server" Text='<%# Eval("Stad") %>' /></br>
			Straat : <asp:Label ID="Straat" runat="server" Text='<%# Eval("Straat") %>' /></br>
			TelefoonPrimair : <asp:Label ID="TelefoonPrimair" runat="server" Text='<%# Eval("TelefoonPrimair") %>' /></br>
			TelefoonSecundair : <asp:Label ID="TelefoonSecundair" runat="server" Text='<%# Eval("TelefoonSecundair") %>' /></br>
			TelefoonTertiair : <asp:Label ID="TelefoonTertiair" runat="server" Text='<%# Eval("TelefoonTertiair") %>' /></br>
			Toevoeging : <asp:Label ID="Toevoeging" runat="server" Text='<%# Eval("Toevoeging") %>' /></br>
        </fieldset>
    </ItemTemplate>
</asp:FormView>
    </contenttemplate>
</asp:UpdatePanel>
