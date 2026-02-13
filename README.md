# Sistema de Cadastro de Jogadores
Este é um projeto simples de Windows Forms desenvolvido em C# (.NET 8.0) para gerir o cadastro de jogadores e as suas informações de jogo, utilizando uma base de dados MySQL.

## 🚀 Funcionalidades
* **Cadastro de Jogadores**: Permite inserir o nome, idade, género e nacionalidade do jogador.
* **Registo de Jogos**: Vincula um jogo ao jogador, incluindo plataforma, tempo de jogo e uma nota de avaliação.
* **Visualização**: Lista os jogadores e jogos registados através de uma integração com um componente de grelha de dados (`DataGridView`).
* **Persistência de Dados**: Utiliza transações SQL para garantir que os dados do jogador e do jogo são gravados corretamente em tabelas relacionadas.

## 🛠️ Tecnologias Utilizadas
* **Linguagem**: C#.
* **Framework**: .NET 8.0 Windows Forms.
* **Base de Dados**: MySQL.
* **Biblioteca**: `MySql.Data.dll` para comunicação com a base de dados.

## 🗄️ Estrutura da Base de Dados
O projeto assume a existência de uma base de dados chamada `uc12` no `localhost` com as seguintes tabelas:
1. **Jogos**: Armazena as colunas `Nome`, `Plataforma`, `Tempo` e `Nota`.
2. **Jogador**: Armazena as colunas `Nome`, `Idade`, `Genero`, `Nacionalidade` e uma chave estrangeira `JogosId` para a tabela de Jogos.

## ⚙️ Configuração
Para que o projeto funcione, a string de conexão no ficheiro `BancoDeDados.cs` deve estar configurada corretamente para o seu ambiente local:
```csharp
const string connectionString = "Server=localhost;Database=uc12;Uid=root;";
