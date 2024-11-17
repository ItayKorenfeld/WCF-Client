using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [CollectionDataContract]

    public class SchoolList:List<School>
    {
        public SchoolList() { }
        public SchoolList(IEnumerable<School> list) : base(list) { }
        public SchoolList(IEnumerable<BaseEntity> list) : base(list.Cast<School>().ToList()) { }
    }
}
