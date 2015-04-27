<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Address_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Address_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Address_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Addressen_View" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
<asp:FormView runat="server" ID="EditAddressform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditAddressform_CallingDataMethods" SelectMethod="SelectAddress" UpdateMethod="UpdateAddress" DataKeyNames="Id">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Address gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Address beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Addressen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:Button ID="btn_goback_top" runat="server" Text="Terug naar Addressen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:Button ID="btn_goback_bottom" runat="server" Text="Terug naar Addressen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>


			<asp:HiddenField ID="ParentId" Value='<%# Bind("ParentId") %>' runat="server" />

			Stad : <asp:TextBox ID="Stad" runat="server" Text='<%# Bind("Stad") %>' TextMode="SingleLine"/></br>

			Provincie : <asp:TextBox ID="Provincie" runat="server" Text='<%# Bind("Provincie") %>' TextMode="SingleLine"/></br>



			Naam : <asp:DropDownList ID="Naam" runat="server" DataTextField="Key" DataValueField="Value" SelectedValue='<%# Bind("Naam") %>' SelectMethod="SelectNaam" OnCallingDataMethods="EditAddressform_CallingDataMethods" /></br>

			Postcode : <asp:TextBox ID="Postcode" runat="server" Text='<%# Bind("Postcode") %>' TextMode="SingleLine"/></br>

			Straat : <asp:TextBox ID="Straat" runat="server" Text='<%# Bind("Straat") %>' TextMode="SingleLine"/></br>

			Nummer : <asp:TextBox ID="Nummer" runat="server" Text='<%# Bind("Nummer") %>' TextMode="Number" Enabled="false" /></br>

            Land : <asp:DropDownList ID="LandId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("LandId") %>' SelectMethod="SelectLand" OnCallingDataMethods="EditAddressform_CallingDataMethods" /></br>

			Actief : <asp:TextBox ID="Actief" runat="server" Text='<%# Bind("Actief") %>' TextMode="SingleLine"/></br>

			Fax : <asp:TextBox ID="Fax" runat="server" Text='<%# Bind("Fax") %>' TextMode="Phone" /></br>

			Toevoeging : <asp:TextBox ID="Toevoeging" runat="server" Text='<%# Bind("Toevoeging") %>' TextMode="SingleLine"/></br>

			Postbus : <asp:TextBox ID="Postbus" runat="server" Text='<%# Bind("Postbus") %>' TextMode="SingleLine"/></br>

			TelefoonPrimair : <asp:TextBox ID="TelefoonPrimair" runat="server" Text='<%# Bind("TelefoonPrimair") %>' TextMode="Phone" /></br>

			TelefoonSecundair : <asp:TextBox ID="TelefoonSecundair" runat="server" Text='<%# Bind("TelefoonSecundair") %>' TextMode="Phone" /></br>

			TelefoonTertiair : <asp:TextBox ID="TelefoonTertiair" runat="server" Text='<%# Bind("TelefoonTertiair") %>' TextMode="Phone" /></br>


			Gewijzigd : <asp:TextBox ID="Gewijzigd" runat="server" Text='<%# Bind("Gewijzigd") %>' TextMode="Date" /></br>

			Gemeente : <asp:TextBox ID="Gemeente" runat="server" Text='<%# Bind("Gemeente") %>' TextMode="SingleLine"/></br>

			AddressGeheim : <asp:Checkbox ID="AddressGeheim" runat="server" Checked='<%# Bind("AddressGeheim") %>' /></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>

