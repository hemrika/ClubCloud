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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_BaanSpeciaal_Edit.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_BaanSpeciaal_EditUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_BaanSpeciaal_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_BanenSpeciaal_View" />
<asp:CustomValidator ID="BaanSpeciaal_Validator" Display="Dynamic" runat="server" />
<asp:ValidationSummary ShowModelStateErrors="true" runat="server" ID="BaanSpeciaal_Summary" />
<asp:FormView runat="server" ID="EditBaanSpeciaalform" DefaultMode="Edit" RenderOuterTable="False" OnCallingDataMethods="EditBaanSpeciaalform_CallingDataMethods" SelectMethod="SelectBaanSpeciaal" UpdateMethod="UpdateBaanSpeciaal" DataKeyNames="Id" OnItemUpdated="UpdateBaanSpeciaalform_ItemUpdated">
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen BaanSpeciaal gevonden</h1>
        <div class="notice">
            Sorry, er is geen  BaanSpeciaal beschikbaar voor dit Id.</div>
        <asp:LinkButton CssClass="button big" ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar BanenSpeciaal"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <HeaderTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_top" runat="server" Text="Terug naar BaanSpeciaal" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:LinkButton CssClass="button big" ID="btn_update_top" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </HeaderTemplate>
    <FooterTemplate>
        <asp:LinkButton CssClass="button big" ID="btn_goback_bottom" runat="server" Text="Terug naar BaanSpeciaal" CausesValidation="false" OnClick="GoBack" OnCommand="GoBack" CommandArgument='<%# Eval("Id") %>'/>
        <asp:LinkButton CssClass="button big" ID="btn_update_bottom" runat="server" Text="Save" CommandName="Update" CausesValidation="true" />
    </FooterTemplate>
    <EditItemTemplate>
        <fieldset>
			<asp:HiddenField ID="Id" Value='<%# Bind("Id") %>' runat="server" />
			Naam : <asp:TextBox ID="Naam" runat="server" Text='<%# Bind("Naam") %>' TextMode="SingleLine"/></br>
			Baansoort : <asp:DropDownList ID="Baansoort" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Baansoort") %>' SelectMethod="SelectBaansoort" OnCallingDataMethods="EditBaanSpeciaalform_CallingDataMethods" AppendDataBoundItems="true"><asp:ListItem  Text="Onbekend" Value="" Selected="True"></asp:ListItem> </asp:DropDownList></br>
			<asp:HiddenField ID="AccommodatieId" Value='<%# Bind("AccommodatieId") %>' runat="server" />
			Actief : <asp:DropDownList ID="Actief" runat="server" DataTextField="Value" DataValueField="Value" SelectedValue='<%# Bind("Actief") %>' SelectMethod="SelectActief" OnCallingDataMethods="EditBaanSpeciaalform_CallingDataMethods" AppendDataBoundItems="true"><asp:ListItem  Text="Onbekend" Value="" Selected="True"></asp:ListItem> </asp:DropDownList></br>
            Baantoplaag : <asp:DropDownList ID="BaantoplaagId" runat="server" DataTextField="Naam" DataValueField="Id" SelectedValue='<%# Bind("BaantoplaagId") %>' SelectMethod="SelectBaantoplaag" OnCallingDataMethods="EditBaanSpeciaalform_CallingDataMethods" AppendDataBoundItems="true"><asp:ListItem  Text="Onbekend" Value="" Selected="True"></asp:ListItem> </asp:DropDownList></br>
        </fieldset>
    </EditItemTemplate>
</asp:FormView>
