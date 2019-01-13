﻿using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Sadena.Models.Contratos
{
    [DataContract]
    public class CabeceroPeticion
    {
        [DataMember(Name = "SesionId", IsRequired = true)]
        [XmlAttribute("SesionId")]
        public int SesionId { get; set; }
    }
}