class Program
{
    public const int IS_FULLTIME = 1;
    public const int IS_PARTIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int MONTH_DAYS = 20;
    //int empWages = 0;
    //int empHours = 0;
    public static int empWages = 0;
    public static int empHours = 0, DAY = 0;
    public static int earnedWages = 0;
    public static int totalWorkingHours = 0;

    public void calculateWages()
    {
        empWages = empHours * EMP_RATE_PER_HOUR;
        earnedWages = empWages * DAY;
        totalWorkingHours += DAY * empHours;
        Console.WriteLine($"Total Working Hours Till Date are {totalWorkingHours}");
        Console.WriteLine($"Employee Wages are {empWages}\nEarned Wages Till Date: {earnedWages}");
    }
    static void Main(string[] args)
    {
        Random random = new Random();
        Program empWagesclass = new Program();
        do
        {
            for (DAY = 1; DAY <= MONTH_DAYS; DAY++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULLTIME:
                        Console.WriteLine($"\nDay {DAY} \nPresent");
                        empHours = 8;
                        Console.WriteLine($"Emp {empHours} Hrs present");
                        break;

                    case IS_PARTIME:
                        Console.WriteLine($"\nDay {DAY} \nPresent Part Time");
                        empHours = 4;
                        Console.WriteLine($"Emp {empHours} Hrs present");
                        break;

                    default:
                        Console.WriteLine($"\nDay {DAY} \nAbsent");
                        empWages = 0;
                        empHours = 0;
                        break;
                }
                empWagesclass.calculateWages();
                if (totalWorkingHours >= 100)
                {
                    break;
                }
            }
        } while (DAY == 20);
    }
}