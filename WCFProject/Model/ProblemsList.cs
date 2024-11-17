using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [CollectionDataContract]

    public class ProblemsList: List<Problems>
    {
        public ProblemsList() { }
        public ProblemsList(IEnumerable<Problems> list) : base(list) { }
        public ProblemsList(IEnumerable<BaseEntity> list) : base(list.Cast<Problems>().ToList()) { }
    }
}
