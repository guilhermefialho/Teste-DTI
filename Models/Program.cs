using System;
using TesteDTI;

Console.Write("Entre com a data (dd/mm/yyyy): ");
string dataInput = Console.ReadLine();

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
    Console.Write("Quantidade de cães pequenos: ");
    int numSmallDogs = int.Parse(Console.ReadLine());
    Console.Write("Quantidade de cães grandes: ");
    int numLargeDogs = int.Parse(Console.ReadLine());

    MeuCaninoFelizCalculator meuCaninoFelizCalculator = new MeuCaninoFelizCalculator();
    VaiRexCalculator vaiRexCalculator = new VaiRexCalculator();
    ChowChawgasCalculator chowChawgasCalculator = new ChowChawgasCalculator();

    decimal menorCustoTotal = decimal.MaxValue;
    string melhorPetshop = "";

    // Meu Canino Feliz
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

    // Vai Rex
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

    // ChowChawgas
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

    Console.WriteLine(
        $"Melhor petshop para levar os cães em {data.ToShortDateString()}: {melhorPetshop} (Custo: R${menorCustoTotal:N2})"
    );
}
else
{
    Console.WriteLine("Data fornecida está em formato inválido.");
}
