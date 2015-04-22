using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Status do c�digo de seguran�a do cart�o.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum CardSecurityCodeStatus
    {
        /// <summary>
        ///     Nenhum.
        /// </summary>
        None,

        /// <summary>
        ///     N�o informado.
        /// </summary>
        [XmlEnum("0")] NotProvided,

        /// <summary>
        ///     Informado.
        /// </summary>
        [XmlEnum("1")] Provided,

        /// <summary>
        ///     Ileg�vel.
        /// </summary>
        [XmlEnum("2")] Unreadable,

        /// <summary>
        ///     Inexistente.
        /// </summary>
        [XmlEnum("9")] Absent
    }
}