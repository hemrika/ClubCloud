<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="Common" Namespace="ClubCloud.Common.Controls" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="Administratie" Namespace="ClubCloud.Administratie.WebControls" Assembly="ClubCloud.Administratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="ClubCloud" Assembly="ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" Namespace="ClubCloud.Common.Controls"  %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClubCloud_Baanblok.ascx.cs" Inherits="ClubCloud.Administratie.WebControls.ClubCloud_BaanblokUserControl" %>
<Common:ClubCloudDataSource ID="ClubCloud_Baanblok_DataSource" runat="server" OnDataBinding="Page_Load" ViewName="ClubCloud_Baanblokken_View" />
<asp:FormView runat="server" ID="SelectBaanblokform" DefaultMode="ReadOnly" RenderOuterTable="False" OnCallingDataMethods="SelectBaanblokform_CallingDataMethods" SelectMethod="SelectBaanblok" DataKeyNames="Id" >
    <EmptyDataTemplate>
        <h1 class="title-regular clearfix">
            Geen Baanblok gevonden</h1>
        <div class="notice">
            Sorry, er is geen  Baanblok beschikbaar voor dit Id.</div>
        <asp:Button ID="btn_goback" CausesValidation="false" runat="server" Text="Terug naar Baanblokken"
            OnClick="GoBack" SkinID="Button" />
    </EmptyDataTemplate>
    <ItemTemplate>
        <fieldset>
            <h1 class="title-regular clearfix">
                <%# ((FormView)Container).CurrentMode == FormViewMode.ReadOnly ? " Baanblok" : "" %>
            </h1>
			Naam : <asp:Label ID="Naam" runat="server" Text='<%# Eval("Naam") %>' /></br>
			Verlichting : <asp:Label ID="Verlichting" runat="server" Text='<%# Eval("Verlichting") %>' /></br>
			Locatie : <asp:Label ID="Locatie" runat="server" Text='<%# Eval("Locatie") %>' /></br>
			Actief : <asp:Label ID="Actief" runat="server" Text='<%# Eval("Actief") %>' /></br>

			Banen : <a href="Banen.aspx?BaanblokId=<%# Eval("Id") %>" target="_self" title="Banen" >Banen</a></br>
			Accommodatie : <a href="Accommodatie.aspx?Id=<%# Eval("AccommodatieId") %>" target="_self" title="Accommodatie" ><%# Eval("ClubCloud_Accommodatie.Naam") %></a></br>
			Baantype : <a href="Baantype.aspx?Id=<%# Eval("BaantypeId") %>" target="_self" title="Baantype" ><%# Eval("ClubCloud_Baantype.Naam") %></a></br>
			Baansoort : <a href="Baansoort.aspx?Id=<%# Eval("BaansoortId") %>" target="_self" title="Baansoort" ><%# Eval("ClubCloud_Baansoort.Naam") %></a></br>

		<asp:Button ID="btn_goback" runat="server" Text="Terug naar Baanblokken" CausesValidation="false" OnClick="GoBack"/>
		<asp:Button ID="btn_edit" runat="server" Text="Baanblok bewerken" CausesValidation="false" OnClick="GoEdit"/>
        </fieldset>
    </ItemTemplate>
</asp:FormView>

