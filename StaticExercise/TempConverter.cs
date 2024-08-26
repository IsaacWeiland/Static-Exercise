namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double temperature)
    {
        return (temperature - 32) * 0.555;
    }

    public static double CelsiusToFahrenheit(double temperature)
    {
        return (temperature * 1.8) + 32;
    }
}