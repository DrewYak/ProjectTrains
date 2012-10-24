using System;
using NUnit.Framework;
//

//DrewYak7
[TestFixture]
class DemoPassengers
{        
    [Test]
    public static UInt32 Summa(UInt32 a, UInt32 b)
    {
        return a + b;
    }
}

class DemoTest
{    
    [Test]
    public static void MyTestFunction()
    {
        UInt32 a = 2;
        UInt32 b = 5;

        Assert.IsTrue(DemoPassengers.Summa(a, b) >= 0);
        Assert.IsInstanceOf<String>(DemoPassengers.Summa(a, b));
        Assert.AreEqual(a + b, DemoPassengers.Summa(a, b));
    }

    [Test]
    public static void MyTestFunction_2()
    {
        UInt32 a = 2;
        UInt32 b = 5;

        Assert.IsTrue(DemoPassengers.Summa(a, b) >= 0);
        Assert.IsInstanceOf<UInt32>(DemoPassengers.Summa(a, b));
        Assert.AreEqual(a + b, DemoPassengers.Summa(a, b));
    }

}