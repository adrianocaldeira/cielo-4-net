using System;
using System.Xml.Serialization;

namespace Cielo
{
    /// <summary>
    /// C�digo do produto
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum PaymentMethodProduct
    {
        /// <summary>
        ///     Cr�dito � Vista
        /// </summary>
        [XmlEnum("1")] CreditOneParcel,

        /// <summary>
        ///     Parcelado loja
        /// </summary>
        [XmlEnum("2")] Installment,

        /// <summary>
        ///     D�bito
        /// </summary>
        [XmlEnum("A")] Debit
    }
}