using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Resultado da autoriza��o da transa��o.
    /// </summary>
    [XmlType]
    [Serializable]
    public class TransactionResultAuthorization
    {
        /// <summary>
        ///     Recupera ou define c�digo.
        /// </summary>
        [XmlElement("codigo")]
        public string Code { get; set; }

        /// <summary>
        ///     Recupera ou define mensagem.
        /// </summary>
        [XmlElement("mensagem")]
        public string Message { get; set; }

        /// <summary>
        ///     Recupera ou define data e hora.
        /// </summary>
        [XmlElement("data-hora")]
        public DateTime Date { get; set; }

        /// <summary>
        ///     Recupera ou define valor.
        /// </summary>
        [XmlElement("valor")]
        public int Amount { get; set; }

        /// <summary>
        ///     Recupera ou define LR(Resposta da Autoriza��o).
        /// </summary>
        [XmlElement("lr")]
        public int Lr { get; set; }

        /// <summary>
        ///     Recupera ou define NSU.
        /// </summary>
        [XmlElement("nsu")]
        public int Nsu { get; set; }
    }
}