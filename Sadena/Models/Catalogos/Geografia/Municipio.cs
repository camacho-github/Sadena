using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Sadena.Models.Entidades
{
    [DataContract]
    public class Municipio
    {
        [DataMember(Name = "MpioId", IsRequired = true)]
        [XmlAttribute("MpioId")]
        public int MpioId { get; set; }

        [DataMember(Name = "MpioDesc", IsRequired = true)]
        [XmlAttribute("MpioDesc")]
        public String MpioDesc { get; set; }

    }
}
