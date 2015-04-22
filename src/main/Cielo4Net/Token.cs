using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    /// Token do cart�o de cr�dito.
    /// </summary>
    [XmlType]
    [Serializable]
    public class Token
    {
        /// <summary>
        /// Recupera ou define <see cref="TokenData"/>.
        /// </summary>
        [XmlElement("dados-token")]
        public TokenData Data { get; set; }
    }
}