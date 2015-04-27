<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Lidmaatschap_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Lidmaatschap_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Lidmaatschap_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Lidmaatschappen_View" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
<asp:FormView runat="server" ID="EditLidmaatschapform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditLidmaatschapform_CallingDataMethods" SelectMethod="SelectLidmaatschap" UpdateMethod="UpdateLidmaatschap" DataKeyNames="Id">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Lidmaatschap gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Lidmaatschap beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Lidmaatschappen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:Button ID="btn_goback_top" runat="server" Text="Terug naar Lidmaatschappen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:Button ID="btn_goback_bottom" runat="server" Text="Terug naar Lidmaatschappen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>


			Bondsnummer : <asp:TextBox ID="Bondsnummer" runat="server" Text='<%# Bind("Bondsnummer") %>' TextMode="Number" Enabled="false" /></br>

            Lidmaatschapsoort : <asp:DropDownList ID="LidmaatschapsoortId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("LidmaatschapsoortId") %>' SelectMethod="SelectLidmaatschapsoort" OnCallingDataMethods="EditLidmaatschapform_CallingDataMethods" /></br>

			Begin : <asp:TextBox ID="Begin" runat="server" Text='<%# Bind("Begin") %>' TextMode="Date" /></br>

			Einde : <asp:TextBox ID="Einde" runat="server" Text='<%# Bind("Einde") %>' TextMode="Date" /></br>

			Opzegging : <asp:TextBox ID="Opzegging" runat="server" Text='<%# Bind("Opzegging") %>' TextMode="Date" /></br>

			InternNummer : <asp:TextBox ID="InternNummer" runat="server" Text='<%# Bind("InternNummer") %>' TextMode="Number" Enabled="false" /></br>

			<asp:HiddenField ID="GebruikerId" Value='<%# Bind("GebruikerId") %>' runat="server" />

			<asp:HiddenField ID="VerenigingId" Value='<%# Bind("VerenigingId") %>' runat="server" />

			<asp:HiddenField ID="PasTypeId" Value='<%# Bind("PasTypeId") %>' runat="server" />

			PasTypeNaam : <asp:TextBox ID="PasTypeNaam" runat="server" Text='<%# Bind("PasTypeNaam") %>' TextMode="SingleLine"/></br>

			PasDatum : <asp:TextBox ID="PasDatum" runat="server" Text='<%# Bind("PasDatum") %>' TextMode="Date" /></br>

			PasNoodDatum : <asp:TextBox ID="PasNoodDatum" runat="server" Text='<%# Bind("PasNoodDatum") %>' TextMode="Date" /></br>

			PasWedstrijd : <asp:Checkbox ID="PasWedstrijd" runat="server" Checked='<%# Bind("PasWedstrijd") %>' /></br>

			PasNieuw : <asp:Checkbox ID="PasNieuw" runat="server" Checked='<%# Bind("PasNieuw") %>' /></br>

			PasNood : <asp:Checkbox ID="PasNood" runat="server" Checked='<%# Bind("PasNood") %>' /></br>

			PasVolgnummer : <asp:TextBox ID="PasVolgnummer" runat="server" Text='<%# Bind("PasVolgnummer") %>' TextMode="Number" Enabled="false" /></br>

			SpeelsterkteDubbel : <asp:TextBox ID="SpeelsterkteDubbel" runat="server" Text='<%# Bind("SpeelsterkteDubbel") %>' TextMode="Number" /></br>

			SpeelsterkteEnkel : <asp:TextBox ID="SpeelsterkteEnkel" runat="server" Text='<%# Bind("SpeelsterkteEnkel") %>' TextMode="Number" /></br>

			Autorisatie : <asp:Checkbox ID="Autorisatie" runat="server" Checked='<%# Bind("Autorisatie") %>' /></br>

			Actief : <asp:TextBox ID="Actief" runat="server" Text='<%# Bind("Actief") %>' TextMode="SingleLine"/></br>

			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>

