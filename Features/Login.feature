Feature: RealizarLogin

Scenario: Realizar login com sucesso
	Given Estar na pagina de login
	When  Digitar usuario standard_user
	When  Digitar senha secret_sauce
	When  Clicar em Login
	Then  Procura titulo da pagina

