<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Vereniging_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Vereniging_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Vereniging_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Verenigingen_View" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
<asp:FormView runat="server" ID="EditVerenigingform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditVerenigingform_CallingDataMethods" SelectMethod="SelectVereniging" UpdateMethod="UpdateVereniging" DataKeyNames="Id">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Vereniging gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Vereniging beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Verenigingen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:Button ID="btn_goback_top" runat="server" Text="Terug naar Verenigingen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:Button ID="btn_goback_bottom" runat="server" Text="Terug naar Verenigingen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>


			Naam : <asp:TextBox ID="Naam" runat="server" Text='<%# Bind("Naam") %>' TextMode="SingleLine"/></br>

			Beschrijving : <asp:TextBox ID="Beschrijving" runat="server" Text='<%# Bind("Beschrijving") %>' TextMode="MultiLine" /></br>

			Nummer : <asp:TextBox ID="Nummer" runat="server" Text='<%# Bind("Nummer") %>' TextMode="Number" Enabled="false" /></br>

			<asp:HiddenField ID="DistrictId" Value='<%# Bind("DistrictId") %>' runat="server" />

            Rechtsvorm : <asp:DropDownList ID="RechtsvormId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("RechtsvormId") %>' SelectMethod="SelectRechtsvorm" OnCallingDataMethods="EditVerenigingform_CallingDataMethods" /></br>

			<asp:HiddenField ID="AccommodatieId" Value='<%# Bind("AccommodatieId") %>' runat="server" />

			<asp:HiddenField ID="RegioId" Value='<%# Bind("RegioId") %>' runat="server" />

			BankNummer : <asp:TextBox ID="BankNummer" runat="server" Text='<%# Bind("BankNummer") %>' TextMode="Number" Enabled="false" /></br>

			BankIban : <asp:TextBox ID="BankIban" runat="server" Text='<%# Bind("BankIban") %>' TextMode="SingleLine"/></br>

			BankPlaats : <asp:TextBox ID="BankPlaats" runat="server" Text='<%# Bind("BankPlaats") %>' TextMode="SingleLine"/></br>

			KvKnummer : <asp:TextBox ID="KvKnummer" runat="server" Text='<%# Bind("KvKnummer") %>' TextMode="Number" Enabled="false" /></br>

			KvKplaats : <asp:TextBox ID="KvKplaats" runat="server" Text='<%# Bind("KvKplaats") %>' TextMode="SingleLine"/></br>

			EmailKNLTB : <asp:TextBox ID="EmailKNLTB" runat="server" Text='<%# Bind("EmailKNLTB") %>' TextMode="Email" /></br>

			EmailWebSite : <asp:TextBox ID="EmailWebSite" runat="server" Text='<%# Bind("EmailWebSite") %>' TextMode="Email" /></br>

			EmailOverig : <asp:TextBox ID="EmailOverig" runat="server" Text='<%# Bind("EmailOverig") %>' TextMode="Email" /></br>

			Fax : <asp:TextBox ID="Fax" runat="server" Text='<%# Bind("Fax") %>' TextMode="Phone" /></br>

			TelefoonAvond : <asp:TextBox ID="TelefoonAvond" runat="server" Text='<%# Bind("TelefoonAvond") %>' TextMode="Phone" /></br>

			TelefoonOverdag : <asp:TextBox ID="TelefoonOverdag" runat="server" Text='<%# Bind("TelefoonOverdag") %>' TextMode="Phone" /></br>

			TelefoonOverig : <asp:TextBox ID="TelefoonOverig" runat="server" Text='<%# Bind("TelefoonOverig") %>' TextMode="Phone" /></br>

			Website : <asp:TextBox ID="Website" runat="server" Text='<%# Bind("Website") %>' TextMode="SingleLine"/></br>

			FTPsite : <asp:TextBox ID="FTPsite" runat="server" Text='<%# Bind("FTPsite") %>' TextMode="SingleLine"/></br>

			Actief : <asp:TextBox ID="Actief" runat="server" Text='<%# Bind("Actief") %>' TextMode="SingleLine"/></br>

			Oprichting : <asp:TextBox ID="Oprichting" runat="server" Text='<%# Bind("Oprichting") %>' TextMode="Date" /></br>

			Erkenning : <asp:TextBox ID="Erkenning" runat="server" Text='<%# Bind("Erkenning") %>' TextMode="Date" /></br>

			Gestopt : <asp:TextBox ID="Gestopt" runat="server" Text='<%# Bind("Gestopt") %>' TextMode="Date" /></br>

			Maanden : <asp:TextBox ID="Maanden" runat="server" Text='<%# Bind("Maanden") %>' TextMode="Number" /></br>

			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>
