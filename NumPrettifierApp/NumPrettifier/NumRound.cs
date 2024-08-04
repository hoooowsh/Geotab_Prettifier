namespace NumPrettifierApp.Prettifier;

public enum RoundingMethod
{
    RoundUp,
    RoundDown,
    RoundNearest
}

public interface INumRound
{
    string Round(decimal num, RoundingMethod method);
}

public class NumRound : INumRound
{
    public string Round(decimal num, RoundingMethod method)
    {
        // Round up or down or closest
        switch (method)
        {
            case RoundingMethod.RoundUp:
                return (Math.Ceiling(num * 10) / 10).ToString("0.#");
            case RoundingMethod.RoundDown:
                return (Math.Floor(num * 10) / 10).ToString("0.#");
            case RoundingMethod.RoundNearest:
                return Math.Round(num, 1).ToString("0.#");
            default:
                throw new ArgumentOutOfRangeException(nameof(method), "Invalid rounding method");
        }
    }
}