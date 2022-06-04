// 異世界フレームワークの遷移を残す(製品的な意味で
using PlantUml.Net;

var factory = new RendererFactory();

var renderer = factory.CreateRenderer(new PlantUmlSettings());

// 異世界共通処理
var worldSetupStr = "";
worldSetupStr += "Manager -> Browser : WorldEdit\r\n";
worldSetupStr += "Browser -> Datastore : WorldEditResult\r\n";
worldSetupStr += "Datastore -> Browser : WorldEditResultResponse\r\n";
worldSetupStr += "Browser -> Manager : WorldEditResultResponse\r\n";
worldSetupStr += "Manager -> Browser : WorldAreaEdit\r\n";
worldSetupStr += "group 各エリア設定 \r\n";
worldSetupStr += "Browser -> Datastore : WorldAreaEditresult\r\n";
worldSetupStr += "Datastore -> Browser : WorldAreaEditResultResponse\r\n";
worldSetupStr += "Browser -> Manager : WorldAreaEditResultResponse\r\n";


// オフラインソフトウェアの場合
var dataOfflineAppStr = "group 異世界転生先設定開始 \r\n";
dataOfflineAppStr += worldSetupStr;
dataOfflineAppStr += "end\r\n";
dataOfflineAppStr += "group 登場キャラ設定 \r\n";
dataOfflineAppStr += "end\r\n";
dataOfflineAppStr += "group データ整合性確認 \r\n";
dataOfflineAppStr += "end\r\n";
dataOfflineAppStr += "group ゲーム・アプリ用ダウンロード \r\n";
dataOfflineAppStr += "end\r\n";
dataOfflineAppStr += "group ゲーム・アプリ側にデータセットアップ \r\n";
dataOfflineAppStr += "end\r\n";
dataOfflineAppStr += "group 異世界起動 \r\n";
dataOfflineAppStr += "end\r\n";
dataOfflineAppStr += "end\r\n";




// オンラインゲームソフトウェアの場合
var dataOnlineAppStr = "group 異世界転生先設定開始 \r\n";
dataOnlineAppStr += worldSetupStr;
dataOnlineAppStr += "end\r\n";
dataOnlineAppStr += "group 登場キャラ設定 \r\n";
dataOnlineAppStr += "end\r\n";
dataOnlineAppStr += "group データ整合性確認 \r\n";
dataOnlineAppStr += "end\r\n";
dataOnlineAppStr += "group 配信サーバー更新 \r\n";
dataOnlineAppStr += "end\r\n";
dataOnlineAppStr += "group アプリ側確認 \r\n";
dataOnlineAppStr += "end\r\n";
dataOnlineAppStr += "end\r\n";


var bytes = renderer.Render(dataOfflineAppStr, OutputFormat.Png);

File.WriteAllBytes("offline_data_flow.png", bytes);

bytes = renderer.Render(dataOnlineAppStr, OutputFormat.Png);

File.WriteAllBytes("online_data_flow.png", bytes);


// 提出課題の場合
var workFlowAppStr = "group 開発するものテーマ決め (develop theme) \r\n";
workFlowAppStr += "end\r\n";
workFlowAppStr += "group 各回でのボリューム決定 (phase volume decide) \r\n";
workFlowAppStr += "end\r\n";
workFlowAppStr += "group 開発と提出(develop and report) \r\n";
workFlowAppStr += "end\r\n";
workFlowAppStr += "group 提出用書類作成 (release note create) \r\n";
workFlowAppStr += "end\r\n";
workFlowAppStr += "group 完了 (done) \r\n";
workFlowAppStr += "end\r\n";



bytes = renderer.Render(workFlowAppStr, OutputFormat.Png);

File.WriteAllBytes("develop_work_flow.png", bytes);


// 提出課題の場合
var productFlowAppStr = "group エミュレータの見た目それっぽく \r\n";
productFlowAppStr += "end\r\n";
productFlowAppStr += "group 電源がつくようにするよ  \r\n";
productFlowAppStr += "end\r\n";
productFlowAppStr += "group 電源をオフにして、ロゴを作成 \r\n";
productFlowAppStr += "end\r\n";
productFlowAppStr += "group ゲームのタイトルとか決めるよ \r\n";
productFlowAppStr += "end\r\n";
productFlowAppStr += "group エミュレータ内で動くように  \r\n";
productFlowAppStr += "end\r\n";
productFlowAppStr += "group エミュレータ動かしたり機能確認 \r\n";
productFlowAppStr += "end\r\n";



bytes = renderer.Render(productFlowAppStr, OutputFormat.Png);

File.WriteAllBytes("product_work_flow.png", bytes);


var productClassStructStr = "@startuml";

productClassStructStr += "package PackageOtherWorld {";
productClassStructStr += "    package Model{";
productClassStructStr += "        class FoodResult {";
productClassStructStr += "        foodData";
productClassStructStr += "        }";

productClassStructStr += "    }";

productClassStructStr += "}";



productClassStructStr += "@enduml";


bytes = renderer.Render(productClassStructStr, OutputFormat.Png);

File.WriteAllBytes("product_class_struct.png", bytes);
