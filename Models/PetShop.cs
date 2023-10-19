using System;

namespace TesteDTI {
public class MeuCaninoFelizCalculator
{

    public decimal DistanceToCanil = 2m;
    public decimal CalculateCost(DateTime date, int numSmallDogs, int numLargeDogs)
    {
        bool isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        decimal costSmallDogs = isWeekend ? 20.00m * 1.2m * numSmallDogs : 20.00m * numSmallDogs;
        decimal costLargeDogs = isWeekend ? 40.00m * 1.2m * numLargeDogs : 40.00m * numLargeDogs;
        return costSmallDogs + costLargeDogs;
    }
}

public class VaiRexCalculator
{

    public decimal DistanceToCanil = 1.7m;
    public decimal CalculateCost(DateTime date, int numSmallDogs, int numLargeDogs)
    {
        bool isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        decimal costSmallDogs = isWeekend ? 20.00m * numSmallDogs : 15.00m * numSmallDogs;
        decimal costLargeDogs = isWeekend ? 55.00m * numLargeDogs : 50.00m * numLargeDogs;
        return costSmallDogs + costLargeDogs;
    }
}

public class ChowChawgasCalculator
{      

    public decimal DistanceToCanil = 0.8m;
    public decimal CalculateCost(int numSmallDogs, int numLargeDogs)
    {
        decimal costSmallDogs = 30.00m * numSmallDogs;
        decimal costLargeDogs = 45.00m * numLargeDogs;
        return costSmallDogs + costLargeDogs;
    }
}

}