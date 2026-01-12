static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double result;
        if (speed == 0)
            result = 0.0;
        else if (speed >= 1 && speed <= 4)
            result = 1.0;
        else if (speed >= 5 && speed <= 8)
            result = 0.9;
        else if (speed == 9)
            result = 0.8;
        else
            result = 0.77;

        return result;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double baseRate = speed * 221;
        double successRate = SuccessRate(speed);
        return baseRate * successRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double itemsPerHour = ProductionRatePerHour(speed);
        return (int)(itemsPerHour / 60);
    }
}
