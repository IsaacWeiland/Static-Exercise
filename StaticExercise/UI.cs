namespace StaticExercise;

public class UI
{
    public static void ProgramRun()
    {
        while (true)
        {
            Console.WriteLine("What calculator would you like?\n[1] F to C\n[2] C to F\n[3] Exit");
            switch (UserInputParse())
            {
                case 1:
                    Console.WriteLine("Please enter your temperature (in fahrenheit).");
                    double tempConversionF = TempConverter.FahrenheitToCelsius(TemperatureParse());
                    Console.WriteLine($"Your temperature in celsius is {tempConversionF}");
                    break;
                case 2:
                    Console.WriteLine("Please enter your temperature (in celsius).");
                    double tempConversionC = TempConverter.CelsiusToFahrenheit(TemperatureParse());
                    Console.WriteLine($"Your temperature in fahrenheit is {tempConversionC}");
                    break;
                case 3:
                    Console.WriteLine("Thank you for using the calculator");
                    Environment.Exit(0);
                    break;
            }
        }
    }
    public static int UserInputParse()
    {
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);
        while (!inputSuccess || parseSucceed > 3 || parseSucceed < 1)
        {
            Console.WriteLine("Please enter a number 1 - 3.");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }
        return parseSucceed;
    }
    public static double TemperatureParse()
    {
        var inputSuccess = double.TryParse(Console.ReadLine(), out double parseSucceed);
        while (!inputSuccess)
        {
            Console.WriteLine("Please enter a number 1 - 4.");
            inputSuccess = double.TryParse(Console.ReadLine(), out parseSucceed);
        }
        return parseSucceed;
    }
}