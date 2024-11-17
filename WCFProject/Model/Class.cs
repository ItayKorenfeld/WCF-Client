using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Class:BaseEntity

    {
        protected string className;
        protected School school;
        [DataMember]
        public string ClassName { get => className; set => className = value; }
        [DataMember]
        public School School { get => school; set => school = value; }
    }
}
