using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [CollectionDataContract]

    public class HouseKeeperList: List<HouseKeeper>
    {
        public HouseKeeperList() { }
        public HouseKeeperList(IEnumerable<HouseKeeper> list) : base(list) { }
        public HouseKeeperList(IEnumerable<BaseEntity> list) : base(list.Cast<HouseKeeper>().ToList()) { }
    }
}
