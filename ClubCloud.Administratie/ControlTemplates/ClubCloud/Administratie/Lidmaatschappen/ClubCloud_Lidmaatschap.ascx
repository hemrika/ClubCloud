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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Lidmaatschap.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_LidmaatschapUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Lidmaatschap_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Lidmaatschappen_View" />
<asp:FormView runat="server" ID="SelectLidmaatschapform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectLidmaatschapform_CallingDataMethods" SelectMethod="SelectLidmaatschap" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Lidmaatschap gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Lidmaatschap beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Lidmaatschappen" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
	<span style="display:inline-block;" >
		<asp:LinkButton CssClass="button big"  ID="btn_goback_top" runat="server" Text="Terug naar Lidmaatschappen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton CssClass="button big"  ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/></br>
	</span>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton CssClass="button big"  ID="btn_goback_bottom" runat="server" Text="Terug naar Lidmaatschappen" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton CssClass="button big"  ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
        <fieldset>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			Autorisatie : <asp:Label ID="Autorisatie" runat="server" Text='<%# Eval("Autorisatie") %>' /></br>
			Begin : <asp:Label ID="Begin" runat="server" Text='<%# Eval("Begin") %>' /></br>
			Bondsnummer : <asp:Label ID="Bondsnummer" runat="server" Text='<%# Eval("Bondsnummer") %>' /></br>
			Einde : <asp:Label ID="Einde" runat="server" Text='<%# Eval("Einde") %>' /></br>
			Gewijzigd : <asp:Label ID="Gewijzigd" runat="server" Text='<%# Eval("Gewijzigd") %>' /></br>
			<asp:HiddenField ID="Id" Value='<%# Eval("Id") %>' runat="server" />
			InternNummer : <asp:Label ID="InternNummer" runat="server" Text='<%# Eval("InternNummer") %>' /></br>
			Opzegging : <asp:Label ID="Opzegging" runat="server" Text='<%# Eval("Opzegging") %>' /></br>
			PasDatum : <asp:Label ID="PasDatum" runat="server" Text='<%# Eval("PasDatum") %>' /></br>
			PasNieuw : <asp:Label ID="PasNieuw" runat="server" Text='<%# Eval("PasNieuw") %>' /></br>
			PasNood : <asp:Label ID="PasNood" runat="server" Text='<%# Eval("PasNood") %>' /></br>
			PasNoodDatum : <asp:Label ID="PasNoodDatum" runat="server" Text='<%# Eval("PasNoodDatum") %>' /></br>
			PasTypeNaam : <asp:Label ID="PasTypeNaam" runat="server" Text='<%# Eval("PasTypeNaam") %>' /></br>
			PasVolgnummer : <asp:Label ID="PasVolgnummer" runat="server" Text='<%# Eval("PasVolgnummer") %>' /></br>
			PasWedstrijd : <asp:Label ID="PasWedstrijd" runat="server" Text='<%# Eval("PasWedstrijd") %>' /></br>
			SpeelsterkteDubbel : <asp:Label ID="SpeelsterkteDubbel" runat="server" Text='<%# Eval("SpeelsterkteDubbel") %>' /></br>
			SpeelsterkteEnkel : <asp:Label ID="SpeelsterkteEnkel" runat="server" Text='<%# Eval("SpeelsterkteEnkel") %>' /></br>
			Vereniging : <asp:Label runat="server" ID="Vereniging" Text='<%# Eval("ClubCloud_Vereniging.Naam") %>' /></br>
			Gebruiker : <asp:Label runat="server" ID="Gebruiker" Text='<%# Eval("ClubCloud_Gebruiker.Volledigenaam") %>' /></br>
			Lidmaatschapsoort : <asp:Label runat="server" ID="Lidmaatschapsoort" Text='<%# Eval("ClubCloud_Lidmaatschapsoort.Naam") %>' /></br>
        </fieldset>
    </ItemTemplate>
</asp:FormView>
