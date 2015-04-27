<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Functionaris_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Functionaris_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Functionaris_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Functionarissen_View" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
<asp:FormView runat="server" ID="EditFunctionarisform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditFunctionarisform_CallingDataMethods" SelectMethod="SelectFunctionaris" UpdateMethod="UpdateFunctionaris" DataKeyNames="Id">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Functionaris gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Functionaris beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Functionarissen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:Button ID="btn_goback_top" runat="server" Text="Terug naar Functionarissen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:Button ID="btn_goback_bottom" runat="server" Text="Terug naar Functionarissen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>


            Functie : <asp:DropDownList ID="FunctieId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("FunctieId") %>' SelectMethod="SelectFunctie" OnCallingDataMethods="EditFunctionarisform_CallingDataMethods" /></br>

			<asp:HiddenField ID="VerenigingId" Value='<%# Bind("VerenigingId") %>' runat="server" />

			<asp:HiddenField ID="GebruikerId" Value='<%# Bind("GebruikerId") %>' runat="server" />

            Bestuursorgaan : <asp:DropDownList ID="BestuursorgaanId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("BestuursorgaanId") %>' SelectMethod="SelectBestuursorgaan" OnCallingDataMethods="EditFunctionarisform_CallingDataMethods" /></br>

			<asp:HiddenField ID="DistrictId" Value='<%# Bind("DistrictId") %>' runat="server" />

			TermijnBegin : <asp:TextBox ID="TermijnBegin" runat="server" Text='<%# Bind("TermijnBegin") %>' TextMode="Date" /></br>

			TermijnEinde : <asp:TextBox ID="TermijnEinde" runat="server" Text='<%# Bind("TermijnEinde") %>' TextMode="Date" /></br>

			Autorisatie : <asp:Checkbox ID="Autorisatie" runat="server" Checked='<%# Bind("Autorisatie") %>' /></br>

			Actief : <asp:TextBox ID="Actief" runat="server" Text='<%# Bind("Actief") %>' TextMode="SingleLine"/></br>

			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>

