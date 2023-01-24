namespace MoneyExtenstion.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal value = 284.80M;
        var cents = value.ToCents();

        Assert.AreEqual(28480, cents);
    }
}