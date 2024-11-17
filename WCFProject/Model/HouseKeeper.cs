using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [DataContract]
    public class HouseKeeper:Person
    {
        protected DateTime joinDate;
        [DataMember]
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
    }
}
