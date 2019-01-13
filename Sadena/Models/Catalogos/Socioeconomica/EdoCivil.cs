using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Sadena.Models.Entidades
{
    [DataContract]
    public class EdoCivil
    {
        [DataMember(Name = "EdoCivilId", IsRequired = true)]
        [XmlAttribute("EdoCivilId")]
        public int EdoCivilId { get; set; }

        [DataMember(Name = "EdoCivilDesc", IsRequired = true)]
        [XmlAttribute("EdoCivilDesc")]
        public String EdoCivilDesc { get; set; }
    }
}
