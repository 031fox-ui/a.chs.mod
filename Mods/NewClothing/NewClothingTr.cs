internal static class NewClothingTr
{
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Connect to a host first.", "请先连接到房主。"),
        ("A clothing reload is already in progress.", "正在重新加载服装，请稍候。"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("Hot reloaded {0} clothing items.", "已热重载 {0} 件服装。"),
        ("Downloaded and hot reloaded {0} clothing items. Previous folder saved as NewClothing.backup-*.", "已下载并热重载 {0} 件服装。原文件夹已另存为 NewClothing.backup-*。"),
        ("Clothing reload failed; previous registry kept. {0}", "服装重新加载失败，已保留原有注册表。{0}"),
        ("Clothing download/reload failed. Active registry kept. {0}", "服装下载/重新加载失败，已保留当前注册表。{0}"),
        ("[NewClothing] Registered {0} items.", "[NewClothing] 已注册 {0} 件物品。"),
        ("<color=red>[NewClothing] Folder transfer failed: {0}; {1}", "<color=red>[NewClothing] 文件夹传输失败：{0}; {1}"),
        ("<color=red>[NewClothing] Download/reload failed: {0}; {1}", "<color=red>[NewClothing] 下载/重新加载失败：{0}; {1}"),
        ("<color=red>[NewClothing] Reload failed: {0}; {1}", "<color=red>[NewClothing] 重新加载失败：{0}; {1}"),
        ("<color=red>[NewClothing] Unable to load {0}: {1}; {2}", "<color=red>[NewClothing] 无法加载 {0}：{1}; {2}"),
        ("<color=red>[NewClothing] Old item cleanup failed: {0}; {1}", "<color=red>[NewClothing] 旧物品清理失败：{0}; {1}"),
        ("<color=red>[NewClothing] Could not remove an old item during reload: {0}; {1}", "<color=red>[NewClothing] 重新加载时无法移除旧物品：{0}; {1}"),
        ("<color=yellow>[NewClothing] Console autocomplete refresh failed: {0}; {1}", "<color=yellow>[NewClothing] 控制台自动补全刷新失败：{0}; {1}"),
    };
    public static readonly (string En, string Zh)[] CommandDescs =
    {
        ("Reload clothing JSON and PNG files. Removes existing NewClothing items, as in the original RshLib version.", "重新加载服装的 JSON 与 PNG 文件。会移除现有的 NewClothing 物品，与原 RshLib 版本行为一致。"),
        ("Download the Together host's clothing pack, backing up your current pack and hot reload it.", "下载 Together 房主的服装包，备份你当前的服装包并热重载。"),
    };
}
