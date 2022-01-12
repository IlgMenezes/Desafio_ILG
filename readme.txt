*Considerações iniciais
	O programa está rodando.
	Grande parte do código está documentado, mas o tempo foi apertando.
	
	
* Decisão da arquitetura principal.
	Procurei usar MVC, resolvi fazer em Xamarin porque é a plataforma utilizada e tive contato apenas na Pós graduação. 
	Devido à vontade de entregar o projeto rodando, não ficou nem exatamente MVC nem MVVM.
	Criei um model para atender às telas (City.cs) essa classe tem todas as informações que todas as telas precisam.
	Essa classe também foi usada para persistir os dados.
	As demais classes da pasta Model foram criadas apenas para interpretação dos JSONs remoto e local. 
	Tenho ciência que preciso readequar um pouco mais a nomenclatura e a divisão.
	Também foi criada apenas uma classe controladora para o tratamento das requisições das Views.
	Gostaria de chamar a atenção para o método “RefreshWeatherData”. 
	Pensei que, ao recuperar as cidades do banco, seria importante verificar se os dados não estão demasiadamente obsoletos. 
	Utilizei um parâmetro que ficou na classe Constants.
	As classes de Serviço foram criadas para as conexões Rest e conversões de Json.
	A conexão com o banco acabou ficando no App.xaml mesmo. Tenho ciência que há outras formas mais elegantes para garantir o padrão Singleton.

* Lista das bibliotecas de terceiros utilizadas, e o por quê do uso de cada um.
	Newtonsoft.Json Para converter Json em objetos.
	sqlite-net-pcl para conexão com banco, nem sei se essa seria mesmo de terceiro.


* O que poderia melhorar dentro do seu código se tivesse mais tempo.
	Readequação para padrões de projeto, partir as camadas em DLLs diferentes, conferir os encapsulamentos, tratamento de erros, Padronização das mensagens...
	Nuss muita coisa!


* Mencionar os pontos que não foram possíveis de entregar, e a justificativa de não
ter sido entregue.

	O App está rodando com as funcionalidades exigidas. Não foram desenvolvidos testes automatizados, nem unitários, testei só o caminho feliz.
