<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baan.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_BaanUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baan_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Banen_View" />
<asp:UpdatePanel ID="udp_profiel" runat="server" UpdateMode="Always">
    <contenttemplate>
<asp:FormView runat="server" ID="SelectBaanform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectBaanform_CallingDataMethods" SelectMethod="SelectBaan" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Baan gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Baan beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Banen" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
	<span style="display:inline-block;" >
		<asp:LinkButton CssClass="button big"  ID="btn_goback_top" runat="server" Text="Terug" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton CssClass="button big"  ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/></br>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanschemas.aspx?BaanId=<%# Eval("Id") %>', title:'Baanschemas van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Baanschemas" >Baanschemas</a>
	</span>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton CssClass="button big"  ID="btn_goback_bottom" runat="server" Text="Terug " CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton CssClass="button big"  ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
        <fieldset>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			Keuring : <asp:Label ID="Keuring" runat="server" Text='<%# Eval("Keuring") %>' /></br>
			Naam : <asp:Label ID="Naam" runat="server" Text='<%# Eval("Naam") %>' /></br>
			Nummer : <asp:Label ID="Nummer" runat="server" Text='<%# Eval("Nummer") %>' /></br>
			Status : <asp:Label ID="Status" runat="server" Text='<%# Eval("Status") %>' /></br>
			Baanblok : <asp:Label runat="server" ID="Baanblok" Text='<%# Eval("ClubCloud_Baanblok.Naam") %>' /></br>
			Accommodatie : <asp:Label runat="server" ID="Accommodatie" Text='<%# Eval("ClubCloud_Accommodatie.Naam") %>' /></br>
			Baanschemas : <asp:Label runat="server" ID="Baanschema" Text='<%# Eval("ClubCloud_Baanschema.Count") %>' /></br>		
        </fieldset>
    </ItemTemplate>
</asp:FormView>
    </contenttemplate>
</asp:UpdatePanel>
