Feature: RealizarCompra

Scenario: Realizar compra com sucesso
	Given Logar no site de compra
	When  Adicionar a mochila no carrinho
	When  Adicionar a camiseta no carrinho
	When  Clicar no carrinho
	When  Clicar em checkout
	When  Informar nome Maria 
	When  Informar sobrenome Machado
	When  Informar CEP 93245014
	When  Clicar em continuar
	When  Clicar em finish
	Then  Mensagem de sucesso