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
    [KnownType(typeof(SpelerTracking))]

    public class SpelerTracking
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public List<SpelersProfiel> Data { get; set; }

    }
}
