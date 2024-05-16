using HelloWorldLib;

namespace Test
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void ShouldSayHelloWorld()
        {
            var res = HelloWorld.Say();
            
            Assert.IsNotNull(res);
            Assert.AreEqual("Hello World", res);
        }
    }
}