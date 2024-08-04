using NumPrettifierApp.Prettifier;
using Moq;

namespace NumPrettifierTest;

public class NumPrettifierTest
{
    [Fact(DisplayName = "Should prettify number 1000000 to 1M")]
    public void TestPrettify_Million_1M()
    {
        NumPrettifier prettifier = new NumPrettifier();
        Assert.Equal("1M", prettifier.Prettify(1000000, RoundingMethod.RoundNearest));
    }

    [Fact(DisplayName = "Should prettify number 2500000.34 to 2.5M")]
    public void TestPrettify_Million_DecimalM()
    {
        NumPrettifier prettifier = new NumPrettifier();
        Assert.Equal("2.5M", prettifier.Prettify(2500000.34m, RoundingMethod.RoundNearest));
    }

    [Fact(DisplayName = "Should prettify number 1000000000 to 1B")]
    public void TestPrettify_Billion_1B()
    {
        NumPrettifier prettifier = new NumPrettifier();
        Assert.Equal("1B", prettifier.Prettify(1000000000, RoundingMethod.RoundNearest));
    }

    [Fact(DisplayName = "Should prettify number 1123456789 to 1.1B")]
    public void TestPrettify_Billion_DecimalB()
    {
        NumPrettifier prettifier = new NumPrettifier();
        Assert.Equal("1.1B", prettifier.Prettify(1123456789, RoundingMethod.RoundNearest));
    }

    [Fact(DisplayName = "Should prettify number 1000000000000 to 1T")]
    public void TestPrettify_Billion_1T()
    {
        NumPrettifier prettifier = new NumPrettifier();
        Assert.Equal("1T", prettifier.Prettify(1000000000000, RoundingMethod.RoundNearest));
    }

    [Fact(DisplayName = "Should prettify number 1888777666555.43124 to 1.9T")]
    public void TestPrettify_Billion_DecimalT()
    {
        NumPrettifier prettifier = new NumPrettifier();
        Assert.Equal("1.9T", prettifier.Prettify(1888777666555.43124m, RoundingMethod.RoundNearest));
    }

    [Fact(DisplayName = "Should prettify number 532 to 532")]
    public void TestPrettify_SmallNum()
    {
        NumPrettifier prettifier = new NumPrettifier();
        Assert.Equal("532", prettifier.Prettify(532, RoundingMethod.RoundNearest));
    }

    [Fact(DisplayName = "Should catch exp")]
    public void TestPrettify_Exp()
    {
        NumPrettifier prettifier = new NumPrettifier();
        var result = prettifier.Prettify(1_000_000, (RoundingMethod)999);
        Assert.Equal("Invalid rounding method", result);
    }
}