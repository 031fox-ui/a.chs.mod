namespace A.Multi_Mod.Chinese.Localization.Mods.CustomStructures;
internal static class CustomStructuresTr
{
    public static readonly (string En, string Zh)[] CommandDescs =
    {
        ("Spawns a structure at your cursor, player, or world middle.", "【自定义结构】在光标、玩家或世界中心生成一个建筑。"),
        ("Teleports to the nearest generated instance of a structure.", "【自定义结构】传送到最近的一个已生成建筑实例。"),
        ("Enables or disables custom structure generation.", "【自定义结构】启用或禁用自定义建筑生成。"),
        ("Reloads structure and custom layer files without restarting.", "【自定义结构】无需重启即可重新加载建筑与自定义层级文件。"),
        ("Sets a multiplier for all structure spawn rates. Fractional results become probabilities.", "【自定义结构】设置所有建筑生成率的倍率，小数结果按概率处理。"),
        ("Dispatches a MoreStructures signal ID to listeners.", "【自定义结构】向监听器派发一个 MoreStructures 信号 ID。"),
        ("Prints maxWeight/maxWeightPerItem for known non-liquid container prefabs.", "【自定义结构】打印已知非液体容器预制体的 maxWeight/maxWeightPerItem。"),
        ("Controls the in-game community structure browser UI. Usage: structurebrowser [toggle|refresh]", "【自定义结构】控制游戏内社区建筑浏览器 UI。用法：structurebrowser [toggle|refresh]"),
        ("float multiplier", "浮点 倍率"),
        ("string signalId", "文本 信号ID"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Container caps:", "容器上限："),
        ("Structure browser refresh requested.", "已请求刷新结构浏览器。"),
        ("Structure browser opened.", "结构浏览器已打开。"),
        ("Structure browser closed.", "结构浏览器已关闭。"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("Requested host spawn for '{0}' at {1} ({2})", "已请求主机在 {1}（{2}）生成「{0}」"),
        ("Spawned '{0}' at {1} ({2})", "已在 {1}（{2}）生成「{0}」"),
        ("Teleported to nearest '{0}' at {1} ({2:F1}m away).", "已传送到最近的「{0}」，位于 {1}（距离 {2:F1} 米）。"),
        ("More Structures set to: {0}. (Changes apply on next generation/restart)", "更多结构已设为：{0}。（下次生成/重启后生效）"),
        ("Reloaded {0} structures and {1} World layer files from disk.", "已从磁盘重新加载 {0} 个建筑和 {1} 个世界层级文件。"),
        ("Structure spawn multiplier set to {0:F2}x. (e.g., 16 spawns -> ~{1} spawns, changes apply on next generation)", "建筑生成倍率已设为 {0:F2}x。（例如：16 次生成 → 约 {1} 次，下次生成时生效）"),
        ("Signal '{0}' dispatched to {1} listener(s).", "信号「{0}」已派发给 {1} 个监听器。"),
        ("dumpcontainercaps complete. found={0}, missing={1}", "dumpcontainercaps 完成。找到={0}，缺失={1}"),
        ("Disabled '{0}' by removing {1} file(s). Loaded structures: {2}.", "已通过移除 {1} 个文件禁用「{0}」。已加载建筑：{2}。"),
        ("Showing {0} of {1} loaded structure(s).{2}", "正在显示已加载的 {0}/{1} 个建筑。{2}"),
        ("Catalog cache loaded: {0} entries. Scroll down or refresh for more.", "目录缓存已加载：{0} 个条目。向下滚动或刷新查看更多。"),
        ("Catalog cache loaded: {0} entries.", "目录缓存已加载：{0} 个条目。"),
    };
    public static readonly (string En, string Zh)[] Alerts =
    {
        ("Structure sync failed. Rejoin the host before continuing.", "结构同步失败。请重新加入主机后再继续。"),
        ("The host is not running.", "主机未在运行。"),
        ("The host world is not ready.", "主机的世界尚未就绪。"),
        ("Structure ID does not match its definition.", "结构 ID 与其定义不匹配。"),
        ("The host could not spawn the structure. See host log.", "主机无法生成该结构。请查看主机日志。"),
        ("Host has sv_cheats or client commands disabled.", "主机已禁用 sv_cheats 或客户端命令。"),
        ("Invalid More Structures spawn payload.", "无效的 More Structures 生成数据。"),
        ("More Structures command accepted.", "More Structures 命令已接受。"),
        ("More Structures command denied.", "More Structures 命令被拒绝。"),
    };
    public static readonly (string En, string Zh)[] AlertFormats =
    {
        ("Host spawned '{0}'.", "主机已生成「{0}」。"),
        ("Host could not register structure '{0}'.", "主机无法注册结构「{0}」。"),
    };
    public static readonly (string En, string Zh)[] Literals =
    {
        ("Refreshing community catalog...", "正在刷新社区目录..."),
        ("Searching...", "正在搜索..."),
        ("No cached matches yet. Search will keep loading more.", "暂无缓存匹配，搜索将继续加载更多。"),
        ("No entries found. Refresh catalog or adjust search.", "未找到条目，请刷新目录或调整搜索。"),
        ("No matches in the loaded catalog pages. Refine or clear the search to browse farther.", "已加载的目录页中没有匹配项。请细化或清空搜索以继续浏览。"),
        (" Scroll down for more.", " 向下滚动查看更多。"),
        ("Loading more community structures...", "正在加载更多社区结构..."),
        ("\n<color=grey>By ", "\n<color=grey>作者 "),
        ("Spawns ", "生成 "),
        ("Ready.", "就绪。"),
        ("Disable", "禁用"),
        ("Enable", "启用"),
        ("Community browser ready.", "社区浏览器已就绪。"),
        ("Search name:, author:, id:, score>=, installed:, enabled:", "搜索 name:、author:、id:、score>=、installed:、enabled:"),
        ("Structure ID cannot be empty.", "建筑 ID 不能为空。"),
        ("A structure download/install is already running.", "已有建筑下载/安装正在进行。"),
        ("Another structure disable operation is already running.", "已有建筑禁用操作正在进行。"),
        ("A structure disable operation is already running.", "已有建筑禁用操作正在进行。"),
        ("Catalog has not been loaded yet.", "目录尚未加载。"),
        ("A catalog request is already running.", "已有目录请求正在进行。"),
        ("All loaded catalog entries are already shown.", "所有已加载目录条目均已显示。"),
        ("A catalog refresh is already running.", "已有目录刷新正在进行。"),
        ("Catalog refresh already running.", "目录刷新已在运行。"),
        ("Remote catalog source reset to default (Firebase).", "远程目录源已重置为默认（Firebase）。"),
        ("Invalid URL. Use a full http/https URL.", "URL 无效，请使用完整的 http/https URL。"),
        ("Remote catalog source updated to: ", "远程目录源已更新为："),
        ("Untitled", "未命名"),
        ("Anonymous", "匿名"),
        ("Structure Browser", "结构浏览器"),
        ("Could not send host spawn request for '", "无法发送主机生成请求：'"),
        ("Structure browser failed to open for refresh. ", "建筑浏览器无法打开以进行刷新。"),
        ("Structure browser closed or failed to open. ", "建筑浏览器已关闭或无法打开。"),
        ("Disabling '", "正在禁用 '"),
        ("Installing '", "正在安装 '"),
        ("No local downloaded files were found for '", "未找到 ' 的本地下载文件："),
        ("Failed disabling '", "禁用失败：'"),
        ("Size {0}x{1}", "尺寸 {0}x{1}"),
        ("Objects {0}", "物体 {0}"),
        ("Items {0}", "物品 {0}"),
        ("<size=12><color=grey>Global Structure Multiplier ({0}, {1}/chunk)</color></size>", "<size=12><color=grey>全局结构倍率 ({0}, {1}/chunk)</color></size>"),
        ("Generating Custom Structures.. \n Acquiring data (", "正在生成自定义结构.. \n 正在获取数据（"),
        (")\n\n", "）\n\n"),
        ("Generating Custom Structures.. \n Generating {0} ({1}/{2})\n\n", "正在生成自定义结构.. \n 正在生成 {0}（{1}/{2}）\n\n"),
        ("Generating Custom Structures.. \n {0} ({1}/{2})\n\n", "正在生成自定义结构.. \n {0}（{1}/{2}）\n\n"),
        ("checking host", "正在检查主机"),
        ("host structures", "主机结构"),
        ("Custom Layer {0}", "自定义层级 {0}"),
        ("\n\nProperties: ", "\n\n属性："),
    };
    public static readonly (string En, string Zh)[] CrystalPropertyNames =
    {
        ("Irradiated", "辐射"),
        ("Fragile", "脆弱"),
        ("Gravity", "重力扭曲"),
        ("Electric", "电击"),
        ("Burning", "燃烧"),
        ("Temperature", "温度"),
        ("Septic", "感染"),
        ("Unstable", "不稳定"),
        ("Mimic", "拟态"),
        ("Teleport", "位置错乱"),
        ("Dripping", "融化"),
        ("Kinetic", "动能"),
        ("EMP", "电磁脉冲"),
        ("Blinding", "强光"),
        ("Metamorphic", "蜕变"),
        ("Healing", "治疗"),
        ("Shy", "怯生"),
    };
    public static readonly (string En, string Zh)[] Settings =
    {
        ("Enable custom structures", "启用自定义结构"),
        ("Whether to enable the Custom Structures mod during world generation. Requires a new game/layer to be loaded to take effect.", "是否在世界生成期间启用自定义结构模组。需要加载新游戏/新层级才能生效。"),
    };
    public static readonly (string En, string Zh)[] Ui =
    {
        ("Community Structure Browser", "社区结构浏览器"),
        ("Search by name or author...", "按名称或作者搜索..."),
        ("Freq.", "频率"),
        ("Refresh", "刷新"),
        ("Close", "关闭"),
        ("Exit", "退出"),
        ("Download", "下载"),
    };
}
