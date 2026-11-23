internal static class NewClothingTrTw
{
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Connect to a host first.", "請先連接到房主。"),
        ("A clothing reload is already in progress.", "正在重新加載服裝，請稍候。"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("Hot reloaded {0} clothing items.", "已熱重載 {0} 件服裝。"),
        ("Downloaded and hot reloaded {0} clothing items. Previous folder saved as NewClothing.backup-*.", "已下載並熱重載 {0} 件服裝。原文件夾已另存為 NewClothing.backup-*。"),
        ("Clothing reload failed; previous registry kept. {0}", "服裝重新加載失敗，已保留原有註冊表。{0}"),
        ("Clothing download/reload failed. Active registry kept. {0}", "服裝下載/重新加載失敗，已保留當前註冊表。{0}"),
        ("[NewClothing] Registered {0} items.", "[NewClothing] 已註冊 {0} 件物品。"),
        ("<color=red>[NewClothing] Folder transfer failed: {0}; {1}", "<color=red>[NewClothing] 文件夾傳輸失敗：{0}; {1}"),
        ("<color=red>[NewClothing] Download/reload failed: {0}; {1}", "<color=red>[NewClothing] 下載/重新加載失敗：{0}; {1}"),
        ("<color=red>[NewClothing] Reload failed: {0}; {1}", "<color=red>[NewClothing] 重新加載失敗：{0}; {1}"),
        ("<color=red>[NewClothing] Unable to load {0}: {1}; {2}", "<color=red>[NewClothing] 無法加載 {0}：{1}; {2}"),
        ("<color=red>[NewClothing] Old item cleanup failed: {0}; {1}", "<color=red>[NewClothing] 舊物品清理失敗：{0}; {1}"),
        ("<color=red>[NewClothing] Could not remove an old item during reload: {0}; {1}", "<color=red>[NewClothing] 重新加載時無法移除舊物品：{0}; {1}"),
        ("<color=yellow>[NewClothing] Console autocomplete refresh failed: {0}; {1}", "<color=yellow>[NewClothing] 控制檯自動補全刷新失敗：{0}; {1}"),
    };
    public static readonly (string En, string Zh)[] CommandDescs =
    {
        ("Reload clothing JSON and PNG files. Removes existing NewClothing items, as in the original RshLib version.", "重新加載服裝的 JSON 與 PNG 文件。會移除現有的 NewClothing 物品，與原 RshLib 版本行為一致。"),
        ("Download the Together host's clothing pack, backing up your current pack and hot reload it.", "下載 Together 房主的服裝包，備份你當前的服裝包並熱重載。"),
    };
}
