namespace TesterLib;
using SecurityLib;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAuthenticationRavi()
    {
        //Prepare Data
        //
        string email="ravi.tambade@transflower.in";
        string password="seed123";
        bool expectedValue=true;
        bool actualResult=AuthManager.Validate(email, password);
        Assert.AreEqual(expectedValue, actualResult);
    }


    [TestMethod]
    public void TestAuthenticationRaj()
    {
        //Prepare Data
        //
        string email="raj.malhotra@transflower.in";
        string password="simran";
        bool expectedValue=false;
        bool actualResult=AuthManager.Validate(email, password);
        Assert.AreEqual(expectedValue, actualResult);
    }
}