using System;

// Interface para os calculadores de custo do petshop.
public interface IPetshopCalculator
{
    decimal CalculateCost(DateTime date, int numSmallDogs, int numLargeDogs);
    decimal DistanceToCanil { get; }
}
