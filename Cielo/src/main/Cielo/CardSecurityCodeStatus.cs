using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum CardSecurityCodeStatus
    {
        /// <summary>
        ///     N�o informado
        /// </summary>
        [XmlEnum("0")] NotProvided,

        /// <summary>
        ///     Informado
        /// </summary>
        [XmlEnum("1")] Provided,

        /// <summary>
        ///     Ileg�vel
        /// </summary>
        [XmlEnum("2")] Unreadable,

        /// <summary>
        ///     Inexistente
        /// </summary>
        [XmlEnum("9")] Absent
    }
}