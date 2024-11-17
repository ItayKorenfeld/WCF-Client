using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [DataContract]
    public class Tools:BaseEntity
    {
        protected ToolName toolName;
        protected Class classs;
        [DataMember]
        public ToolName ToolName { get => toolName; set => toolName = value; }
        [DataMember]
        public Class Classs { get => classs; set => classs = value; }
    }
}
