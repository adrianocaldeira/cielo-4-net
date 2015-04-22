using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Transa��o com a Cielo
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-transacao", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class Transaction : Message
    {
        /// <summary>
        ///     Inicializa uma nova inst�ncia da classe <see cref="Transaction" />. Na inicializa��o a propriedade Authentication
        ///     � automaticamente inst�nciada, o tipo da autoriza��o � definida como "Autorizar autenticada e n�o autenticada" e a
        ///     propriedade Capture definia como true.
        /// </summary>
        public Transaction()
        {
            Authentication = new Authentication();
            AuthorizationType = TransactionAuthorizationType.AllowAuthenticatedAndUnauthenticated;
            Capture = true;
        }

        /// <summary>
        ///     Recupera ou define <see cref="Authentication" />.
        /// </summary>
        [XmlElement("dados-ec")]
        public Authentication Authentication { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="Card" />.
        /// </summary>
        [XmlElement("dados-portador")]
        public Card Card { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="Order" />.
        /// </summary>
        [XmlElement("dados-pedido")]
        public Order Order { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="PaymentMethod" />.
        /// </summary>
        [XmlElement("forma-pagamento")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        ///     Recupera ou define URL da p�gina de retorno. � para essa p�gina que a Cielo vai direcionar o browser ao fim da
        ///     autentica��o ou da autoriza��o. N�o � obrigat�rio apenas para autoriza��o direta, por�m o campo dever ser inserido
        ///     como nulo ou vazio.
        /// </summary>
        [XmlElement("url-retorno")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Recupera ou define <see cref="TransactionAuthorizationType"/>.
        /// </summary>
        [XmlElement("autorizar")]
        public TransactionAuthorizationType AuthorizationType { get; set; }

        /// <summary>
        /// Recupera ou define se a transa��o ser� automaticamente capturada caso seja autorizada.
        /// </summary>
        [XmlElement("capturar")]
        public bool Capture { get; set; }

        /// <summary>
        /// Recupera ou define campo livre dispon�vel para o Estabelecimento.
        /// </summary>
        [XmlElement("campo-livre")]
        public string FreeField { get; set; }

        /// <summary>
        /// Recupera ou define seis primeiros n�meros do cart�o.
        /// </summary>
        [XmlElement("bin")]
        public int? Bin { get; set; }

        /// <summary>
        /// Recupera ou define se a transa��o atual deve gerar um token associado ao cart�o.
        /// </summary>
        [XmlElement("gerar-token")]
        public bool? GenerateToken { get; set; }

        /// <summary>
        /// Recupera ou define Ctring contendo um bloco XML, encapsulado, contendo as informa��es necess�rias para realizar a consulta ao servi�o.
        /// </summary>
        [XmlText]
        [XmlElement("avs")]
        public string Avs { get; set; }

        /// <summary>
        /// Deve serializar propriedade FreeField.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeFreeField()
        {
            return !string.IsNullOrWhiteSpace(FreeField);
        }

        /// <summary>
        /// Deve serializar propriedade Bin.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeBin()
        {
            return Bin != null;
        }

        /// <summary>
        /// Deve serializar propriedade GenerateToken.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeGenerateToken()
        {
            return GenerateToken != null;
        }

        /// <summary>
        /// Deve serializar propriedade Avs.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeAvs()
        {
            return !string.IsNullOrWhiteSpace(Avs);
        }
    }
}