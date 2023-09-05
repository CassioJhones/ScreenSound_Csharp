# ScreenSound
> programa em C# que permite registrar bandas, avaliar bandas, calcular a média das notas das bandas e mostrar as bandas registradas em um menu de console.

<img src="https://github.com/CassioJhones/ScreenSound_Csharp/assets/56178855/1b14c821-8e40-4793-af3b-09ca2b8dd18a" width="600px">

### Visão Geral
Aplicação de console em C# que permite gerenciar informações sobre bandas. Fornece as seguintes funcionalidades:

1. Registrar banda: Permite ao usuário registrar o nome de uma banda.
2. Mostrar todas as bandas: Exibe uma lista de todas as bandas registradas.
3. Avaliar banda: Permite ao usuário atribuir notas às bandas registradas.
4. Média das bandas: Calcula a média das notas atribuídas a uma banda específica.
5. Sair: Encerra o programa.


### Funções Principais

#### `ExibirOpcoesDoMenu()`
- Exibe o menu principal com as opções disponíveis.
- Solicita ao usuário que escolha uma opção.
- Redireciona para a função correspondente com base na escolha do usuário.

#### `MediaBandas()`
- Calcula a média das notas de uma banda especificada pelo usuário.
- Exibe a média das notas da banda.

#### `RegistrarBanda()`
- Permite ao usuário registrar o nome de uma banda.
- Adiciona a banda ao dicionário `bandasRegistradas`.

#### `MostrarBanda()`
- Exibe todas as bandas registradas no dicionário `bandasRegistradas`.

#### `AvaliarBanda()`
- Permite ao usuário atribuir uma nota a uma banda registrada.
- Adiciona a nota à lista de notas da banda.

### Estrutura de Dados
- `Dictionary<string, List<int>> bandasRegistradas`: Armazena as bandas registradas como chaves e suas notas como valores em uma lista.

