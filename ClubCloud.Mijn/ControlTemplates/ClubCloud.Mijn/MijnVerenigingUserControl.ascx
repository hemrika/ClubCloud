﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MijnVerenigingUserControl.ascx.cs" Inherits="ClubCloud.Mijn.ControlTemplates.MijnVerenigingUserControl" %>
<asp:UpdatePanel ID="udp_verenigingen" runat="server">
    <contenttemplate>
        <asp:Timer runat="server" ID="tmr_loader_verenigingen" OnTick="tmr_loader_verenigingen_Tick" interval="50" />
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
        <asp:panel runat="server" ID="pnl_verenigingen" CssClass="one-half first" >
            <asp:ListView ID="lst_verenigingen" runat="server" DataKeyNames="Id" OnSelectedIndexChanged="lst_verenigingen_SelectedIndexChanged" >
                <GroupTemplate>
                    <ul class="clubs">
                        <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                    </ul>
                </GroupTemplate>
                <ItemTemplate>
                    <li><asp:Label ID="lbl_Naam" runat="server" Text='<%# Eval("Begin")%>' ></asp:Label></li> 
                </ItemTemplate>
                <EmptyItemTemplate>
                    <div>Geen gegevens gevonden.</div>
                </EmptyItemTemplate>
            </asp:ListView>
            <hr />

            <asp:FormView ID="fvw_vereniging" RunAt="server" RenderOuterTable="False">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                      <div>
                        <i class="icon-address special"></i>
                        <div class="info">
                        <h3 class="lined"><%# DataBinder.Eval(Container.DataItem, "Naam")%> ( <%# DataBinder.Eval(Container.DataItem, "Nummer")%> )</h3>
                            <p class="capitalize">
                                District : <b><%# DataBinder.Eval(Container.DataItem, "District") %></b> | Regio : <b><%# DataBinder.Eval(Container.DataItem, "Regio") %></b> | Opgericht : <b><%# DataBinder.Eval(Container.DataItem, "Oprichting","{0:yyyy}") %></b>
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
              <asp:FormView ID="fvw_accomodatie" RunAt="server" RenderOuterTable="False">
                <HeaderStyle backcolor="#f9f9f9" 
                  forecolor="#616161" />
                <RowStyle backcolor="#f9f9f9"/>         
                <EditRowStyle backcolor="#f9f9f9"/>
                <ItemTemplate>
                      <div>
                        <i class="icon-home special"></i>
                        <div class="info">
                        <h3 class="lined">Accomodatie : <%# Eval("AccommodatieNaam")%></h3>
                        <p class="capitalize">
                                Ondergrond : <b><%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Ondergrond")).ToLower() %></b> | Oefenmuren : <b><%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Oefenmuren")).ToLower() %></b>
                        </p>
                        <p class="capitalize">
                            <b>Bezoek adres : </b><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Bezoekadres.Straat")).ToLower() %> <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Bezoekadres.Huisnummer")).ToLower() %> <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Bezoekadres.Toevoeging")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Bezoekadres.Postcode")).ToUpper() %>, <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Bezoekadres.Plaats")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Bezoekadres.Gemeente")).ToLower() %><br />
                        </p>
                        <p class="capitalize">
                            <b>Post adres : </b><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostAdres.Straat")).ToLower() %> <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostAdres.Huisnummer")).ToLower() %> <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostAdres.Toevoeging")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostAdres.Postcode")).ToUpper() %>, <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostAdres.Plaats")).ToLower() %><br />
                            <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "PostAdres.Gemeente")).ToLower() %><br />
                        </p>
                        <p >
                            <b>Contact : </b><br />
                            TelefoonNummer : <a href='tel:<%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "TelefoonNummer")).ToLower() %>' ><%# DataBinder.Eval(Container.DataItem, "TelefoonNummer") %></a><br /> <br />
                        </p>
                        <p class="capitalize">
                        <b>Faciliteiten : </b><br />
                            Minibanen : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Minibanen")).ToLower() %> <br />
                            Oefenmuren: <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Oefenmuren")).ToLower() %> <br />
                            Playgrounds : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Playgrounds")).ToLower() %> <br />
                            Speeltoestellen : <%# String.Format("{0}",DataBinder.Eval(Container.DataItem, "Speeltoestellen")).ToLower() %> <br />
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
              <asp:FormView ID="fvw_bestuur" RunAt="server" RenderOuterTable="False">
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
              <asp:FormView ID="fvw_functionarissen" RunAt="server" RenderOuterTable="False">
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
    <triggers>
             <asp:AsyncPostBackTrigger ControlID="tmr_loader_verenigingen" EventName="Tick" />
    </triggers>
</asp:UpdatePanel>
<asp:UpdateProgress ID="udp_verenigingen_progress" runat="server" AssociatedUpdatePanelID="udp_verenigingen" DisplayAfter="50">
    <progresstemplate>
        <div class="progess" style="position: absolute; background-color: #F9F9F9; top: 0px; left: 0px; width: 100%; height: 100%; opacity: 0.8; -moz-opacity: 0.8; filter: alpha(opacity=80); -ms-filter: "progid:DXImageTransform.Microsoft.Alpha(Opacity=80)"; z-index: 10000;">
        <div class="bubbles aligncenter" style="top:48%;">laden...</div>
        </div>
</progresstemplate>
</asp:UpdateProgress>