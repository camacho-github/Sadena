using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace Sadena.Models.Entidades
{
    [DataContract]
    public class Rol
    {

        [DataMember(Name = "RolId", IsRequired = true)]
        [XmlAttribute("RolId")]
        public int RolId { get; set; }

        [DataMember(Name = "RolDesc", IsRequired = true)]
        [XmlAttribute("RolDesc")]
        public String RolDesc { get; set; }
    }
}
