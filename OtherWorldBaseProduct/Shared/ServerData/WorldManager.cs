using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtherWorldBaseProduct.Shared.Model;

namespace OtherWorldBaseProduct.Shared.ServerData
{

    /// <summary>
    /// 世界標準設定
    /// </summary>
    public class WorldChangeSetupconfig
    {
        /// <summary>
        /// 転生先の世界番号
        /// </summary>
        public int worldId { get; set; }

        ///
        /// 転生希望パラメータ種類
        /// 潜在能力SSR等
        ///
        public string condition { get; set; }
    }

    /// <summary>
    /// 転生先情報
    /// </summary>
    public class WorldBaseMaster
    {
        public int id { get; set; }
        /// <summary>
        /// 多言語化するときは拡張する
        /// </summary>
        public string name { get; set; }


        public int areaid { get; set; }

        public Vector3 startPosition { get; set; }

        public RoleMaster startRole { get; set; }


        public WorldBaseMaster(int id, string name, int areaid)
        {
            this.id = id;
            this.name = name;
            startPosition = new Vector3();
            this.areaid = areaid;
            startRole = new RoleMaster();

        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class WorldManager
    {
        /// <summary>
        /// 転生先の世界一覧
        /// </summary>
        public List<WorldBaseMaster> worldMasters { get; set; }


        /// <summary>
        /// 最初に連れてかれる世界等のセットアップ
        ///</summary>
        public WorldChangeSetupconfig worldChangeSetupconfig { get; set; }

        private const int IdColNum = 0;
        private const int NameColNum = 1;
        private const int AreaColNum = 2;

        private const int StartXColNum = 3;
        private const int StartYColNum = 4;
        private const int StartZColNum = 5;

        private const string DelimiterStr = ",";

        private const int WorldIdnum = 0;
        private const int ConditionNum = 1;


        /// <summary>
        /// データ元から、各情報を取得する
        /// </summary>
        public void DataRead()
        {

            worldMasters = new List<WorldBaseMaster>();
 
            // 異世界一覧を読み込む
            var worlds = File.ReadAllLines(@"./wwwroot\world_base_master.csv");
            foreach (var worldRow in worlds) {
                var worldDatas = worldRow.Split(DelimiterStr);
                var id = int.Parse(worldDatas[IdColNum]);
                var name = worldDatas[NameColNum];
                var area = int.Parse(worldDatas[AreaColNum]);
                // 転生先情報を取得する
                WorldBaseMaster worldBaseMaster = new WorldBaseMaster(id, name, area);
                worldBaseMaster.startRole = new RoleMaster();
                worldBaseMaster.startPosition = new Vector3();
                var x = int.Parse(worldDatas[StartXColNum]);
                var y = int.Parse(worldDatas[StartYColNum]);
                var z = int.Parse(worldDatas[StartZColNum]);
                worldBaseMaster.startPosition.x = x;
                worldBaseMaster.startPosition.y = y;
                worldBaseMaster.startPosition.z = z;
                worldBaseMaster.startRole.whiteCommands = new List<CommandMaster>();
                worldMasters.Add(worldBaseMaster);
            }


            // 転生先情報を読み込む
            var setUpConfigs = File.ReadAllLines(@"./wwwroot\setup_config.csv");
            var setUpDatas = setUpConfigs[0].Split(DelimiterStr);
            worldChangeSetupconfig = new WorldChangeSetupconfig();
            worldChangeSetupconfig.worldId = int.Parse(setUpDatas[WorldIdnum]);
            worldChangeSetupconfig.condition = setUpDatas[ConditionNum];

        }

        /// <summary>
        /// 
        /// </summary>
        public void DataUpdate()
        {
            var setupLists = new List<string>();

            setupLists.Add(String.Format("{0},{1}", worldChangeSetupconfig.worldId.ToString(), worldChangeSetupconfig.condition));

            // 転生先情報を更新
            File.WriteAllLines(@"./wwwroot\setup_config.csv", setupLists.ToArray());


        }

    }
}
