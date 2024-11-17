using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    [KnownType(typeof(Problems))]

    public class Report:BaseEntity
    {
        protected Class classs;
        protected Tools tools;
        protected string description;
        protected Student student;
        [DataMember]
        public Class Classs { get => classs; set => classs = value; }
        [DataMember]
        public Tools Tools { get => tools; set => tools = value; }
        [DataMember]
        public string Description { get => description; set => description = value; }
        [DataMember]
        public Student Student { get => student; set => student = value; }
    }
}
