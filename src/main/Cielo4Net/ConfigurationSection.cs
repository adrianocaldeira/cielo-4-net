using System.Configuration;

namespace Cielo4Net
{
    /// <summary>
    ///     Se��o de configura��o.
    /// </summary>
    public class ConfigurationSection : System.Configuration.ConfigurationSection
    {
        /// <summary>
        ///     Recupera ou define N�mero de afilia��o da loja com a Cielo.
        /// </summary>
        [ConfigurationProperty("number", IsRequired = true)]
        public string Number
        {
            get { return (string) base["number"]; }
            set { base["number"] = value; }
        }

        /// <summary>
        ///     Recupera ou define Chave de acesso da loja atribu�da pela Cielo.
        /// </summary>
        [ConfigurationProperty("key", IsRequired = true)]
        public string Key
        {
            get { return (string) base["key"]; }
            set { base["key"] = value; }
        }

        /// <summary>
        ///     Recupera ou define ambiente.
        /// </summary>
        [ConfigurationProperty("environment", IsRequired = true)]
        public string Environment
        {
            get { return (string) base["environment"]; }
            set { base["environment"] = value; }
        }
    }
}