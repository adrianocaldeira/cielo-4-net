using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum TransactionResultStatus
    {
        /// <summary>
        ///     Transa��o Criada
        /// </summary>
        [XmlEnum("0")] Built = 0,

        /// <summary>
        ///     Transa��o em Andamento
        /// </summary>
        [XmlEnum("1")] InProgress = 1,

        /// <summary>
        ///     Transa��o Autenticada
        /// </summary>
        [XmlEnum("2")] Authenticated = 2,

        /// <summary>
        ///     Transa��o n�o Autenticada
        /// </summary>
        [XmlEnum("3")] NotAuthenticated = 3,

        /// <summary>
        ///     Transa��o Autorizada
        /// </summary>
        [XmlEnum("4")] Authorized = 4,

        /// <summary>
        ///     Transa��o n�o Autorizada
        /// </summary>
        [XmlEnum("5")] NotAuthorized = 5,

        /// <summary>
        ///     Transa��o Capturada
        /// </summary>
        [XmlEnum("6")] Captured = 6,

        /// <summary>
        ///     Transa��o Cancelada
        /// </summary>
        [XmlEnum("9")] Canceled = 9,

        /// <summary>
        ///     Transa��o em Autentica��o
        /// </summary>
        [XmlEnum("10")] InAuthentication = 10,

        /// <summary>
        ///     Transa��o em Cancelamento
        /// </summary>
        [XmlEnum("12")] InCancellation = 12
    }
}