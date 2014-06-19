<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MijnVerenigingUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.MijnVerenigingUserControl" %>
<style >
    .capitalize {text-transform:capitalize;}
</style>
<asp:UpdatePanel ID="udp_verenigingen" runat="server">
    <contenttemplate>
        <asp:panel runat="server" ID="pnl_secure" Visible="False">
            <i class="icon-lock-1 special"></i>U moet ingelogd zijn om uw instellingen te kunnen wijzigen.
            <asp:LinkButton ID="btn_login" Text="Inloggen" OnClientClick="document.location.href ='https://mijn.clubcloud.nl/_zimbra/default.aspx'; return false" runat="server" /><br />
        </asp:panel>
        <fieldset>
        <asp:panel runat="server" ID="pnl_verenigingen" GroupingText="Verenigingen :">
            <asp:ListView ID="lst_verenigingen" runat="server" DataKeyNames="VerenigingId" OnSelectedIndexChanged="lst_verenigingen_SelectedIndexChanged"  >
                <GroupTemplate>
                    <ul class="clubs">
                        <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                    </ul>
                </GroupTemplate>
                <ItemTemplate>
                    <li><asp:Label ID="lbl_Naam" runat="server" Text='<%# Eval("VerenigingNaam")%>' ></asp:Label></li> 
                </ItemTemplate>
                <EmptyItemTemplate>
                    <div>Geen gegevens gevonden.</div>
                </EmptyItemTemplate>
            </asp:ListView>
            <hr />

            <asp:FormView ID="fvw_vereniging" RunAt="server" CssClass="one-half first">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                      <div>
                        <i class="icon-address special"></i>
                        <div class="info">
                        <h3 class="lined"><%# DataBinder.Eval(Container.DataItem, "Naam")%> ( <%# DataBinder.Eval(Container.DataItem, "Verenigingsnummer")%> )</h3>
                            <p class="capitalize">
                                District : <b><%# DataBinder.Eval(Container.DataItem, "District") %></b> | Regio : <b><%# DataBinder.Eval(Container.DataItem, "Regio") %></b> | Opgericht : <b><%# DataBinder.Eval(Container.DataItem, "DatumOpgericht","{0:yyyy}") %></b>
                            </p>
                            <p class="capitalize">
                            <b>Bezoek adres : </b><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Bezoekadres")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "BezoekadresPostcode")).ToUpper() %>, <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "BezoekadresPlaats")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "BezoekadresGemeente")).ToLower() %><br />
                            </p>
                            <p class="capitalize">
                            <b>Post adres : </b><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Postadres")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostadresPostcode")).ToUpper() %>, <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostadresPlaats")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostadresGemeente")).ToLower() %><br />
                            </p>
                            <p >
                            <b>Contact : </b><br />
                                Website : <a href='http://<%# DataBinder.Eval(Container.DataItem, "Website") %>' target="_blank" >http://<%# DataBinder.Eval(Container.DataItem, "Website") %></a><br />Email : <a href='mailto:<%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Emailadres")).ToLower() %>' ><%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Emailadres")).ToLower() %></a><br />
                                Telefoon Overdag : <a href='tel:<%# DataBinder.Eval(Container.DataItem, "TelefoonnummerOverdag") %>' ><%# DataBinder.Eval(Container.DataItem, "TelefoonnummerOverdag") %></a><br />
                                Telefoon Avond : <a href='tel:<%# DataBinder.Eval(Container.DataItem, "TelefoonnummerAvond") %>' ><%# DataBinder.Eval(Container.DataItem, "TelefoonnummerAvond") %></a><br />
                            </p>
                            <p class="capitalize">
                            <b>Gegevens : </b><br />
                                KvK : <%# DataBinder.Eval(Container.DataItem, "KvKnummer") %>, <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "KvKplaats")).ToLower() %><br />
                                IBAN : <%# DataBinder.Eval(Container.DataItem, "IbanCode") %><br />
                            </p>
                        </div>
                    </div>

                </ItemTemplate>
                <EmptyDataTemplate>
                    <div class="one-half first">
                        <i class="icon-address special"></i>
                        <div class="info">
                        <h3 class="lined">Geen vereniging gevonden.</h3>
                        <p>
                            Er zijn voor u geen verenigingen gevonden.
                        </p>                        
                        </div>
                    </div>
                    <div class="clear"></div>
                </EmptyDataTemplate>
              </asp:FormView>
              <asp:FormView ID="fvw_accomodatie" RunAt="server" CssClass="one-half last">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                      <div>
                        <i class="icon-home special"></i>
                        <div class="info">
                        <h3 class="lined">Accomodatie : <%# Eval("AccommodatieNaam")%></h3>
                        <p>
                            Bezoekadres : <asp:Label ID="lbl_Bezoekadres" runat="server" Text='<%# Eval("Bezoekadres")%>' /><br />
                            PostAdres : <%#(String.IsNullOrWhiteSpace(Eval("PostAdres").ToString()) ? "onbekend" : Eval("PostAdres"))%><br />
                            Minibanen : <asp:Label ID="lbl_Minibanen" runat="server" Text='<%# Eval("Minibanen")%>' /><br />
                            Oefenmuren: <%#(String.IsNullOrWhiteSpace(Eval("Oefenmuren").ToString()) ? "onbekend" : Eval("Oefenmuren"))%><asp:Label ID="lbl_Oefenmuren" runat="server" Text='<%# Eval("Oefenmuren")%>' /><br />
                            Ondergrond : <asp:Label ID="lbl_Ondergrond" runat="server" Text='<%# Eval("Ondergrond")%>' /><br />
                            Playgrounds : <asp:Label ID="lbl_Playgrounds" runat="server" Text='<%# Eval("Playgrounds")%>' /><br />
                            Speeltoestellen : <asp:Label ID="lbl_Speeltoestellen" runat="server" Text='<%# Eval("Speeltoestellen")%>' /><br />
                            TelefoonNummer : <asp:Label ID="lbl_TelefoonNummer" runat="server" Text='<%# Eval("TelefoonNummer")%>' /><br />
                        </p>
                        </div>
                    </div>
                    <div class="clear"></div>   
                </ItemTemplate>
                <EmptyDataTemplate>
                    <div class="one-half first">
                        <i class="icon-home special"></i>
                        <div class="info">
                        <h3 class="lined">Geen accomodatie gevonden.</h3>
                        <p>
                            Er zijn voor u geen accomodaties gevonden.
                        </p>                        
                        </div>
                    </div>
                    <div class="clear"></div>
                </EmptyDataTemplate>
              </asp:FormView>
              <asp:FormView ID="fvw_bestuur" RunAt="server" CssClass="one-half first">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                      <div>
                        <i class="icon-home special"></i>
                        <div class="info">
                        <h3 class="lined">Bestuur</h3>
                        <p>
                        </p>
                        </div>
                    </div>
                    <div class="clear"></div>   
                </ItemTemplate>
                <EmptyDataTemplate>
                    <div class="one-half first">
                        <i class="icon-home special"></i>
                        <div class="info">
                        <h3 class="lined">Geen bestuur gevonden.</h3>
                        <p>
                            Er is voor u geen bestuur gevonden.
                        </p>                        
                        </div>
                    </div>
                    <div class="clear"></div>
                </EmptyDataTemplate>
              </asp:FormView>
              <asp:FormView ID="fvw_functionarissen" RunAt="server" CssClass="one-half last" >
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                      <div>
                        <i class="icon-home special"></i>
                        <div class="info">
                        <h3 class="lined">Functionarissen</h3>
                        <p>
                            Functionaris
                        </p>
                        </div>
                    </div>
                    <div class="clear"></div>   
                </ItemTemplate>
                <EmptyDataTemplate>
                    <div class="one-half first">
                        <i class="icon-home special"></i>
                        <div class="info">
                        <h3 class="lined">Geen functionarissen gevonden.</h3>
                        <p>
                            Er zijn voor u geen functionarissen gevonden.
                        </p>                        
                        </div>
                    </div>
                    <div class="clear"></div>
                </EmptyDataTemplate>
              </asp:FormView>
            <br>
        <div class="clear"></div>                    
        </asp:panel>
        </fieldset>
    </contenttemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_verenigingen_progress" runat="server" AssociatedUpdatePanelID="udp_verenigingen">
    <progresstemplate>
    Bezig met verwerken.    
</progresstemplate>
</asp:UpdateProgress>
