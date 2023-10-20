using System;

namespace TesteDTI.Services {
public class MeuCaninoFeliz : IPetshopCalculator
{

    public decimal DistanceToCanil { get; } = 2.00m;
    public decimal CalculateCost(DateTime date, int numSmallDogs, int numLargeDogs)
    {
        bool isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday; // Verifica se a data fornecida é um fim de semana (sábado ou domingo).
        decimal costSmallDogs = isWeekend ? 20.00m * 1.2m * numSmallDogs : 20.00m * numSmallDogs;
        decimal costLargeDogs = isWeekend ? 40.00m * 1.2m * numLargeDogs : 40.00m * numLargeDogs;
        return costSmallDogs + costLargeDogs;
    }
}


}