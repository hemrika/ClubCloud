<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MijnGegevensUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.MijnGegevensUserControl" %>
<style >
    .capitalize {text-transform:capitalize;}
</style>
<asp:UpdatePanel ID="udp_profiel" runat="server">
    <contenttemplate>
        <asp:panel runat="server" ID="pnl_secure" Visible="False">
            <i class="icon-lock-1 special"></i>U moet ingelogd zijn om uw instellingen te kunnen wijzigen.
            <asp:LinkButton ID="btn_login" Text="Inloggen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/_zimbra/default.aspx'; return false" runat="server" /><br />
        </asp:panel>
        <asp:panel runat="server" ID="pnl_authorize" Visible="False">
            <div class="first">
                <i class="icon-magic special"></i>
                <div class="info">
                <h3 class="lined">Toegang verlenen</h3>
                    <p>
                        Om uw gegevens te bekijken en te wijzigingen moet u toegang verlenen tot uw KNLTB gegevens onder instellingen.<br />
                        Na het verlenen van de toegang, kunt u zelf al uw gegevens inzien en beheren.
                    </p>
                    <asp:LinkButton ID="Instellingen" Text="Instellingen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/instellingen.aspx'; return false" runat="server" CssClass="button small" /><br />
                </div>
            </div>  
        </asp:panel>
        <fieldset>
        <asp:panel runat="server" ID="pnl_profiel" >
              <asp:FormView ID="fvw_afbeelding" RunAt="server" CssClass="one-half first" OnItemUpdated="fvw_afbeelding_ItemUpdated" OnItemUpdating="fvw_afbeelding_ItemUpdating" OnModeChanged="fvw_afbeelding_ModeChanged" OnModeChanging="fvw_afbeelding_ModeChanging" OnItemCommand="fvw_afbeelding_ItemCommand">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                        <i class="icon-picture special"></i>
                        <div class="info" style="min-height:420px;">
                        <h3 class="lined">Profiel Foto</h3>
                            <p>
                                <asp:Image ID="profielfoto" runat="server" Width="25%" />
                            </p>
                            <asp:LinkButton ID="btn_editafbeelding" Text="Wijzigen" CommandName="Edit" RunAt="server" CssClass="button small alignright last" Enabled="False" />
                        </div>
                    <div class="clear"></div>
                </ItemTemplate>
                <EditItemTemplate>                       
                    <i class="icon-picture special" style="color:#0072C6;"></i>
                        <div class="info" style="min-height:420px;">
                        <h3 class="lined">Profiel Foto</h3>
                            <fieldset>
                            <p></p>
                            <asp:LinkButton ID="CancelUpdateButton" Text="Klaar" CommandName="Cancel" RunAt="server" CssClass="button small alignright"/>
                            <asp:LinkButton ID="UpdateButton" Text="Opslaan" CommandName="Update" RunAt="server" CssClass="button small alignright padleft"/>
                                </fieldset>
                        </div>
                    <div class="clear"></div>
                </EditItemTemplate>
                <EmptyDataTemplate>
                        <i class="icon-picture special"></i>
                        <div class="info" style="min-height:420px;">
                        <h3 class="lined">Profiel Foto</h3>
                        <p>
                            Er zijn voor u geen gegevens gevonden.
                        </p>                        
                        </div>
                    <div class="clear"></div>
                </EmptyDataTemplate>
              </asp:FormView>

              <asp:FormView ID="fvw_persoon" RunAt="server" CssClass="one-half last" OnItemUpdated="fvw_persoon_ItemUpdated" OnItemUpdating="fvw_persoon_ItemUpdating" OnModeChanged="fvw_persoon_ModeChanged" OnModeChanging="fvw_persoon_ModeChanging" OnItemCommand="fvw_persoon_ItemCommand">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                        <i class="icon-vcard special"></i>
                        <div class="info" style="min-height:420px;">
                        <h3 class="lined"><%# DataBinder.Eval(Container.DataItem, "Volledigenaam")%> ( <asp:Label ID="knltbid" runat="server" /> )</h3>
                            <p class="capitalize">
                                District : <b><%# DataBinder.Eval(Container.DataItem, "DistrictNaam") %></b> | Vereniging : <b><a href="vereniging.aspx"><%# DataBinder.Eval(Container.DataItem, "OrganisatieNummer") %></a></b> | Lid : <b><%# DataBinder.Eval(Container.DataItem, "IsLid") %></b>
                            </p>
                            <p class="capitalize">
                            <b>Persoonsgegevens : </b><br />
                            Roepnaam : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Roepnaam")).ToLower() %><br /> 
                            Initialen : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Voorletters")).ToUpper() %><br />
                            Voornamen : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Voornamen")).ToLower() %><br />
                            Tussenvoegsel : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Tussenvoegsel")).ToLower() %><br />
                            Achternaam : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Achternaam")).ToLower() %><br />
                            Toevoeging : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Toevoeging")).ToLower() %><br />
                            Geboortedatum : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Geboortedatum","{0:dd-MM-yyyy}")).ToUpper() %><br />
                            Geboorteplaats : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Geboorteplaats")).ToLower() %><br />
                            Geslacht : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Geslacht")).ToLower() %><br />
                            Nationaliteit : Nederlandse <!-- <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "NationaliteitId")).ToLower() %><br /> -->
                            </p>
                            <asp:LinkButton ID="btn_editpersoon" Text="Wijzigen" CommandName="Edit" RunAt="server" CssClass="button small alignright last"/>
                        </div>
                    <div class="clear"></div>
                </ItemTemplate>
                <EditItemTemplate>
                    <i class="icon-vcard special" style="color:#0072C6;"></i>
                        <div class="info" style="min-height:420px;">
                        <h3 class="lined"><%# DataBinder.Eval(Container.DataItem, "VolledigeNaam")%> ( <asp:Label ID="knltbid" runat="server" /> )</h3>
                            <fieldset>
                            <p>
                                Roepnaam : <asp:TextBox ID="Roepnaam" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Roepnaam") %>' /><br />
                                Initialen : <asp:TextBox ID="Voorletters" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Voorletters") %>' /><br />
                                Voornamen : <asp:TextBox ID="Voornamen" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Voornamen") %>' /><br />
                                Tussenvoegsel : <asp:TextBox ID="Tussenvoegsel" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Tussenvoegsel") %>' /><br />
                                Achternaam : <asp:TextBox ID="Achternaam" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Achternaam") %>' /><br />
                                Toevoeging : <asp:TextBox ID="Toevoeging" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Toevoeging") %>' /><br />
                                Geboortedatum : <asp:TextBox ID="Geboortedatum" TextMode="Date" runat="server" Text='<%# Bind(Container.DataItem, "Geboortedatum") %>' /><br />
                                Geboorteplaats : <asp:TextBox ID="Geboorteplaats" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Geboorteplaats") %>' /><br />
                                Geslacht : <asp:DropDownList ID="Geslacht" runat="server">
                                    <asp:ListItem Value="1">Man</asp:ListItem>
                                    <asp:ListItem Value="2">Vrouw</asp:ListItem>
                                </asp:DropDownList><br />
                                Nationaliteit : <asp:DropDownList ID="NationaliteitId" runat="server" >
                                    <asp:ListItem Value="10ABFFAF-6832-45A7-A976-53B8B89042B0">Nederlandse</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                            </p>
                            <asp:LinkButton ID="CancelUpdateButton" Text="Klaar" CommandName="Cancel" RunAt="server" CssClass="button small alignright"/>
                            <asp:LinkButton ID="UpdateButton" Text="Opslaan" CommandName="Update" RunAt="server" CssClass="button small alignright padleft"/>
                                </fieldset>
                        </div>
                    <div class="clear"></div>                
                </EditItemTemplate>
                <EmptyDataTemplate>
                        <i class="icon-vcard special"></i>
                        <div class="info" style="min-height:420px;">
                        <h3 class="lined">Geen gegevens gevonden.</h3>
                        <p>
                            Er zijn voor u geen gegevens gevonden.
                        </p>                        
                        </div>
                    <div class="clear"></div>
                </EmptyDataTemplate>
              </asp:FormView>

              <asp:FormView ID="fvw_adres" RunAt="server" CssClass="one-half first" OnItemUpdated="fvw_adres_ItemUpdated" OnItemUpdating="fvw_adres_ItemUpdating" OnModeChanged="fvw_adres_ModeChanged" OnModeChanging="fvw_adres_ModeChanging" OnItemCommand="fvw_adres_ItemCommand">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                        <i class="icon-address special"></i>
                        <div class="info" style="min-height:240px;">
                        <h3 class="lined">Adres gegevens</h3>
                            <p class="capitalize">
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Straat")).ToLower() %> <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Huisnummer")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Postcode")).ToUpper() %>, <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Plaats")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Gemeente")).ToLower() %><br />
                            </p>
                            <asp:LinkButton ID="btn_editadres" Text="Wijzigen" CommandName="Edit" RunAt="server" CssClass="button small alignright last"/>
                        </div>
                </ItemTemplate>
                <EditItemTemplate>
                    <i class="icon-address special" style="color:#0072C6;"></i>
                        <div class="info" style="min-height:240px;">
                        <h3 class="lined">Adres gegevens</h3>
                            <fieldset>
                            <p class="capitalize">
                            Straat : <asp:TextBox ID="Straat" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Straat") %>' /><br />
                            Huisnummer : <br /><asp:TextBox ID="Huisnummer" TextMode="Number" runat="server" Text='<%# Bind(Container.DataItem, "Huisnummer") %>' /><br />
                            Postcode : <asp:TextBox ID="Postcode" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Postcode") %>' /><br />
                            Plaats : <asp:TextBox ID="Plaats" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Plaats") %>' /><br />
                            Gemeente : <asp:TextBox ID="Gemeente" TextMode="SingleLine" runat="server" Text='<%# Bind(Container.DataItem, "Gemeente") %>' /><br />
                            </p>
                            <asp:LinkButton ID="CancelUpdateButton" Text="Klaar" CommandName="Cancel" RunAt="server" CssClass="button small alignright"/>
                            <asp:LinkButton ID="UpdateButton" Text="Opslaan" CommandName="Update" RunAt="server" CssClass="button small alignright padleft"/>
                                </fieldset>
                        </div>
                    <div class="clear"></div>                
                </EditItemTemplate>
                <EmptyDataTemplate>
                        <i class="icon-address special"></i>
                        <div class="info" style="min-height:240px;">
                        <h3 class="lined">Adres gegevens</h3>
                        <p>
                            Er zijn voor u geen gegevens gevonden.
                        </p>                        
                        </div>
                    <div class="clear"></div>
                </EmptyDataTemplate>
              </asp:FormView>

              <asp:FormView ID="fvw_contact" RunAt="server" CssClass="one-half last" OnItemUpdated="fvw_contact_ItemUpdated" DataKeyNames="Id" OnModeChanging="fvw_contact_ModeChanging" OnItemUpdating="fvw_contact_ItemUpdating" OnModeChanged="fvw_contact_ModeChanged" OnItemCommand="fvw_contact_ItemCommand">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                        <i class="icon-mail special"></i>
                        <div class="info" style="min-height:240px;">
                        <h3 class="lined">Contact gegevens</h3>
                            <p>
                            Telefoon Overdag : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "TelefoonOverdag")).ToLower() %><br />
                            Telefoon Avond : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "TelefoonAvond")).ToLower() %><br />
                            Mobiel : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Mobiel")).ToLower() %><br /> 
                            Email : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "EmailKNLTB")).ToLower() %><br />
                            </p>
                            <asp:LinkButton ID="btn_editcontact" Text="Wijzigen" CommandName="Edit" RunAt="server" CssClass="button small alignright last"/>
                        </div>
                    <div class="clear"></div>
                </ItemTemplate>
                <EditItemTemplate>
                        <i class="icon-mail special" style="color:#0072C6;"></i>
                        <div class="info" style="min-height:240px;">
                        <h3 class="lined">Contact gegevens</h3>
                            <fieldset>
                            <p>
                            Telefoon Overdag : <asp:TextBox ID="TelefoonOverdag" TextMode="Phone" runat="server" Text='<%# Bind("TelefoonOverdag") %>' /><br />
                            Telefoon Avond : <asp:TextBox ID="TelefoonAvond" TextMode="Phone" runat="server" Text='<%# Bind("TelefoonAvond") %>' /><br />
                            Mobiel : <asp:TextBox ID="Mobiel" TextMode="Phone" runat="server" Text='<%# Bind("Mobiel") %>' /><br />
                            Email : <asp:TextBox ID="Email" TextMode="Email" runat="server" Text='<%# Bind("Email") %>' /><br />
                            </p>                            
                            <asp:LinkButton ID="CancelUpdateButton" Text="Klaar" CommandName="Cancel" RunAt="server" CssClass="button small alignright" />
                            <asp:LinkButton ID="UpdateButton" Text="Opslaan" CommandName="Update" RunAt="server" CssClass="button small alignright"/>
                            </fieldset>
                        </div>
                    <div class="clear"></div>
                </EditItemTemplate>
                <EmptyDataTemplate>
                        <i class="icon-mail special"></i>
                        <div class="info" style="min-height:240px;">
                        <h3 class="lined">Contact gegevens</h3>
                        <p>
                            Er zijn voor u geen gegevens gevonden.
                        </p>                        
                        </div>
                    <div class="clear"></div>
                </EmptyDataTemplate>
              </asp:FormView>

        </asp:panel>
        </fieldset>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_profiel_progress" runat="server" AssociatedUpdatePanelID="udp_profiel">
    <progresstemplate>
        bezig met verwerken...
</progresstemplate>
</asp:UpdateProgress>
