namespace TesterLib;
using MathLib;
[TestClass]
public class MathTest
{
    [TestMethod]
    public void TestAddition()
    {
        //Prepare Data
        //
        int num1=76;
        int num2=8;
        int expectedValue=84;
        int actualResult=MathEngine.Add(num1,num2); 
        Assert.AreEqual(expectedValue, actualResult);

    }


    [TestMethod]
    public void TestAddition2()
    {
        //Prepare Data
        //
        int num1=89;
        int num2=1;
        int expectedValue=90;
        int actualResult=MathEngine.Add(num1,num2); 
        Assert.AreEqual(expectedValue, actualResult);

    }

    [TestMethod]
    public void TestSubtraction()
    {
        int num1=98;
        int num2=7;
        int expectedValue=91;
        int actualResult=MathEngine.Subtract(num1,num2); 
        Assert.AreEqual(expectedValue, actualResult);

    }


    [TestMethod]
    public void TestMultiplication()
    {
        int num1=9;
        int num2=7;
        int expectedValue=63;
        int actualResult=MathEngine.Multiply(num1,num2); 
        Assert.AreEqual(expectedValue, actualResult);
  }


    

}