using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Service.Model
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(SpelersProfiel))]

    public partial class SpelersProfiel : GetSpelersProfielDetailResponse
    {
        public SpelersProfiel()
        { }

        [DataMember]
        public new DateTime? DatumDSS { get { return base.DatumDSS; } }

        [DataMember]
        public new decimal? EindejaarsratingDubbel { get{ return base.EindejaarsratingDubbel;} }

        [DataMember]
        public new decimal? EindejaarsratingEnkel { get { return base.EindejaarsratingEnkel; } }

        [DataMember]
        public new int? PartijresultatenDubbel { get { return base.PartijresultatenDubbel; } }

        [DataMember]
        public new int? PartijResultatenDubbelDss { get { return base.PartijResultatenDubbelDss; } }

        [DataMember]
        public new int? PartijresultatenEnkel { get { return base.PartijresultatenEnkel; } }

        [DataMember]
        public new  int? PartijResultatenEnkelDss { get { return base.PartijResultatenEnkelDss; } }

        [DataMember]
        public new  decimal? RatingDubbel { get { return base.RatingDubbel; } }

        [DataMember]
        public new  decimal? RatingEnkel { get { return base.RatingEnkel; } }

        [DataMember]
        public new  decimal? SpeelsterkteDubbel { get { return base.SpeelsterkteDubbel; } }

        [DataMember]
        public new  decimal? SpeelsterkteEnkel { get { return base.SpeelsterkteEnkel; } }

        [DataMember]
        public new  string WeergaveNaam { get { return base.WeergaveNaam; } }


    }
}
