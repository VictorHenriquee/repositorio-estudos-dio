# Projetos - DIO

Bem-vindo ao reposit�rio de projetos desenvolvidos para os desafios da DIO! Aqui voc� encontrar� tr�s projetos diferentes: um sistema de hotel, um sistema de controle escolar e um aplicativo de aprendizado de idiomas.

## Desafio 1: Sistema de Hotel :white_check_mark:

Um sistema que gerencia reservas de quartos em um hotel, permitindo realizar reservas, check-out e visualizar reservas existentes.

### Funcionalidades

- **Realizar Reserva**: Escolher uma su�te dispon�vel e cadastrar os h�spedes.
- **Realizar Check-Out**: Finalizar a estadia de um h�spede e calcular o valor total da reserva.
- **Mostrar Reservas**: Listar todas as reservas feitas.
- **Sair**: Encerrar o sistema.

### Estrutura do Projeto

- `Program.cs`: Ponto de entrada da aplica��o, gerencia o menu e as intera��es com o usu�rio.
- `Hotel.cs`: Classe principal que cont�m a l�gica para gerenciar reservas e su�tes dispon�veis.
- `Reserva.cs`: Representa uma reserva de h�spede, incluindo informa��es sobre h�spedes, dias reservados e a su�te escolhida.
- `Suite.cs`: Representa uma su�te dispon�vel no hotel, com informa��es como tipo, capacidade e valor da di�ria.
- `Pessoa.cs`: Representa uma pessoa (h�spede), incluindo nome e sobrenome.
- `OpcoesMenu.cs`: Gerencia as op��es do menu e as intera��es correspondentes.

## Desafio 2: Sistema de Estacionamento :white_check_mark:

Um sistema que gerencia o estacionamento de ve�culos, permitindo registrar entradas e sa�das, calcular o valor da estadia e listar ve�culos estacionados.

### Funcionalidades

- **Registrar Entrada**: Adicionar um ve�culo ao estacionamento com informa��es como placa e hora de entrada.
- **Registrar Sa�da**: Remover um ve�culo do estacionamento e calcular o valor da estadia com base no tempo de perman�ncia.
- **Listar Ve�culos Estacionados**: Mostrar todos os ve�culos atualmente no estacionamento, incluindo detalhes como placa e hora de entrada.
- **Calcular Valor da Estadia**: Determinar o valor a ser cobrado com base no tempo que o ve�culo ficou estacionado.

### Estrutura do Projeto

- `Program.cs`: Ponto de entrada da aplica��o, que controla o menu e a intera��o com o usu�rio.
- `Veiculo.cs`: Classe que representa um ve�culo, contendo informa��es como placa e hora de entrada.
- `Estacionamento.cs`: Classe que gerencia a l�gica do estacionamento, incluindo a lista de ve�culos e o c�lculo de valores.
- `Menu.cs`: Gerencia as op��es do menu e as intera��es correspondentes.

## Desafio 3: Exerc�cios de Certifica��o :white_check_mark:

Este reposit�rio cont�m uma s�rie de exerc�cios desenvolvidos como parte do programa de certifica��o da DIO (Digital Innovation One). O objetivo principal � praticar e consolidar conceitos de Programa��o Orientada a Objetos (POO) utilizando a linguagem C#. 

### Objetivos do Desafio

- **Praticar POO**: Atrav�s de diferentes exerc�cios, o desafio proporciona a oportunidade de aplicar conceitos fundamentais de POO, como encapsulamento, heran�a e polimorfismo.
  
- **Desenvolvimento de L�gica de Programa��o**: Cada exerc�cio foi projetado para aprimorar a l�gica de programa��o do desenvolvedor, incentivando o racioc�nio l�gico e a resolu��o de problemas.

- **Valida��o de Dados**: Muitos exerc�cios incluem a valida��o de entradas do usu�rio, refor�ando a import�ncia da manipula��o e verifica��o de dados em aplica��es.

- **Estrutura��o de C�digo**: Os exerc�cios demonstram a organiza��o e a estrutura��o do c�digo em classes e m�todos, o que � essencial para o desenvolvimento de software sustent�vel e escal�vel.

### Estrutura do Reposit�rio

O reposit�rio est� organizado em subpastas, cada uma representando um exerc�cio espec�fico. Cada subpasta cont�m:

- **Classe Principal**: O c�digo que implementa a l�gica do exerc�cio.
- **Coment�rios**: Explica��es em cada arquivo que ajudam a entender o funcionamento do c�digo.

## Desafio 4: Sistema de Smartphone :white_check_mark:

Este reposit�rio cont�m um sistema de gerenciamento de smartphones, desenvolvido para praticar conceitos de Programa��o Orientada a Objetos (POO) em C#.

### Objetivos

- **Gerenciar Smartphones**: Permitir funcionalidades como ligar, receber chamadas e instalar aplicativos.
- **Praticar POO**: Aplicar heran�a e polimorfismo usando uma classe base (`Smartphone`) e classes derivadas (`Nokia` e `Iphone`).

### Estrutura do Reposit�rio

- **Classe `Smartphone`**: Classe abstrata com m�todos e propriedades comuns.
- **Classe `Nokia`**: Implementa o m�todo `InstalarAplicativo` espec�fico para Nokia.
- **Classe `Iphone`**: Implementa o m�todo `InstalarAplicativo` espec�fico para iPhone.
- **Classe `Program`**: Ponto de entrada, onde os smartphones s�o instanciados e seus m�todos s�o chamados.
