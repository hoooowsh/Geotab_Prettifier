namespace NumPrettifierApp.Prettifier;

public enum RoundingMethod
{
    RoundUp,
    RoundDown,
    RoundNearest
}

public interface NumRoundBase
{
    string Round(decimal num, RoundingMethod method);
}

public class NumRound : NumRoundBase
{
    public string Round(decimal num, RoundingMethod method)
    {
        Console.WriteLine(num);
        switch (method)
        {
            case RoundingMethod.RoundUp:
                return (Math.Ceiling(num * 10) / 10).ToString("0.#");
            case RoundingMethod.RoundDown:
                return (Math.Floor(num * 10) / 10).ToString("0.#");
            case RoundingMethod.RoundNearest:
                return Math.Round(num, 1).ToString("0.#");
            default:
                throw new ArgumentOutOfRangeException(nameof(method));
        }
    }
}