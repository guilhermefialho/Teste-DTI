using System;


namespace TesteDTI.Services {
public class ChowChawgasCalculator
{      

    public decimal DistanceToCanil = 0.80m;
    public decimal CalculateCost(int numSmallDogs, int numLargeDogs)
    {
        decimal costSmallDogs = 30.00m * numSmallDogs;
        decimal costLargeDogs = 45.00m * numLargeDogs;
        return costSmallDogs + costLargeDogs;
    }
}

}