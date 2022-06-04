using Microsoft.VisualStudio.TestTools.UnitTesting;
using OtherWorldBaseProduct.Shared.ServerData;
namespace OtherWorldBaseProductTestTool
{
    [TestClass]
    public class WorldManagerTest
    {
        /// <summary>
        /// �]����ݒ�
        /// </summary>
        [TestMethod]
        public void WorldManagerBaseMasterConstructTest()
        {
            var testId = 100;
            var name = "MMORPG�̂Ȃ�";
            var areaId = 400;
            WorldBaseMaster worldBaseMaster = new WorldBaseMaster(testId, name, areaId);
            // �]����̏������ł��Ă��邩���m�F����
            Assert.IsTrue(worldBaseMaster.id == testId);
            Assert.IsTrue(worldBaseMaster.name == name);
            Assert.IsTrue(worldBaseMaster.areaid  == areaId);            
        }
    }
}