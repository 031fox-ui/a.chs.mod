using A.Multi_Mod.Chinese.Localization.Core;
namespace A.Multi_Mod.Chinese.Localization.Mods.MultiplayerSpriteReplacer;
internal static class MultiplayerSpriteReplacerTr
{
    public static readonly (string En, string Zh)[] Commands =
    {
        ("Multiplayer Sprite Replacer controls.", "【多人皮肤替换器】多人皮肤替换器控制命令。"),
        ("action", "操作"),
        ("value", "值"),
        ("slot, player, or setting value", "槽位、玩家或设置值"),
        ("equip, download, reload, ban, unban, bans, list, verbose", "equip装备、download下载、reload重新加载、ban封禁、unban解封、bans封禁列表、list列表、verbose详细日志"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Usage: msr equip st1", "用法 : msr equip st1"),
        ("Usage: msr download st1 https://skin.cat-bot.de/d/423", "用法 : msr download st1 https://skin.cat-bot.de/d/423"),
        ("Usage: msr ban username", "用法 : msr ban username"),
        ("Usage: msr unban username", "用法 : msr unban username"),
        ("No MSR skin bans.", "没有 MSR 皮肤封禁。"),
        ("No skin slots found.", "未找到皮肤槽位。"),
        ("Invalid slot. Use st0 through st9.", "无效槽位。请使用 st0 到 st9。"),
        ("Missing skin URL.", "缺少皮肤网址。"),
        ("Downloaded archive did not contain a Body or Head folder.", "下载的压缩包中未包含 Body 或 Head 文件夹。"),
        ("Commands: msr equip <slot>", "命令 : msr equip <槽位>"),
        ("msr download <slot> <url>", "msr download <槽位> <网址>"),
        ("msr ban <username>", "msr ban <用户名>"),
        ("msr unban <username>", "msr unban <用户名>"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("Skin slot not found: {0}", "未找到皮肤槽位 : {0}"),
        ("Equipped {0}.", "已装备 {0}。"),
        ("Reloaded {0}.", "已重新加载 {0}。"),
        ("Banned skin display for {0}.", "已封禁 {0} 的皮肤显示。"),
        ("Unbanned skin display for {0}.", "已解封 {0} 的皮肤显示。"),
        ("Banned players: {0}", "已封禁玩家 : {0}"),
        ("Available slots: {0}", "可用槽位 : {0}"),
        ("Verbose logging: {0}", "详细日志 : {0}"),
        ("Downloaded skin into {0}.", "已将皮肤下载到 {0}。"),
        ("MSR error: {0}", "MSR 错误 : {0}"),
    };
    public static readonly (string En, string Zh)[] Ui =
    {
        ("Multiplayer Sprite Replacer", "多人皮肤替换器"),
        ("Verbose logging", "详细日志"),
        ("Auto-refresh changed skins", "自动刷新变更的皮肤"),
        ("Equip", "装备"),
        ("Reload", "重新加载"),
        ("Use URL", "使用网址"),
        ("Skin URL", "皮肤网址"),
        ("Press key...", "按下按键..."),
    };
    public static readonly (string En, string Zh)[] UiFormats =
    {
        ("Current slot: {0}", "当前槽位：{0}"),
        ("{0} (empty)", "{0}（空）"),
        ("{0} (equipped)", "{0}（已装备）"),
        ("Keybind {0}", "按键绑定 {0}"),
    };
}
