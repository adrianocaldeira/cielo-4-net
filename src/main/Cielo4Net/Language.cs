using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Idioma do pedido: PT (portugu�s), EN (ingl�s) ou ES (espanhol). Com base nessa informa��o � definida a l�ngua a ser
    ///     utilizada nas telas da Cielo. Caso n�o seja enviado, o sistema assumir� �PT�.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum Language
    {
        /// <summary>
        ///     Portugu�s
        /// </summary>
        [XmlEnum("PT")] Portuguese,

        /// <summary>
        ///     Ingl�s
        /// </summary>
        [XmlEnum("EN")] English,

        /// <summary>
        ///     Espanhol
        /// </summary>
        [XmlEnum("ES")] Spanish
    }
}