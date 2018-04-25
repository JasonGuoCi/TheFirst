using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JProject.Services.Utilities
{
    [DataContract]
    public class JsonResult2
    {
        //private string 
        private List<JsonResult> rows;
        [DataMember]
        public List<JsonResult> ROWS { get; set; }
        [DataMember]
        private int count;
        [DataMember]
        public int COUNT { get; set; }
       
        public JsonResult2(int Count, List<JsonResult> Rows)
        {
            count = Count;
            rows = Rows;

        }
    }
}