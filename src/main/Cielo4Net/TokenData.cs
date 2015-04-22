using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Dados do token do cart�o de cr�dito.
    /// </summary>
    [XmlType]
    [Serializable]
    public class TokenData
    {
        /// <summary>
        ///     Recupera ou define c�digo.
        /// </summary>
        [XmlElement("codigo-token")]
        public string Code { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TokenStatus" />.
        /// </summary>
        [XmlElement("status")]
        public TokenStatus Status { get; set; }

        /// <summary>
        ///     Recupera ou define n�mero do cart�o truncado.
        /// </summary>
        [XmlElement("numero-cartao-truncado")]
        public string TruncateCardNumber { get; set; }
    }
}