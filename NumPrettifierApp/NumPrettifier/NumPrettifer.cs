namespace NumPrettifierApp.NumPrettifier;

public interface NumberPrettifierBase
{
    string Prettify(decimal num);
}

public class NumberPrettifier : NumberPrettifierBase
{
    // Constants
    private const decimal Million = 1_000_000;
    private const decimal Billion = 1_000_000_000;
    private const decimal Trillion = 1_000_000_000_000;

    public string Prettify(decimal num)
    {
        // Different cases
        switch (num)
        {
            case >= Trillion:
                return (num / Trillion).ToString("0.#") + "T";
            case >= Billion:
                return (num / Billion).ToString("0.#") + "B";
            case >= Million:
                return (num / Million).ToString("0.#") + "M";
            default:
                return num.ToString();
        }
    }
}