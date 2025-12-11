# AT CSharp 2025  
Trabalho DR2 – Desenvolvimento em C#

Nome: Fernando Padilha Fogaça  
Repositório: https://github.com/FernandoFogaca/AT_CSharp2025

Este repositório contém todos os exercícios do AT, divididos em classes separadas, cada uma com um método `Testar()` para facilitar a execução.  
Abaixo deixei um resumo simples do que fiz em cada exercício.

---

## ✔ Exercício 1 – Primeiro Programa
Só imprimi o meu nome e minha data de nascimento. Serve para testar se o ambiente estava a funcionar certinho.  

---

## ✔ Exercício 2 – Cifrador de Nome
Li o nome completo e desloquei cada letra duas posições no alfabeto.  
Ignorei espaços e só usei manipulação simples de `char` e `string`.

---

## ✔ Exercício 3 – Calculadora
Pedi dois números e deixei o usuário escolher a operação (1 a 4).  
Validei entradas e tratei divisão por zero.  
Mostra o resultado no final.

---

## ✔ Exercício 4 – Próximo Aniversário
Pego a data de nascimento e calculo quantos dias faltam para o próximo aniversário usando `DateTime`.  
Se faltar menos de 7 dias, aparece uma mensagem extra.

---

## ✔ Exercício 5 – Tempo até a Formatura
Leio a data atual, comparo com a data de formatura definida no código e calculo anos, meses e dias restantes.  
Mostro mensagem especial quando tiver menos de 6 meses.

---

## ✔ Exercício 6 – Classe Aluno
Criei a classe `Student` com nome, matrícula, curso e média.  
Mostro os dados e digo se está aprovado (média ≥ 7).

---

## ✔ Exercício 7 – Banco Digital (Encapsulamento)
Criei a classe `BankAccount` com saldo privado.  
Só dá para mexer no saldo usando `Deposit`, `Withdraw` e `ShowBalance`.  
Validação simples para impedir valores inválidos.

---

## ✔ Exercício 8 – Funcionários (Herança)
Classe `Employee` para funcionário normal e `Manager` como derivada.  
Manager recebe 20% de bônus no salário.  
Mostro o salário dos dois.

---

## ✔ Exercício 9 – Controle de Estoque (Arrays)
Menu simples com até 5 itens.  
Cada item tem nome, quantidade e preço.  
Uso um array para armazenar e listar os produtos.  
Tudo feito no estilo básico que um aluno faria.

---

## ✔ Exercício 10 – Jogo de Adivinhação
O programa escolhe um número de 1 a 50.  
O usuário tem 5 tentativas.  
Validação de número fora do intervalo.

---

## ✔ Exercício 11 – Contatos com Arquivo
Guardo contatos em `contatos.txt`.  
Posso adicionar e listar.  
Faço leitura linha por linha e mostro num formato simples.

---

## ✔ Exercício 12 – Contatos com Polimorfismo
Uso herança para diferentes formas de mostrar os contatos:  
- Markdown  
- Tabela  
- Texto simples  
