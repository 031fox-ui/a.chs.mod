internal static class MultiplayerSpriteReplacerTrTw
{
    public static readonly (string En, string Zh)[] Commands =
    {
        ("Multiplayer Sprite Replacer controls.", "【多人皮膚替換器】多人皮膚替換器控制命令。"),
        ("action", "操作"),
        ("value", "值"),
        ("slot, player, or setting value", "槽位、玩家或設置值"),
        ("equip, download, reload, ban, unban, bans, list, verbose", "equip裝備、download下載、reload重新加載、ban封禁、unban解封、bans封禁列表、list列表、verbose詳細日誌"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Usage: msr equip st1", "用法 : msr equip st1"),
        ("Usage: msr download st1 https://skin.cat-bot.de/d/423", "用法 : msr download st1 https://skin.cat-bot.de/d/423"),
        ("Usage: msr ban username", "用法 : msr ban username"),
        ("Usage: msr unban username", "用法 : msr unban username"),
        ("No MSR skin bans.", "沒有 MSR 皮膚封禁。"),
        ("No skin slots found.", "未找到皮膚槽位。"),
        ("Invalid slot. Use st0 through st9.", "無效槽位。請使用 st0 到 st9。"),
        ("Missing skin URL.", "缺少皮膚網址。"),
        ("Downloaded archive did not contain a Body or Head folder.", "下載的壓縮包中未包含 Body 或 Head 文件夾。"),
        ("Commands: msr equip <slot>", "命令 : msr equip <槽位>"),
        ("msr download <slot> <url>", "msr download <槽位> <網址>"),
        ("msr ban <username>", "msr ban <用戶名>"),
        ("msr unban <username>", "msr unban <用戶名>"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("Skin slot not found: {0}", "未找到皮膚槽位 : {0}"),
        ("Equipped {0}.", "已裝備 {0}。"),
        ("Reloaded {0}.", "已重新加載 {0}。"),
        ("Banned skin display for {0}.", "已封禁 {0} 的皮膚顯示。"),
        ("Unbanned skin display for {0}.", "已解封 {0} 的皮膚顯示。"),
        ("Banned players: {0}", "已封禁玩家 : {0}"),
        ("Available slots: {0}", "可用槽位 : {0}"),
        ("Verbose logging: {0}", "詳細日誌 : {0}"),
        ("Downloaded skin into {0}.", "已將皮膚下載到 {0}。"),
        ("MSR error: {0}", "MSR 錯誤 : {0}"),
    };
    public static readonly (string En, string Zh)[] Ui =
    {
        ("Multiplayer Sprite Replacer", "多人皮膚替換器"),
        ("Verbose logging", "詳細日誌"),
        ("Auto-refresh changed skins", "自動刷新變更的皮膚"),
        ("Equip", "裝備"),
        ("Reload", "重新加載"),
        ("Use URL", "使用網址"),
        ("Skin URL", "皮膚網址"),
        ("Press key...", "按下按鍵..."),
    };
    public static readonly (string En, string Zh)[] UiFormats =
    {
        ("Current slot: {0}", "當前槽位：{0}"),
        ("{0} (empty)", "{0}（空）"),
        ("{0} (equipped)", "{0}（已裝備）"),
        ("Keybind {0}", "按鍵綁定 {0}"),
    };
}
