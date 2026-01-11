class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        bool dayWithoutBirds = false;
        foreach (int dayCount in birdsPerDay)
        {             if (dayCount == 0)
            {
                dayWithoutBirds = true;
                break;
            }
        }
        return dayWithoutBirds;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sumOfVisits = 0;
        for (int i = 0; i <= numberOfDays - 1; i++)
        {
            sumOfVisits += birdsPerDay[i];
        }
        return sumOfVisits;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int count in birdsPerDay)
        {
            if (count >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
