internal static class RshLibTr
{
    public static readonly (string En, string Zh)[] Alerts =
    {
        ("You are missing or using an older version of RshLib", "你缺少 RshLib 或正在使用旧版本"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("A save file exists at \"{0}\\save.sv\", but it could not be parsed. The save is invalid or corrupted.\n{1}\n{2}", "存档文件「{0}\\save.sv」已存在，但无法解析。存档无效或已损坏。\n{1}\n{2}"),
        ("Trying to load body field \"{0}\", but such field does not exist. Loading will continue. Make a bug report to RshLib.", "尝试加载身体字段「{0}」，但该字段不存在。将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during setting body field \"{0}\".\n{1}\n{2}\nLoading will continue. Make a bug report to RshLib.", "设置身体字段「{0}」时发生错误。\n{1}\n{2}\n将继续加载。请向 RshLib 提交错误报告。"),
        ("Trying to load limb field \"{0}\" on limb \"{1}\", but such field does not exist. Loading will continue. Make a bug report to RshLib.", "尝试在肢体「{1}」上加载肢体字段「{0}」，但该字段不存在。将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during setting \"{0}\" field \"{1}\".\n{2}\n{3}\nLoading will continue. Make a bug report to RshLib.", "设置「{0}」的字段「{1}」时发生错误。\n{2}\n{3}\n将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during parsing global item data.\n{0}\n{1}\nLoading has been cancelled. Make a bug report to RshLib.", "解析全局物品数据时发生错误。\n{0}\n{1}\n加载已取消。请向 RshLib 提交错误报告。"),
        ("Error occured during creating item \"{0}\".\n{1}\n{2}\nLoading will continue. Are you missing a mod?", "创建物品「{0}」时发生错误。\n{1}\n{2}\n将继续加载。是否缺少某个模组？"),
        ("Error occured during picking up item \"{0}\".\n{1}\n{2}\nLoading will continue. Make a bug report to RshLib.", "拾取物品「{0}」时发生错误。\n{1}\n{2}\n将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during loading item \"{0}\". \"{1}\" is not a valid type. Loading will continue. Make a bug report to RshLib.", "加载物品「{0}」时发生错误。「{1}」不是有效的类型。将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during loading item \"{0}\". Component for \"{1}\" doesn't exist on object. Loading will continue. Make a bug report to RshLib.", "加载物品「{0}」时发生错误。对象上不存在「{1}」组件。将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during loading item \"{0}\". Field for \"{1}\" doesn't exist. Loading will continue. Make a bug report to RshLib.", "加载物品「{0}」时发生错误。不存在「{1}」字段。将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during loading item \"{0}\".\n{1}\n{2}\nLoading will continue. Make a bug report to RshLib.", "加载物品「{0}」时发生错误。\n{1}\n{2}\n将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during applying player components.\n{0}\n{1}\nLoading will continue. Make a bug report to RshLib.", "应用玩家组件时发生错误。\n{0}\n{1}\n将继续加载。请向 RshLib 提交错误报告。"),
        ("Error occured during applying world state.\n{0}\n{1}\nMake a bug report to RshLib.", "应用世界状态时发生错误。\n{0}\n{1}\n请向 RshLib 提交错误报告。"),
        ("GlobalItems already contain {0}, so it will be overrided", "GlobalItems 已包含 {0}，因此它将被覆盖"),
        ("[RshLib] RshLib 3.1.1, KrokMP: {0}", "[RshLib] RshLib 3.1.1，KrokMP : {0}"),
        ("<color=red>[RshLib] ! GAME VERSION MISMATCH, Expected: 7.0.1, Current: {0}, Loading will continue; {1}", "<color=red>[RshLib] ！游戏版本不匹配，预期 : 7.0.1，当前 : {0}，将继续加载；{1}"),
    };
    public static readonly (string En, string Zh)[] UiFormats =
    {
        ("This is a modded beta build ({0}); Things are subject to change. (Demo)", "这是模组化 Beta 测试版（{0}）；内容可能随时变化。（Demo）"),
        ("This is a modded beta build ({0}); Things are subject to change.", "这是模组化 Beta 测试版（{0}）；内容可能随时变化。"),
    };
}
