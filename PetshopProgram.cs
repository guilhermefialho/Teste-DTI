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

    // Instância dos calculadores de custo para cada petshop.
    MeuCaninoFelizCalculator meuCaninoFelizCalculator = new MeuCaninoFelizCalculator();
    VaiRexCalculator vaiRexCalculator = new VaiRexCalculator();
    ChowChawgasCalculator chowChawgasCalculator = new ChowChawgasCalculator();

    // Inicialização de variáveis para rastrear o menor custo total e o melhor petshop.
    decimal menorCustoTotal = decimal.MaxValue;
    string melhorPetshop = "";

    // Cálculo e comparação de custos com o petshop "Meu Canino Feliz".
    decimal custoMeuCaninoFeliz = meuCaninoFelizCalculator.CalculateCost(
        data,
        numSmallDogs,
        numLargeDogs
    );
    if (
        custoMeuCaninoFeliz < menorCustoTotal
        || (
            custoMeuCaninoFeliz == menorCustoTotal
            && meuCaninoFelizCalculator.DistanceToCanil > vaiRexCalculator.DistanceToCanil
            && meuCaninoFelizCalculator.DistanceToCanil > chowChawgasCalculator.DistanceToCanil
        )
    )
    {
        menorCustoTotal = custoMeuCaninoFeliz;
        melhorPetshop = "Meu Canino Feliz";
    }

    // Cálculo e comparação de custos com o petshop "Vai Rex".
    decimal custoVaiRex = vaiRexCalculator.CalculateCost(data, numSmallDogs, numLargeDogs);
    if (
        custoVaiRex < menorCustoTotal
        || (
            custoVaiRex == menorCustoTotal
            && vaiRexCalculator.DistanceToCanil < meuCaninoFelizCalculator.DistanceToCanil
            && vaiRexCalculator.DistanceToCanil > chowChawgasCalculator.DistanceToCanil
        )
    )
    {
        menorCustoTotal = custoVaiRex;
        melhorPetshop = "Vai Rex";
    }

    // Cálculo e comparação de custos com o petshop "ChowChawgas".
    decimal custoChowChawgas = chowChawgasCalculator.CalculateCost(numSmallDogs, numLargeDogs);
    if (
        custoChowChawgas < menorCustoTotal
        || (
            custoChowChawgas == menorCustoTotal
            && chowChawgasCalculator.DistanceToCanil < meuCaninoFelizCalculator.DistanceToCanil
            && chowChawgasCalculator.DistanceToCanil < vaiRexCalculator.DistanceToCanil
        )
    )
    {
        menorCustoTotal = custoChowChawgas;
        melhorPetshop = "ChowChawgas";
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
