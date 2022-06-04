using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherWorldBaseProduct.Shared.Model
{

    ///
    /// 転生先世界での役割情報
    ///


    /// <summary>
    /// 転生先異世界での役割
    /// </summary>
    public class RoleMaster
    {
        public int id { get; set; }

        /// <summary>
        /// 役割職業名
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// 利用可能コマンド一覧
        /// 転生先によっては封印されたコマンドが出てくる
        /// </summary>
        public List<CommandMaster> whiteCommands { get; set; }

    }


    /// <summary>
    /// 異世界転生先で使えるコマンド情報
    /// コマンド以外は、せかいないで使うことができない
    /// </summary>
    public class CommandMaster
    {
        public int id { get; set; }


        /// <summary>
        /// コマンド名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 演出ファイル用文字列
        /// </summary>
        public string effectName { get; set; }

    }


}
