internal static class NewFirearmsTrTw
{
    public static readonly (string En, string Zh)[] Talks =
    {
        ("Welcome to the firearm handling course", "歡迎來到槍械操作訓練課程"),
        ("Starting off from treating firearms related injuries", "從治療槍械相關損傷開始"),
    };
    public static readonly (string En, string Zh)[] CommandDescs =
    {
        ("You must have a loaded gun. Prevents last stand", "【新槍械】你必須有一把裝好彈的槍。防止進入背水一戰。"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("you dont have a gun. you are gonna suffer.", "你沒有槍。你有得受了。"),
        ("Gun is not ready. Try remove safety?", "槍械未就緒。試試解除保險？"),
    };
    public static readonly (string En, string Zh)[] Alerts =
    {
        ("Denied gun suicide", "槍械自殺請求被拒絕"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("<color=yellow>Removing casing from magazine :hmm:; {0}", "<color=yellow>從彈匣取出彈殼 :hmm:; {0}"),
        ("[NewFirearms] Replace recipe at {0} for {1}", "[NewFirearms] 在位置 {0} 將配方替換為 {1}"),
        ("[NewFirearms] Added recipe at {0} for {1}", "[NewFirearms] 在位置 {0} 添加配方 : {1}"),
        ("<color=red>[NewFirearms] Unable to patch recipes! No replacment left.; {0}", "<color=red>[NewFirearms] 無法修補配方！無可用替換資源。; {0}"),
        ("<color=yellow>[GunMinigame] Target magazine doesnt implement IMinigameMag!; {0}", "<color=yellow>[GunMinigame] 目標彈匣未實現 IMinigameMag！; {0}"),
        ("<color=yellow>[GunMinigame] Expected item doesnt have a AmmoScript :tourniqet:; {0}", "<color=yellow>[GunMinigame] 目標物品沒有 AmmoScript :tourniqet:; {0}"),
        ("<color=yellow>[GunMinigame-NewFirearms] Expected item doesnt have a RshMag :tourniqet:; {0}", "<color=yellow>[GunMinigame-NewFirearms] 目標物品沒有 RshMag :tourniqet:; {0}"),
        ("<color=yellow>[NewFirearms] Magazine {0} doesnt have a ammo fillup for {1}; {2}", "<color=yellow>[NewFirearms] 彈匣 {0} 沒有適用於 {1} 的彈藥裝填 ; {2}"),
        ("<color=red>[NewFirearms] Gunsaw Genetics integration failed! Send a bug report.; {0}", "<color=red>[NewFirearms] 與 Gunsaw Genetics 的集成失敗！請提交錯誤報告。; {0}"),
    };
}
