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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_BaanSpeciaal.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_BaanSpeciaalUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_BaanSpeciaal_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_BanenSpeciaal_View" />
<asp:FormView runat="server" ID="SelectBaanSpeciaalform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectBaanSpeciaalform_CallingDataMethods" SelectMethod="SelectBaanSpeciaal" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen BaanSpeciaal gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  BaanSpeciaal beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar BanenSpeciaal" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
	<span style="display:inline-block;" >
		<asp:LinkButton CssClass="button big"  ID="btn_goback_top" runat="server" Text="Terug naar BanenSpeciaal" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton CssClass="button big"  ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/></br>
	</span>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton CssClass="button big"  ID="btn_goback_bottom" runat="server" Text="Terug naar BanenSpeciaal" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton CssClass="button big"  ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
        <fieldset>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			Baansoort : <asp:Label ID="Baansoort" runat="server" Text='<%# Eval("Baansoort") %>' /></br>
			<asp:HiddenField ID="Id" Value='<%# Eval("Id") %>' runat="server" />
			Naam : <asp:Label ID="Naam" runat="server" Text='<%# Eval("Naam") %>' /></br>
			Accommodatie : <asp:Label runat="server" ID="Accommodatie" Text='<%# Eval("ClubCloud_Accommodatie.Naam") %>' /></br>
			Baantoplaag : <asp:Label runat="server" ID="Baantoplaag" Text='<%# Eval("ClubCloud_Baantoplaag.Naam") %>' /></br>
        </fieldset>
    </ItemTemplate>
</asp:FormView>