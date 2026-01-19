using System;

public interface IBillable
{
    int CostForDay(int hours);
}

public class FullTimeEmployee : IBillable
{
    private const int DailyRate = 20000;

    public int CostForDay(int hours)
    {
        return DailyRate;
    }
}

public class ContractEmployee : IBillable
{
    private const int HourlyRate = 3000;

    public int CostForDay(int hours)
    {
        return hours * HourlyRate;
    }
}

public class BillingCalculator
{
    public int CalculateCost(IBillable employee, int hours)
    {
        return employee.CostForDay(hours);
    }
}
