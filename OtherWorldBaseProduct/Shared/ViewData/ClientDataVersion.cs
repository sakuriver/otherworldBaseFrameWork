using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherWorldBaseProduct.Shared.ViewData
{
    /// <summary>
    /// クライアント側に設定する現在バージョン
    /// </summary>
    public class ClientDataVersion
    {

        /// <summary>
        /// apiから取得もとになるid
        /// 1が初期設定される
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// ダウンロードできるバージョン
        /// </summary>
        public int version { get; set; }

        /// <summary>
        /// バージョン再設定更新日時
        /// </summary>
        public DateTime updateDateTime { get; set; }
    }

    /// <summary>
    /// クライアントデータのアップロード履歴
    /// id == version で指定したバージョンのバイナリ情報の存在確認をする
    /// </summary>
    public class ClientDataHistory
    {

        /// <summary>
        /// 該当バージョン
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// バージョン作成日時
        /// </summary>
        public DateTime createDateTime { get; set; }


        /// <summary>
        /// 該当バージョンで追加したデータのコメント
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        /// バージョンファイル最終更新日時
        /// 同じバージョン更新時は本カラムが更新される
        /// </summary>
        public DateTime updateDateTime { get; set; }


    }

}
