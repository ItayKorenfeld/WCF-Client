using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [DataContract]

    public class Student:Person
    {
        protected Class classs;
        [DataMember]
        public Class Classs { get => classs; set => classs = value; }
    }
}
