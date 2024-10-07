# Projetos - DIO

Bem-vindo ao repositório de projetos desenvolvidos para os desafios da DIO! Aqui você encontrará três projetos diferentes: um sistema de hotel, um sistema de controle escolar e um aplicativo de aprendizado de idiomas.

## Desafio 1: Sistema de Hotel :white_check_mark:

Um sistema que gerencia reservas de quartos em um hotel, permitindo realizar reservas, check-out e visualizar reservas existentes.

### Funcionalidades

- **Realizar Reserva**: Escolher uma suíte disponível e cadastrar os hóspedes.
- **Realizar Check-Out**: Finalizar a estadia de um hóspede e calcular o valor total da reserva.
- **Mostrar Reservas**: Listar todas as reservas feitas.
- **Sair**: Encerrar o sistema.

### Estrutura do Projeto

- `Program.cs`: Ponto de entrada da aplicação, gerencia o menu e as interações com o usuário.
- `Hotel.cs`: Classe principal que contém a lógica para gerenciar reservas e suítes disponíveis.
- `Reserva.cs`: Representa uma reserva de hóspede, incluindo informações sobre hóspedes, dias reservados e a suíte escolhida.
- `Suite.cs`: Representa uma suíte disponível no hotel, com informações como tipo, capacidade e valor da diária.
- `Pessoa.cs`: Representa uma pessoa (hóspede), incluindo nome e sobrenome.
- `OpcoesMenu.cs`: Gerencia as opções do menu e as interações correspondentes.

## Desafio 2: Sistema de Estacionamento :white_check_mark:

Um sistema que gerencia o estacionamento de veículos, permitindo registrar entradas e saídas, calcular o valor da estadia e listar veículos estacionados.

### Funcionalidades

- **Registrar Entrada**: Adicionar um veículo ao estacionamento com informações como placa e hora de entrada.
- **Registrar Saída**: Remover um veículo do estacionamento e calcular o valor da estadia com base no tempo de permanência.
- **Listar Veículos Estacionados**: Mostrar todos os veículos atualmente no estacionamento, incluindo detalhes como placa e hora de entrada.
- **Calcular Valor da Estadia**: Determinar o valor a ser cobrado com base no tempo que o veículo ficou estacionado.

### Estrutura do Projeto

- `Program.cs`: Ponto de entrada da aplicação, que controla o menu e a interação com o usuário.
- `Veiculo.cs`: Classe que representa um veículo, contendo informações como placa e hora de entrada.
- `Estacionamento.cs`: Classe que gerencia a lógica do estacionamento, incluindo a lista de veículos e o cálculo de valores.
- `Menu.cs`: Gerencia as opções do menu e as interações correspondentes.

## Desafio 3: Exercícios de Certificação :white_check_mark:

Este repositório contém uma série de exercícios desenvolvidos como parte do programa de certificação da DIO (Digital Innovation One). O objetivo principal é praticar e consolidar conceitos de Programação Orientada a Objetos (POO) utilizando a linguagem C#. 

### Objetivos do Desafio

- **Praticar POO**: Através de diferentes exercícios, o desafio proporciona a oportunidade de aplicar conceitos fundamentais de POO, como encapsulamento, herança e polimorfismo.
  
- **Desenvolvimento de Lógica de Programação**: Cada exercício foi projetado para aprimorar a lógica de programação do desenvolvedor, incentivando o raciocínio lógico e a resolução de problemas.

- **Validação de Dados**: Muitos exercícios incluem a validação de entradas do usuário, reforçando a importância da manipulação e verificação de dados em aplicações.

- **Estruturação de Código**: Os exercícios demonstram a organização e a estruturação do código em classes e métodos, o que é essencial para o desenvolvimento de software sustentável e escalável.

### Estrutura do Repositório

O repositório está organizado em subpastas, cada uma representando um exercício específico. Cada subpasta contém:

- **Classe Principal**: O código que implementa a lógica do exercício.
- **Comentários**: Explicações em cada arquivo que ajudam a entender o funcionamento do código.

## Desafio 4: Sistema de Smartphone :white_check_mark:

Este repositório contém um sistema de gerenciamento de smartphones, desenvolvido para praticar conceitos de Programação Orientada a Objetos (POO) em C#.

### Objetivos

- **Gerenciar Smartphones**: Permitir funcionalidades como ligar, receber chamadas e instalar aplicativos.
- **Praticar POO**: Aplicar herança e polimorfismo usando uma classe base (`Smartphone`) e classes derivadas (`Nokia` e `Iphone`).

### Estrutura do Repositório

- **Classe `Smartphone`**: Classe abstrata com métodos e propriedades comuns.
- **Classe `Nokia`**: Implementa o método `InstalarAplicativo` específico para Nokia.
- **Classe `Iphone`**: Implementa o método `InstalarAplicativo` específico para iPhone.
- **Classe `Program`**: Ponto de entrada, onde os smartphones são instanciados e seus métodos são chamados.
