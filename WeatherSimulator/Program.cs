class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of days to simulate: ");

        int days = int.Parse(Console.ReadLine());

        int[] temperature = new int[days];

        string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
        string[] weatherConditions = new string[days];

        Random random = new Random();

        for (int i = 0; i < days; i++)
        {
            temperature[i] = random.Next(-10, 40);
           weatherConditions[i] = conditions[random.Next(conditions.Length)];
            
        }


        temperature.Max();
        double avarageTemp = CalculateAvarage(temperature);
        Console.WriteLine($"Avare Temperature {avarageTemp}");
        Console.WriteLine($" the max temp was : {temperature.Max()}");
        Console.WriteLine($" the min temp was : {temperature.Min()}");
       // Console.WriteLine($" the min temp was : {MinTemperature(temperature)}");
       
        Console.ReadKey();
    }


    static double CalculateAvarage(int[] temperature)
    {
        double sum = 0;

        for (int i = 0; i < temperature.Length; i++)
        {
            sum += temperature[i];
        }

        // temperature.Length is the amount of items inside of temperature
        var avarage = sum / temperature.Length;

        return avarage;
    }


    // calculate Optional code
    static int MinTemperature(int[] temperature)
    {
        int min = temperature[0];

        foreach(int temp in temperature)
        {
            if( temp < min)
            {
                min = temp; 
            }
        
        }
         return min;    


    }


}