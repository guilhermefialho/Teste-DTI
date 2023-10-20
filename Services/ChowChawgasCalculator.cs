using System;


namespace TesteDTI.Services {
public class ChowChawgas : IPetshopCalculator
{      

    public decimal DistanceToCanil { get; } = 0.80m;
     public decimal CalculateCost(DateTime date, int numSmallDogs, int numLargeDogs)
    {
        decimal costSmallDogs = 30.00m * numSmallDogs;
        decimal costLargeDogs = 45.00m * numLargeDogs;
        return costSmallDogs + costLargeDogs;
    }
}

}