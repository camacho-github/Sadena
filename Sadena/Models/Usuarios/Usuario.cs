using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Sadena.Models.Entidades
{
    [DataContract]
    public class Usuario
    {
        [DataMember(Name = "SesionId", IsRequired = true)]
        [XmlAttribute("SesionId")]
        public int SesionId { get; set; }

        [DataMember(Name = "UsuarioId", IsRequired = true)]
        [XmlAttribute("UsuarioId")]
        public int UsuarioId { get; set; }

        [DataMember(Name = "UsuarioDesc", IsRequired = true)]
        [XmlAttribute("UsuarioDesc")]
        public string UsuarioDesc { get; set; }

        [DataMember(Name = "CorreoE", IsRequired = true)]
        [XmlAttribute("CorreoE")]
        public string CorreoE { get; set; }

        [DisplayName("Contraseña")]
        public string Contrasenia { get; set; }

        [DataMember(Name = "RolId", IsRequired = true)]
        [XmlAttribute("RolId")]
        public Rol Rol { get; set; }

    }
}
