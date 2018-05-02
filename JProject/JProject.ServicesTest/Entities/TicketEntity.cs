using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JProject.ServicesTest.Entities
{
    [DataContract]
    [KnownType(typeof(TicketEntity))]
    public class TicketEntity
    {
        [DataMember]
        public string title { get; set; }

        [DataMember]
        public bool budget { get; set; }

        [DataMember]
        public string urgency { get; set; }

        [DataMember]
        public DateTime deadline { get; set; }

        [DataMember]
        public string subject { get; set; }

        [DataMember]
        public string content { get; set; }

        [DataMember]
        public string category { get; set; }

        [DataMember]
        public string assignTo { get; set; }

        [DataMember]
        public string response { get; set; }

        [DataMember]
        public string department { get; set; }

    }
}
