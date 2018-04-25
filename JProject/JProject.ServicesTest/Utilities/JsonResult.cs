﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JProject.ServicesTest.Utilities
{
    [DataContract]
    public class JsonResult
    {
        [DataMember]
        public bool IsError { get; set; }

        [DataMember]
        public string ErrorMsg { get; set; }
        [DataMember]
        public Object Data { get; set; }
    }
}
