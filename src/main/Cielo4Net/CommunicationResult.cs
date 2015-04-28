using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Retorno de comunica��o com a Cielo.
    /// </summary>
    public class CommunicationResult
    {
        /// <summary>
        ///     Recupera ou define <see cref="ErrorResult" />.
        /// </summary>
        public ErrorResult Error { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TransactionResult" />.
        /// </summary>
        public TransactionResult Transaction { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TokenResult" />.
        /// </summary>
        public TokenResult Token { get; set; }
        
        /// <summary>
        ///     Recupera ou define XML enviado.
        /// </summary>
        [XmlIgnore]
        public string SentXml { get; set; }

        /// <summary>
        /// Recupera ou define XML retornado.
        /// </summary>
        [XmlIgnore]
        public string ReceivedXml { get; set; }

        /// <summary>
        ///     � um erro.
        /// </summary>
        public bool IsError
        {
            get { return Error != null; }
        }

        /// <summary>
        ///     � uma transa��o.
        /// </summary>
        public bool IsTransaction
        {
            get { return Transaction != null; }
        }

        /// <summary>
        ///     � um token.
        /// </summary>
        public bool IsToken
        {
            get { return Token != null; }
        }
    }
}