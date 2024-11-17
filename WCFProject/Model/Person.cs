using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    [KnownType(typeof(Student))]
    [KnownType(typeof(HouseKeeper))]

    public class Person:BaseEntity

    {
        protected string firstName;
        protected string lastName;
        protected string realid;
        protected string phoneNumber;
        protected string password;
        protected School school;
        [DataMember]
        public string FirstName { get => firstName; set => firstName = value; }
        [DataMember]
        public string LastName { get => lastName; set => lastName = value; }
        [DataMember]
        public string Realid { get => realid; set => realid = value; }
        [DataMember]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        [DataMember]
        public string Password { get => password; set => password = value; }
        [DataMember]
        public School School { get => school; set => school = value; }
    }
}
