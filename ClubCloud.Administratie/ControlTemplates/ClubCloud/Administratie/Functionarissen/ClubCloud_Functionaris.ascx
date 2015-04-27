<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Functionaris.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_FunctionarisUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Functionaris_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Functionarissen_View" />
<asp:FormView runat="server" ID="SelectFunctionarisform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectFunctionarisform_CallingDataMethods" SelectMethod="SelectFunctionaris" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Functionaris gevonden
		</h1>
        <div class="notice">
            Sorry, er is geen  Functionaris beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Functionarissen" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center" />
    <FooterStyle BackColor="#0072C6" BorderColor="#0072C6" ForeColor="White" Font-Bold="true" Font-Size="Large" HorizontalAlign="Center"/>
    <RowStyle BorderColor="#0072C6" BorderStyle="Solid" BorderWidth="1px" />
    <HeaderTemplate>
		<asp:LinkButton ID="btn_goback_top" runat="server" Text="Terug" CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
        <asp:LinkButton ID="btn_edit_top" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </HeaderTemplate>
    <FooterTemplate>
		<asp:LinkButton ID="btn_goback_bottom" runat="server" Text="Terug " CausesValidation="false" OnClientClick="javascript:SP.UI.ModalDialog.commonModalDialogClose(SP.UI.DialogResult.OK, null);" SkinID="Button"/>
		<asp:LinkButton ID="btn_edit_bottom" runat="server" Text="Bewerken" CausesValidation="false" OnClick="GoEdit" OnCommand="GoEdit" CommandArgument='<%# Eval("Id") %>'/>
    </FooterTemplate>
    <ItemTemplate>
		

        <fieldset>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>
			Autorisatie : <asp:Label ID="Autorisatie" runat="server" Text='<%# Eval("Autorisatie") %>' /></br>
			Gewijzigd : <asp:Label ID="Gewijzigd" runat="server" Text='<%# Eval("Gewijzigd") %>' /></br>
			TermijnBegin : <asp:Label ID="TermijnBegin" runat="server" Text='<%# Eval("TermijnBegin") %>' /></br>
			TermijnEinde : <asp:Label ID="TermijnEinde" runat="server" Text='<%# Eval("TermijnEinde") %>' /></br>
			Functie : <a href="Functie.aspx?Id=<%# Eval("FunctieId") %>" target="_self" title="Functie" ><%# Eval("ClubCloud_Functie.Naam") %></a></br>
			Vereniging : <a href="Vereniging.aspx?Id=<%# Eval("VerenigingId") %>" target="_self" title="Vereniging" ><%# Eval("ClubCloud_Vereniging.Naam") %></a></br>
			Gebruiker : <a href="Gebruiker.aspx?Id=<%# Eval("GebruikerId") %>" target="_self" title="Gebruiker" ><%# Eval("ClubCloud_Gebruiker.Nummer") %></a></br>
			District : <a href="District.aspx?Id=<%# Eval("DistrictId") %>" target="_self" title="District" ><%# Eval("ClubCloud_District.Naam") %></a></br>
			Bestuursorgaan : <a href="Bestuursorgaan.aspx?Id=<%# Eval("BestuursorgaanId") %>" target="_self" title="Bestuursorgaan" ><%# Eval("ClubCloud_Bestuursorgaan.Naam") %></a></br>
        </fieldset>
    </ItemTemplate>
</asp:FormView>
