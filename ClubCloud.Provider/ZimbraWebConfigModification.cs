using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    internal class ZimbraWebConfigModification
    {
        private static List<SPWebConfigModification> _modifications;
        private static string _owner = "Zimbra";

        public static string Owner
        {
            get { return ZimbraWebConfigModification._owner; }
            set { ZimbraWebConfigModification._owner = value; }
        }
        public static List<SPWebConfigModification> Modifications
        {
            get
            {
                _modifications = new List<SPWebConfigModification>();

                AddSection();
                AddPeoplePicker();
                AddMembership();
                AddSafeControl();
                return _modifications;
            }
        }

        private static void AddSection()
        {

            /*
            <configSections>
            <sectionGroup name="Zimbra">
              <section name="Configuration" type="ClubCloud.Zimbra.Service.ZimbraConfigurationHandler,ClubCloud.Zimbra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
            </sectionGroup>         
            */
            //*[local-name()='sectionGroup'][*/@name='Zimbra']
            var sectionGroup = new SPWebConfigModification
            {
                
                Name = "*[local-name()='sectionGroup'][*/@name='Zimbra']",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/configSections",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<sectionGroup name=\"Zimbra\"><section name=\"Configuration\" type=\"ClubCloud.Zimbra.Service.ZimbraConfigurationHandler,ClubCloud.Zimbra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e\" /></sectionGroup>"
            };
            _modifications.Add(sectionGroup);

            /*
            <Zimbra>
            <Configuration>
                <Server Name="ClubCloud" ServerName="mail.clubcloud.nl" UserName="admin@clubcloud.nl" Password="rjm557308453!" IsAdmin="true" Encoded="false" />
                <Binding MaxReceivedMessageSize="2147483647" />
            </Configuration>
            </Zimbra>
            */
            var Zimbra = new SPWebConfigModification
            {
                Name = "Zimbra",
                Owner = Owner,
                Sequence = 1,
                Path = "configuration",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<Zimbra><Configuration><Server Name=\"ClubCloud\" ServerName=\"mail.clubcloud.nl\" UserName=\"admin@clubcloud.nl\" Password=\"rjm557308453!\" IsAdmin=\"true\" Encoded=\"false\" /><Binding MaxReceivedMessageSize=\"2147483647\" /></Configuration></Zimbra>"
            };
            _modifications.Add(Zimbra);
        }

        private static void AddPeoplePicker()
        {
            /*
            <SharePoint>
            <PeoplePickerWildcards>
              <clear />
              <add key="AspNetSqlMembershipProvider" value="%" />
              <add key="ZimbraMembershipProvider" value="" />
              <add key="ZimbraRoleProvider" value="" />
            </PeoplePickerWildcards>
            */
            var ZimbraMembershipProvider = new SPWebConfigModification
            {
                Name = "add[@key='ZimbraMembershipProvider'][@value='']",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/SharePoint/PeoplePickerWildcards",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add key=\"ZimbraMembershipProvider\" value=\"\" />"
            };
            _modifications.Add(ZimbraMembershipProvider);

            var ZimbraRoleProvider = new SPWebConfigModification
            {
                Name = "add[@key='ZimbraRoleProvider'][@value='']",
                Owner = Owner,
                Sequence = 1,
                Path = "configuration/SharePoint/PeoplePickerWildcards",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add key=\"ZimbraRoleProvider\" value=\"\" />"
            };
            _modifications.Add(ZimbraRoleProvider);

        }

        private static void AddMembership()
        {
            /*
            <system.web>
            <membership defaultProvider="i">
              <providers>
                <add name="i" type="Microsoft.SharePoint.Administration.Claims.SPClaimsAuthMembershipProvider, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" />
                <add name="ZimbraMembershipProvider" type="ClubCloud.Provider.ZimbraMembershipProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
              </providers>
            </membership>
            <roleManager defaultProvider="c" enabled="true" cacheRolesInCookie="false">
              <providers>
                <add name="c" type="Microsoft.SharePoint.Administration.Claims.SPClaimsAuthRoleProvider, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" />
                <add name="ZimbraRoleProvider" type="ClubCloud.Provider.ZimbraRoleProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
              </providers>
            </roleManager>
            */

            var ZimbraMembershipProvider = new SPWebConfigModification
            {
                Name = "add[@name='ZimbraMembershipProvider'][@type='ClubCloud.Provider.ZimbraMembershipProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e']",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/system.web/membership[@defaultProvider='i']/providers",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name=\"ZimbraMembershipProvider\" type=\"ClubCloud.Provider.ZimbraMembershipProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e\" />"
            };
            _modifications.Add(ZimbraMembershipProvider);

            var ZimbraRoleProvider = new SPWebConfigModification
            {
                Name = "add[@name='ZimbraRoleProvider'][@type='ClubCloud.Provider.ZimbraRoleProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e']",
                Owner = Owner,
                Sequence = 1,
                Path = "configuration/system.web/roleManager[@defaultProvider='c']/providers",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name=\"ZimbraRoleProvider\" type=\"ClubCloud.Provider.ZimbraRoleProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e\" />"
            };
            _modifications.Add(ZimbraRoleProvider);
        }

        private static void AddSafeControl()
        {
            var ZimbraRoleProvider = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e'][@Namespace='ClubCloud.Provider.Controls'][@TypeName='*'][@Safe='True'][@SafeAgainstScript='True']",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e' Namespace='ClubCloud.Provider.Controls' TypeName='*' Safe='True' SafeAgainstScript='True' />"
            };
            _modifications.Add(ZimbraRoleProvider);
        }
    }
}
