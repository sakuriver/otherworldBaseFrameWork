using Microsoft.VisualStudio.TestTools.UnitTesting;
using OtherWorldBaseProduct.Shared.ServerData;
namespace OtherWorldBaseProductTestTool
{
    [TestClass]
    public class WorldManagerTest
    {
        /// <summary>
        /// 転生先設定
        /// </summary>
        [TestMethod]
        public void WorldManagerBaseMasterConstructTest()
        {
            var testId = 100;
            var name = "MMORPGのなか";
            var areaId = 400;
            WorldBaseMaster worldBaseMaster = new WorldBaseMaster(testId, name, areaId);
            // 転生先の準備ができているかを確認する
            Assert.IsTrue(worldBaseMaster.id == testId);
            Assert.IsTrue(worldBaseMaster.name == name);
            Assert.IsTrue(worldBaseMaster.areaid  == areaId);            
        }
    }
}