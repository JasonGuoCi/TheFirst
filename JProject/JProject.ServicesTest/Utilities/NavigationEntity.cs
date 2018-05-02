using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JProject.ServicesTest.Utilities
{
    [DataContract]
    [KnownType(typeof(NavigationEntity))]
    public class NavigationEntity
    {
        //private string 

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int ID { get; set; }


        [DataMember]
        public string Sex { get; set; }


    }
}
