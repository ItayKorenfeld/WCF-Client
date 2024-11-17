using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [DataContract]

    public class School:BaseEntity

    {
        protected string schoolName;
        protected ClassList classlist;
        [DataMember]
        public string SchoolName { get => schoolName; set => schoolName = value; }
        [DataMember]
        public ClassList Classlist { get => classlist; set => classlist = value; }
    }
}
