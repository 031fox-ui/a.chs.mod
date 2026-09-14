internal static class RshLibTrTw
{
    public static readonly (string En, string Zh)[] Alerts =
    {
        ("You are missing or using an older version of RshLib", "你缺少 RshLib 或正在使用舊版本"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("A save file exists at \"{0}\\save.sv\", but it could not be parsed. The save is invalid or corrupted.\n{1}\n{2}", "存檔文件「{0}\\save.sv」已存在，但無法解析。存檔無效或已損壞。\n{1}\n{2}"),
        ("Trying to load body field \"{0}\", but such field does not exist. Loading will continue. Make a bug report to RshLib.", "嘗試加載身體字段「{0}」，但該字段不存在。將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during setting body field \"{0}\".\n{1}\n{2}\nLoading will continue. Make a bug report to RshLib.", "設置身體字段「{0}」時發生錯誤。\n{1}\n{2}\n將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Trying to load limb field \"{0}\" on limb \"{1}\", but such field does not exist. Loading will continue. Make a bug report to RshLib.", "嘗試在肢體「{1}」上加載肢體字段「{0}」，但該字段不存在。將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during setting \"{0}\" field \"{1}\".\n{2}\n{3}\nLoading will continue. Make a bug report to RshLib.", "設置「{0}」的字段「{1}」時發生錯誤。\n{2}\n{3}\n將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during parsing global item data.\n{0}\n{1}\nLoading has been cancelled. Make a bug report to RshLib.", "解析全局物品數據時發生錯誤。\n{0}\n{1}\n加載已取消。請向 RshLib 提交錯誤報告。"),
        ("Error occured during creating item \"{0}\".\n{1}\n{2}\nLoading will continue. Are you missing a mod?", "創建物品「{0}」時發生錯誤。\n{1}\n{2}\n將繼續加載。是否缺少某個模組？"),
        ("Error occured during picking up item \"{0}\".\n{1}\n{2}\nLoading will continue. Make a bug report to RshLib.", "拾取物品「{0}」時發生錯誤。\n{1}\n{2}\n將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during loading item \"{0}\". \"{1}\" is not a valid type. Loading will continue. Make a bug report to RshLib.", "加載物品「{0}」時發生錯誤。「{1}」不是有效的類型。將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during loading item \"{0}\". Component for \"{1}\" doesn't exist on object. Loading will continue. Make a bug report to RshLib.", "加載物品「{0}」時發生錯誤。對象上不存在「{1}」組件。將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during loading item \"{0}\". Field for \"{1}\" doesn't exist. Loading will continue. Make a bug report to RshLib.", "加載物品「{0}」時發生錯誤。不存在「{1}」字段。將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during loading item \"{0}\".\n{1}\n{2}\nLoading will continue. Make a bug report to RshLib.", "加載物品「{0}」時發生錯誤。\n{1}\n{2}\n將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during applying player components.\n{0}\n{1}\nLoading will continue. Make a bug report to RshLib.", "應用玩家組件時發生錯誤。\n{0}\n{1}\n將繼續加載。請向 RshLib 提交錯誤報告。"),
        ("Error occured during applying world state.\n{0}\n{1}\nMake a bug report to RshLib.", "應用世界狀態時發生錯誤。\n{0}\n{1}\n請向 RshLib 提交錯誤報告。"),
        ("GlobalItems already contain {0}, so it will be overrided", "GlobalItems 已包含 {0}，因此它將被覆蓋"),
        ("[RshLib] RshLib 3.1.1, KrokMP: {0}", "[RshLib] RshLib 3.1.1，KrokMP : {0}"),
        ("<color=red>[RshLib] ! GAME VERSION MISMATCH, Expected: 7.0.1, Current: {0}, Loading will continue; {1}", "<color=red>[RshLib] ！遊戲版本不匹配，預期 : 7.0.1，當前 : {0}，將繼續加載；{1}"),
    };
    public static readonly (string En, string Zh)[] UiFormats =
    {
        ("This is a modded beta build ({0}); Things are subject to change. (Demo)", "這是模組化 Beta 測試版（{0}）；內容可能隨時變化。（Demo）"),
        ("This is a modded beta build ({0}); Things are subject to change.", "這是模組化 Beta 測試版（{0}）；內容可能隨時變化。"),
    };
}
