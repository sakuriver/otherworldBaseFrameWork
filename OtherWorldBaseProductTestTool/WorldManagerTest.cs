using Microsoft.VisualStudio.TestTools.UnitTesting;
using OtherWorldBaseProduct.Shared.ServerData;
namespace OtherWorldBaseProductTestTool
{
    [TestClass]
    public class WorldManagerTest
    {
        /// <summary>
        /// “]¶æİ’è
        /// </summary>
        [TestMethod]
        public void WorldManagerBaseMasterConstructTest()
        {
            var testId = 100;
            var name = "MMORPG‚Ì‚È‚©";
            var areaId = 400;
            WorldBaseMaster worldBaseMaster = new WorldBaseMaster(testId, name, areaId);
            // “]¶æ‚Ì€”õ‚ª‚Å‚«‚Ä‚¢‚é‚©‚ğŠm”F‚·‚é
            Assert.IsTrue(worldBaseMaster.id == testId);
            Assert.IsTrue(worldBaseMaster.name == name);
            Assert.IsTrue(worldBaseMaster.areaid  == areaId);            
        }
    }
}