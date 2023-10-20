# Teste referente à vaga Estágio em Desenvolvimento de Software – DTI Digital

## Premissas assumidas:

- Os preços fornecidos nas instruções do problema estão corretos e não há necessidade de ajustes adicionais nos valores.
- O usuário fornecerá a data no formato "dd/mm/yyyy".
- Não haverá necessidade de tratamento de erros para situações excepcionais, como datas inválidas, valores negativos ou outras condições fora do escopo do problema.

## Decisões de projeto:

- Foi utilizado a classe “DateTime” para lidar com datas, o que torna o código mais preciso e legível.
- Ocorreu a implementação de funções separadas para calcular os custos em cada petshop, o que torna o código mais organizado e facilita a manutenção.
- Como critério de desempate em caso de mesmo valor de preço, as distâncias fornecidas nas instruções do problema foram consideradas.
- A decisão de escolher o melhor petshop é baseada no custo total, levando em consideração o custo dos banhos e a proximidade do canil, conforme as instruções.

## Instruções para executar o sistema:

1. Execute o programa C# em um ambiente que suporte a linguagem, como o Visual Studio ou o Visual Studio Code. É importante se certificar que seja o Visual Studio 2022 versão 17.0 ou superior.
2. Certifique-se de ter a plataforma .NET instalada e configurada em seu ambiente para executar o programa. Além disso, é importante que a SDK utilizada seja a versão 6.0 mais recente, para garantir que você tenha acesso às funcionalidades.

3. Execução do Programa:

- Abra um terminal no VS Code.
- Navegue até o diretório onde o projeto C# está localizado.
- Utilize o comando `dotnet run` para iniciar a execução do programa C#. Isso iniciará a interação com o programa no terminal.

4. O programa solicitará a entrada de dados na seguinte ordem:
   - Data no formato "dd/mm/yyyy" (por exemplo, "03/08/2018").
   - Quantidade de cães pequenos.
   - Quantidade de cães grandes.

5. Certifique-se de fornecer a data no formato correto, conforme as instruções.
6. O programa calculará o melhor petshop com base nas informações fornecidas e exibirá o nome do petshop e o custo total.
7. Os custos são calculados de acordo com as regras estabelecidas nas instruções do problema, considerando o dia da semana e a distância para cada petshop.
8. Este sistema calculará automaticamente o melhor petshop com base na data, na quantidade de cães e nos critérios de custo e proximidade, fornecendo o resultado no final da execução.

9. Para executar os testes unitários, você pode usar o NUnit Runner. No terminal, navegue até a pasta raiz do projeto, onde o arquivo de teste está localizado. Use o comando `dotnet test` para executar os testes.
