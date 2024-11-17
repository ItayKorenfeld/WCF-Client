using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [CollectionDataContract]
   public class ToolNameList : List<ToolName>
    {

        public ToolNameList() { }
        public ToolNameList(IEnumerable<ToolName> list) : base(list) { }
        public ToolNameList(IEnumerable<BaseEntity> list) : base(list.Cast<ToolName>().ToList()) { }

    
    }
}
