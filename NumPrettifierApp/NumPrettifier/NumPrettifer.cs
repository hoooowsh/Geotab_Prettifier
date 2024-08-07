namespace NumPrettifierApp.Prettifier;

public interface INumPrettifier
{
    string Prettify(decimal num, RoundingMethod method);
}

public class NumPrettifier : INumPrettifier
{
    // Constants
    private const decimal Million = 1_000_000;
    private const decimal Billion = 1_000_000_000;
    private const decimal Trillion = 1_000_000_000_000;

    private readonly NumRound _numRound;

    public NumPrettifier()
    {
        _numRound = new NumRound();
    }

    public string Prettify(decimal num, RoundingMethod roundingMethod)
    {
        try
        {
            // Different cases
            switch (Math.Abs(num))
            {
                case >= Trillion:
                    return _numRound.Round(num / Trillion, roundingMethod) + "T";
                case >= Billion:
                    return _numRound.Round(num / Billion, roundingMethod) + "B";
                case >= Million:
                    return _numRound.Round(num / Million, roundingMethod) + "M";
                default:
                    return num.ToString();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            return "Invalid rounding method";
        }
        catch (Exception)
        {
            return "An error occurred";
        }
    }
}