namespace NumPrettifierApp.Prettifier;

public interface INumPrettifier
{
    string Prettify(decimal num, RoundingMethod method, bool chinesePrettifier = false);
}

public class NumPrettifier : INumPrettifier
{
    // Constants
    private const decimal Million = 1_000_000;
    private const decimal Billion = 1_000_000_000;
    private const decimal Trillion = 1_000_000_000_000;
    private const decimal QuaTrillion = 1_000_000_000_000_000;

    private List<decimal> list = new List<decimal> { QuaTrillion, Trillion, Billion, Million };
    private List<string> list2 = new List<string> { "Q", "T", "B", "M" };

    private const decimal Wan = 10000;
    private const decimal Oku = 100000000;
    private const decimal Chou = 1_000_000_000_000;
    private List<decimal> ListChinese = new List<decimal> { Chou, Oku, Wan };
    private List<string> ListChinese2 = new List<string> { "C", "O", "W" };

    private readonly NumRound _numRound;

    public NumPrettifier()
    {
        _numRound = new NumRound();
    }

    public string Prettify(decimal num, RoundingMethod roundingMethod, bool chinesePrettifier = false)
    {
        try
        {
            // Chinese 
            if (chinesePrettifier)
            {
                for (int i = 0; i < ListChinese.Count(); i++)
                {
                    if (Math.Abs(num) >= ListChinese[i])
                    {
                        return _numRound.Round(num / ListChinese[i], roundingMethod) + ListChinese2[i];
                    }
                }
            }
            // English
            else
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (Math.Abs(num) >= list[i])
                    {
                        return _numRound.Round(num / list[i], roundingMethod) + list2[i];
                    }
                }
            }
            return num.ToString();
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