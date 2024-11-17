using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    [DataContract]
    [KnownType(typeof(Person))]
    [KnownType(typeof(Report))]
    [KnownType(typeof(Class))]
    [KnownType(typeof(School))]
    [KnownType(typeof(Tools))]
    [KnownType(typeof(ToolName))]
    public class BaseEntity
    {

        protected int id;
        [DataMember]
        public int Id { get => id; set => id = value; }

    }
}
