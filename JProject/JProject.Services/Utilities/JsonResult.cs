using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JProject.Services.Utilities
{
    [DataContract]
    public class JsonResult
    {
        //public JsonResult(int id, string name, string sex)
        //{
        //    _name = name;
        //    _id = id;
        //    _sex = sex;
        //}

        private string _name;

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _sex;

        [DataMember]
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private int _id;

        [DataMember]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}