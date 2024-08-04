using NumPrettifierApp.NumPrettifier;

namespace NumPrettifierApp;

public class Program
{
    public static void Main(string[] args)
    {
        NumberPrettifier prettifier = new NumberPrettifier();
        Console.WriteLine(prettifier.Prettify(1200000));
    }
}