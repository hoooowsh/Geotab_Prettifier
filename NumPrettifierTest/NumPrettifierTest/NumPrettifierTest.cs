using NumPrettifierApp.NumPrettifier;

namespace NumPrettifierTest;

public class NumPrettifierTest
{
    [Fact(DisplayName = "Should prettify number 1000000 to 1M")]
    public void TestPrettify_Million_1M()
    {
        NumberPrettifier prettifier = new NumberPrettifier();
        Assert.Equal("1M", prettifier.Prettify(1000000));
    }

    [Fact(DisplayName = "Should prettify number 2500000.34 to 2.5M")]
    public void TestPrettify_Million_DecimalM()
    {
        NumberPrettifier prettifier = new NumberPrettifier();
        Assert.Equal("2.5M", prettifier.Prettify(2500000.34m));
    }

    [Fact(DisplayName = "Should prettify number 1000000000 to 1B")]
    public void TestPrettify_Billion_1B()
    {
        NumberPrettifier prettifier = new NumberPrettifier();
        Assert.Equal("1B", prettifier.Prettify(1000000000));
    }

    [Fact(DisplayName = "Should prettify number 1123456789 to 1.1B")]
    public void TestPrettify_Billion_DecimalB()
    {
        NumberPrettifier prettifier = new NumberPrettifier();
        Assert.Equal("1.1B", prettifier.Prettify(1123456789));
    }

    [Fact(DisplayName = "Should prettify number 1000000000000 to 1T")]
    public void TestPrettify_Billion_1T()
    {
        NumberPrettifier prettifier = new NumberPrettifier();
        Assert.Equal("1T", prettifier.Prettify(1000000000000));
    }

    [Fact(DisplayName = "Should prettify number 1888777666555.43124 to 1.9T")]
    public void TestPrettify_Billion_DecimalT()
    {
        NumberPrettifier prettifier = new NumberPrettifier();
        Assert.Equal("1.9T", prettifier.Prettify(1888777666555.43124m));
    }
}