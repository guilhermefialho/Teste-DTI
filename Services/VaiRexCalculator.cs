using System;


namespace TesteDTI.Services{
public class VaiRexCalculator
{

    public decimal DistanceToCanil = 1.70m;
    public decimal CalculateCost(DateTime date, int numSmallDogs, int numLargeDogs)
    {
        bool isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday; // Verifica se a data fornecida é um fim de semana (sábado ou domingo).
        decimal costSmallDogs = isWeekend ? 20.00m * numSmallDogs : 15.00m * numSmallDogs;
        decimal costLargeDogs = isWeekend ? 55.00m * numLargeDogs : 50.00m * numLargeDogs;
        return costSmallDogs + costLargeDogs;
    }
}
}