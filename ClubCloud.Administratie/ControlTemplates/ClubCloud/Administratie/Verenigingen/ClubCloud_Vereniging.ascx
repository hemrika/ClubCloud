<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Vereniging.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_VerenigingUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Vereniging_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Verenigingen_View" />
<asp:UpdatePanel ID="udp_profiel" runat="server" UpdateMode="Always">
    <contenttemplate>
<asp:FormView runat="server" ID="SelectVerenigingform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectVerenigingform_CallingDataMethods" SelectMethod="SelectVereniging" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Vereniging gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Vereniging beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Verenigingen" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
	<span style="display:inline-block;" >
		<asp:LinkButton CssClass="button big"  ID="btn_goback_top" runat="server" Text="Terug" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton CssClass="button big"  ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/></br>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Functionarissen.aspx?VerenigingId=<%# Eval("Id") %>', title:'Functionarissen van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Functionarissen" >Functionarissen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschappen.aspx?VerenigingId=<%# Eval("Id") %>', title:'Lidmaatschappen van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Lidmaatschappen" >Lidmaatschappen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Bestuursorganen.aspx?VerenigingId=<%# Eval("Id") %>', title:'Bestuursorganen van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Bestuursorganen" >Bestuursorganen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Addressen.aspx?VerenigingId=<%# Eval("Id") %>', title:'Addressen van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Addressen" >Addressen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Afhangen.aspx?VerenigingId=<%# Eval("Id") %>', title:'Afhangen van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Afhangen" >Afhangen</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Sponsoren.aspx?VerenigingId=<%# Eval("Id") %>', title:'Sponsoren van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Sponsoren" >Sponsoren</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Baanschemas.aspx?VerenigingId=<%# Eval("Id") %>', title:'Baanschemas van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Baanschemas" >Baanschemas</a>
		<a class="button big"  onclick="javascript:SP.UI.ModalDialog.showModalDialog({url:'Lidmaatschapsoorten.aspx?VerenigingId=<%# Eval("Id") %>', title:'Lidmaatschapsoorten van <%# Eval("Naam") %>', autoSize:true});" href="#" target="_self" title="Lidmaatschapsoorten" >Lidmaatschapsoorten</a>
	</span>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton CssClass="button big"  ID="btn_goback_bottom" runat="server" Text="Terug " CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton CssClass="button big"  ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
        <fieldset>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			BankIban : <asp:Label ID="BankIban" runat="server" Text='<%# Eval("BankIban") %>' /></br>
			BankNummer : <asp:Label ID="BankNummer" runat="server" Text='<%# Eval("BankNummer") %>' /></br>
			BankPlaats : <asp:Label ID="BankPlaats" runat="server" Text='<%# Eval("BankPlaats") %>' /></br>
			Beschrijving : <asp:Label ID="Beschrijving" runat="server" Text='<%# Eval("Beschrijving") %>' /></br>
			EmailKNLTB : <asp:Label ID="EmailKNLTB" runat="server" Text='<%# Eval("EmailKNLTB") %>' /></br>
			EmailOverig : <asp:Label ID="EmailOverig" runat="server" Text='<%# Eval("EmailOverig") %>' /></br>
			EmailWebSite : <asp:Label ID="EmailWebSite" runat="server" Text='<%# Eval("EmailWebSite") %>' /></br>
			Erkenning : <asp:Label ID="Erkenning" runat="server" Text='<%# Eval("Erkenning") %>' /></br>
			Fax : <asp:Label ID="Fax" runat="server" Text='<%# Eval("Fax") %>' /></br>
			FTPsite : <asp:Label ID="FTPsite" runat="server" Text='<%# Eval("FTPsite") %>' /></br>
			Gestopt : <asp:Label ID="Gestopt" runat="server" Text='<%# Eval("Gestopt") %>' /></br>
			Gewijzigd : <asp:Label ID="Gewijzigd" runat="server" Text='<%# Eval("Gewijzigd") %>' /></br>
			KvKnummer : <asp:Label ID="KvKnummer" runat="server" Text='<%# Eval("KvKnummer") %>' /></br>
			KvKplaats : <asp:Label ID="KvKplaats" runat="server" Text='<%# Eval("KvKplaats") %>' /></br>
			Maanden : <asp:Label ID="Maanden" runat="server" Text='<%# Eval("Maanden") %>' /></br>
			Naam : <asp:Label ID="Naam" runat="server" Text='<%# Eval("Naam") %>' /></br>
			Nummer : <asp:Label ID="Nummer" runat="server" Text='<%# Eval("Nummer") %>' /></br>
			Oprichting : <asp:Label ID="Oprichting" runat="server" Text='<%# Eval("Oprichting") %>' /></br>
			TelefoonAvond : <asp:Label ID="TelefoonAvond" runat="server" Text='<%# Eval("TelefoonAvond") %>' /></br>
			TelefoonOverdag : <asp:Label ID="TelefoonOverdag" runat="server" Text='<%# Eval("TelefoonOverdag") %>' /></br>
			TelefoonOverig : <asp:Label ID="TelefoonOverig" runat="server" Text='<%# Eval("TelefoonOverig") %>' /></br>
			Website : <asp:Label ID="Website" runat="server" Text='<%# Eval("Website") %>' /></br>
			Functionarissen : <asp:Label runat="server" ID="Functionaris" Text='<%# Eval("ClubCloud_Functionaris.Count") %>' /></br>		
			Lidmaatschappen : <asp:Label runat="server" ID="Lidmaatschap" Text='<%# Eval("ClubCloud_Lidmaatschap.Count") %>' /></br>		
			Bestuursorganen : <asp:Label runat="server" ID="Bestuursorgaan" Text='<%# Eval("ClubCloud_Bestuursorgaan.Count") %>' /></br>		
			District : <asp:Label runat="server" ID="District" Text='<%# Eval("ClubCloud_District.Naam") %>' /></br>
			Rechtsvorm : <asp:Label runat="server" ID="Rechtsvorm" Text='<%# Eval("ClubCloud_Rechtsvorm.Naam") %>' /></br>
			Accommodatie : <asp:Label runat="server" ID="Accommodatie" Text='<%# Eval("ClubCloud_Accommodatie.Naam") %>' /></br>
			Addressen : <asp:Label runat="server" ID="Address" Text='<%# Eval("ClubCloud_Address.Count") %>' /></br>		
			Regio : <asp:Label runat="server" ID="Regio" Text='<%# Eval("ClubCloud_Regio.Naam") %>' /></br>
			Afhangen : <asp:Label runat="server" ID="Afhang" Text='<%# Eval("ClubCloud_Afhang.Count") %>' /></br>		
			Sponsoren : <asp:Label runat="server" ID="Sponsor" Text='<%# Eval("ClubCloud_Sponsor.Count") %>' /></br>		
			Baanschemas : <asp:Label runat="server" ID="Baanschema" Text='<%# Eval("ClubCloud_Baanschema.Count") %>' /></br>		
			Lidmaatschapsoorten : <asp:Label runat="server" ID="Lidmaatschapsoort" Text='<%# Eval("ClubCloud_Lidmaatschapsoort.Count") %>' /></br>		
        </fieldset>
    </ItemTemplate>
</asp:FormView>
    </contenttemplate>
</asp:UpdatePanel>
