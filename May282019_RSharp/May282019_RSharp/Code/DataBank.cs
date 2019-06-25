using System;
using System.Runtime.Serialization;

namespace May282019_RSharp.Code
{
    public class DataBank
    {
        public DataBank()
        {
        }

        [DataContract]
        public class Person
        {
            [DataMember]public int employeeId;
            [DataMember]public String firstName;
            [DataMember]public String lastName;
            [DataMember]public String email;
            [DataMember]public String phone;
        }
    }
}
