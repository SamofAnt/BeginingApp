using BeginingApp;
using NUnit.Framework;

namespace AppTest;

public class Tests
{
    private Duty duty;

    [SetUp]
    public void Setup()
    {
        duty = new Duty();
    }

    [Test]
    public void GetCostWithoutDuty()
    {
        //arrange
        //act
        var price = 150;
        var expected = 150;
        var result = Duty.GetDuty(price);
        //assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void GetCostWithDuty()
    {
        //arrange
        //act
        var price = 400;
        var expected = 430;
        var result = Duty.GetDuty(price);
        //assert
        Assert.AreEqual(expected, result);
    }
}