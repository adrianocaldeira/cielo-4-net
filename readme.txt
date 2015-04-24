###################################################################
Biblioteca de integra��o com a solu��o WebService da Cielo em .Net.
###################################################################

===================================================================
Configura��o
===================================================================

Ap�s a instala��o � necess�rio configurar o arquivo(app.config ou web.config) de configura��o da sua aplica��o com os dados de filia��o, chave de acesso e ambiente da Cielo, conforme exemplo abaixo:

<configSections>
	<section name="cielo" type="Cielo4Net.ConfigurationSection, Cielo4Net" />
</configSections>

<!--AMBIENTE DE TESTE DA CIELO-->
<cielo number="N�MERO FILIA��O CIELO" key="CHAVE DE ACESSO AO WEBSERVICE DA CIELO" environment="test"/>

<!--AMBIENTE DE PRODU��O DA CIELO-->
<cielo number="N�MERO FILIA��O CIELO" key="CHAVE DE ACESSO AO WEBSERVICE DA CIELO" environment="production"/>

===================================================================
Logs de Comunica��o
===================================================================

Para visualizar o processo de comunica��o de envio e retorno no Output do Visual Studio � necess�rio efetuar a configura��o abaixo:

<configSections>
	<section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler,log4net" />
</configSections>

<log4net>
	<appender name="Trace" type="log4net.Appender.TraceAppender">
		<layout type="log4net.Layout.PatternLayout">
			<conversionPattern value="%-5level %logger - %message %newline" />
		</layout>
	</appender>
	<logger name="Cielo4Net">
		<level value="DEBUG" />
		<appender-ref ref="Trace" />
	</logger>
</log4net>
