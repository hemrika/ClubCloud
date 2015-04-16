<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baan.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_BaanUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baan_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Banen_View" />
<asp:FormView runat="server" ID="SelectBaanform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectBaanform_CallingDataMethods" SelectMethod="SelectBaan" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Baan gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Baan beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Banen"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <ItemTemplate>
        <fieldset>
            <h1 class="title-regular clearfix">
                <%# ((FormView)Container).CurrentMode == FormViewMode.ReadOnly ? " Baan" : "" %>
            </h1>
			Naam : <asp:Label ID="Naam" runat="server" Text='<%# Eval("Naam") %>' /></br>
			Nummer : <asp:Label ID="Nummer" runat="server" Text='<%# Eval("Nummer") %>' /></br>
			Status : <asp:Label ID="Status" runat="server" Text='<%# Eval("Status") %>' /></br>
			Keuring : <asp:Label ID="Keuring" runat="server" Text='<%# Eval("Keuring") %>' /></br>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>

			Baanblok : <a href="Baanblok.aspx?Id=<%# Eval("BaanblokId") %>" target="_self" title="Baanblok" ><%# Eval("ClubCloud_Baanblok.Naam") %></a></br>
			Accommodatie : <a href="Accommodatie.aspx?Id=<%# Eval("AccommodatieId") %>" target="_self" title="Accommodatie" ><%# Eval("ClubCloud_Accommodatie.Naam") %></a></br>
			Baanschemas : <a href="Baanschemas.aspx?BaanId=<%# Eval("Id") %>" target="_self" title="Baanschemas" >Baanschemas</a></br>

		<asp:Button ID="btn_goback" runat="server" Text="Terug naar Banen" CausesValidation="false" OnClick="GoBack"/>
		<asp:Button ID="btn_edit" runat="server" Text="Baan bewerken" CausesValidation="false" OnClick="GoEdit"/>
        </fieldset>
    </ItemTemplate>
</asp:FormView>

