using NumPrettifierApp.Prettifier;

namespace NumPrettifierApp;

public class Program
{
    public static void Main(string[] args)
    {
        NumPrettifier prettifier = new NumPrettifier();
        Console.WriteLine(prettifier.Prettify(1200000, RoundingMethod.RoundNearest));
    }
}