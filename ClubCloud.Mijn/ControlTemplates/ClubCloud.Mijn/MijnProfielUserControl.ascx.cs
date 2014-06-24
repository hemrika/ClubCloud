﻿using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml;
using System.Xml.Serialization;
using System.Web.UI.DataVisualization.Charting;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class MijnProfielUserControl : ClubCloudUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                SetPageData();
            }
            else
            {
                this.pnl_profiel.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        internal override void SetPageData()
        {
            if (Settings != null && Settings.mijnknltb_allow)
            {
                if (Settings.mijnknltb_tracking || !Settings.mijnknltb_tracking)
                {
                    try
                    {


                        ClubCloud_Gebruiker gebruiker = Client.GetClubCloudGebruiker(userId, false);

                        ClubCloud_Tracking tracking = Client.GetTracking(userId, false);
                        if (tracking != null && !string.IsNullOrWhiteSpace(tracking.Data))
                        {
                            Series enkel = new Series { Name = "Enkel", ChartType = SeriesChartType.SplineRange, XValueType = ChartValueType.String, YValueType = ChartValueType.Double };
                            Series dubbel = new Series { Name = "Enkel", ChartType = SeriesChartType.SplineRange, XValueType = ChartValueType.String, YValueType = ChartValueType.Double };

                            for (int i = 0; i < 13; i++)
                            {
                                enkel.Points.Insert(i, new DataPoint { AxisLabel = Enum.GetName(typeof(Months), i), YValues = new double[2] { Convert.ToDouble(gebruiker.RatingEnkel), Convert.ToDouble(gebruiker.RatingEnkel) } });
                                dubbel.Points.Insert(i, new DataPoint { AxisLabel = Enum.GetName(typeof(Months), i), YValues = new double[2] { Convert.ToDouble(gebruiker.RatingDubbel), Convert.ToDouble(gebruiker.RatingDubbel) } });
                            }

                            List<SpelersProfiel> profielen = (List<SpelersProfiel>)DeserializeObjectList<SpelersProfiel>(tracking.Data, "SpelersProfiel");

                            if (profielen != null)
                            {
                                List<SpelersProfiel> profielenByDatum = profielen.OrderByDescending(o => o.DatumDSS).ToList();
                                SpelersProfiel lastprofiel = profielenByDatum.LastOrDefault();

                                foreach (SpelersProfiel profiel in profielenByDatum)
                                {
                                    enkel.Points.RemoveAt(profiel.DatumDSS.Value.Month - 1);
                                    enkel.Points.Insert(profiel.DatumDSS.Value.Month - 1, new DataPoint { AxisLabel = Enum.GetName(typeof(Months), profiel.DatumDSS.Value.Month), YValues = new double[2] { Convert.ToDouble(profiel.EindejaarsratingEnkel.Value), Convert.ToDouble(profiel.RatingEnkel.Value) } });
                                    dubbel.Points.RemoveAt(profiel.DatumDSS.Value.Month - 1);
                                    dubbel.Points.Insert(profiel.DatumDSS.Value.Month - 1, new DataPoint { AxisLabel = Enum.GetName(typeof(Months), profiel.DatumDSS.Value.Month), YValues = new double[2] { Convert.ToDouble(profiel.EindejaarsratingDubbel.Value), Convert.ToDouble(profiel.RatingDubbel.Value) } });
                                }
                            }
                            else
                            {
                            }
                            cht_profiel.Series.Add(enkel);
                            cht_profiel.Series.Add(dubbel);

                        }
                    }
                    catch(Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
            else
            {
                pnl_authorize.Visible = true;
            }
        }

        public static List<T> DeserializeObjectList<T>(string xml, string separatorNode)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes(separatorNode);
            List<T> instances = new List<T>();
            foreach (XmlNode node in nodes)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlReaderSettings settings = new XmlReaderSettings();
                using (StringReader textReader = new StringReader(node.OuterXml))
                {
                    using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                    {
                        instances.Add((T)serializer.Deserialize(xmlReader));
                    }
                }
            }
            return instances;
        }
    }
}
