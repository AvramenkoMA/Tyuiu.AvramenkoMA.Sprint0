
using Tyuiu.AvramenkoMA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.AvramenkoMA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Марина";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Марина", res);
        }
    }
}
