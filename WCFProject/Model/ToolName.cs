using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [DataContract]

    public class ToolName:BaseEntity
    {
        protected string toolName;
        [DataMember]
        public string ToolName1{ get => toolName; set => toolName = value; }
    }
}
