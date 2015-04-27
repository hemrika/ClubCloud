<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baan_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_Baan_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baan_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Banen_View" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
<asp:FormView runat="server" ID="EditBaanform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditBaanform_CallingDataMethods" SelectMethod="SelectBaan" UpdateMethod="UpdateBaan" DataKeyNames="Id">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Baan gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Baan beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Banen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:Button ID="btn_goback_top" runat="server" Text="Terug naar Banen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:Button ID="btn_goback_bottom" runat="server" Text="Terug naar Banen" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:Button ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>


			Naam : <asp:TextBox ID="Naam" runat="server" Text='<%# Bind("Naam") %>' TextMode="SingleLine"/></br>

			Nummer : <asp:TextBox ID="Nummer" runat="server" Text='<%# Bind("Nummer") %>' TextMode="Number" /></br>

			<asp:HiddenField ID="BaanblokId" Value='<%# Bind("BaanblokId") %>' runat="server" />

			<asp:HiddenField ID="AccommodatieId" Value='<%# Bind("AccommodatieId") %>' runat="server" />

			Status : <asp:TextBox ID="Status" runat="server" Text='<%# Bind("Status") %>' TextMode="SingleLine"/></br>

			Keuring : <asp:TextBox ID="Keuring" runat="server" Text='<%# Bind("Keuring") %>' TextMode="Date" /></br>

			Actief : <asp:TextBox ID="Actief" runat="server" Text='<%# Bind("Actief") %>' TextMode="SingleLine"/></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>

