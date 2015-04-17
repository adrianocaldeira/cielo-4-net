using System;
using System.Xml.Serialization;

namespace Cielo
{
    /// <summary>
    ///     Indicador de autoriza��o:
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum TransactionAuthorizationType
    {
        /// <summary>
        ///     N�o autorizar (somente autenticar)
        /// </summary>
        [XmlEnum("0")] NotAuthorize,

        /// <summary>
        ///     Autorizar somente se autenticada
        /// </summary>
        [XmlEnum("1")] AuthorizeOnlyIfAuthenticated,

        /// <summary>
        ///     Autorizar autenticada e n�o autenticada
        /// </summary>
        [XmlEnum("2")] AllowAuthenticatedAndUnauthenticated,

        /// <summary>
        ///     Autorizar sem passar por autentica��o (somente para cr�dito) � tamb�m conhecida como �Autoriza��o Direta�. Obs.:
        ///     Para Diners, Discover, Elo, Amex, Aura e JCB o valor ser� sempre �3�, pois estas bandeiras n�o possuem programa de
        ///     autentica��o.
        /// </summary>
        [XmlEnum("3")] AuthorizeWithoutGoingThroughAuthentication = 4,

        /// <summary>
        ///     Transa��o Recorrente
        /// </summary>
        [XmlEnum("4")] RecurringTransaction
    }
}