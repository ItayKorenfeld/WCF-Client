using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [CollectionDataContract]

    public class ClassList:List<Class>
    {
        public ClassList() { }
        public ClassList(IEnumerable<Class> list) : base(list) { }
        public ClassList(IEnumerable<BaseEntity> list) : base(list.Cast<Class>().ToList()) { }
    }
}
