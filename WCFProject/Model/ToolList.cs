using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    [CollectionDataContract]

    public class ToolList: List<Tools>
    {
         
        public ToolList() { }
        public ToolList(IEnumerable<Tools> list) : base(list) { }
        public ToolList(IEnumerable<BaseEntity> list) : base(list.Cast<Tools>().ToList()) { }

    }
}

