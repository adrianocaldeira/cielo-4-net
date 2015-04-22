using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Autentica��o do resultado da autoriza��o.
    /// </summary>
    [XmlType]
    [Serializable]
    public class TransactionResultAuthentication
    {
        /// <summary>
        ///     �Recupera ou define c�digo do processamento.
        /// </summary>
        [XmlElement("codigo")]
        public string Code { get; set; }

        /// <summary>
        ///     Recupera ou define detalhe do processamento.
        /// </summary>
        [XmlElement("mensagem")]
        public string Message { get; set; }

        /// <summary>
        ///     Recupera ou define data e hora do processamento.
        /// </summary>
        [XmlElement("data-hora")]
        public DateTime Date { get; set; }

        /// <summary>
        ///     Recupera ou define valor do processamento sem pontua��o. Os dois �ltimos d�gitos s�o os centavos.
        /// </summary>
        [XmlElement("valor")]
        public int Amount { get; set; }

        /// <summary>
        ///     Recupera ou define ECI(Eletronic Commerce Indicator) representa o qu�o segura � uma transa��o.
        /// </summary>
        [XmlElement("eci")]
        public int Eci { get; set; }
    }
}