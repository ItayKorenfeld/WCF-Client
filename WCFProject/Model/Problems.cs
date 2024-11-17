using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Model
{
    [DataContract]

    public class Problems:Report
    {
        protected DateTime solvingTime;
        protected bool issolved;
        [DataMember]
        public DateTime SolvingTime { get => solvingTime; set => solvingTime = value; }
        [DataMember]
        public bool Issolved { get => issolved; set => issolved = value; }
    }
}
