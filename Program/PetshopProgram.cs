using System;
using TesteDTI.Services;

// Solicita a entrada da data no formato "dd/mm/yyyy" e armazena-a em 'dataInput'.
Console.Write("Entre com a data (dd/mm/yyyy): ");
string dataInput = Console.ReadLine();

// Tenta analisar a 'dataInput' como uma data no formato "dd/mm/yyyy".
if (
    DateTime.TryParseExact(
        dataInput,
        "dd/MM/yyyy",
        null,
        System.Globalization.DateTimeStyles.None,
        out DateTime data
    )
)
{
    // Solicita a quantidade de cães pequenos.
    Console.Write("Quantidade de cães pequenos: ");
    int numSmallDogs = int.Parse(Console.ReadLine());

    // Solicita a quantidade de cães grandes.
    Console.Write("Quantidade de cães grandes: ");
    int numLargeDogs = int.Parse(Console.ReadLine());

    // Cria um array de calculadores de custo de petshop (interface IPetshopCalculator).
    IPetshopCalculator[] petshops = new IPetshopCalculator[]
    {
        new MeuCaninoFeliz(),
        new VaiRex(),
        new ChowChawgas()
    };

    // Inicializa variáveis para rastrear o menor custo total e o melhor petshop.
    decimal menorCustoTotal = decimal.MaxValue;
    string melhorPetshop = "";

    // Itera sobre os petshops para calcular e comparar custos.
    foreach (var petshop in petshops)
    {
        // Calcula o custo do petshop atual.
        decimal custoPetshop = petshop.CalculateCost(data, numSmallDogs, numLargeDogs);

        // Compara o custo atual com o menor custo registrado.
        if (custoPetshop < menorCustoTotal || (custoPetshop == menorCustoTotal && petshop.DistanceToCanil < petshops[0].DistanceToCanil))
        {
            // Atualiza o menor custo total e o nome do melhor petshop.
            menorCustoTotal = custoPetshop;
            melhorPetshop = petshop.GetType().Name;
        }
    }

    // Exibe o resultado com o petshop de menor custo total.
    Console.WriteLine(
        $"Melhor petshop para levar os cães em {data.ToShortDateString()}: {melhorPetshop} (Custo: R${menorCustoTotal:N2})"
    );
}
else
{
    // Caso a data fornecida esteja em formato inválido, exibe uma mensagem de erro.
    Console.WriteLine("Data fornecida está em formato inválido.");
}
