internal static class CustomStructuresTrTw
{
    public static readonly (string En, string Zh)[] CommandDescs =
    {
        ("Spawns a structure at your cursor, player, or world middle.", "【自定義結構】在光標、玩家或世界中心生成一個建築。"),
        ("Teleports to the nearest generated instance of a structure.", "【自定義結構】傳送到最近的一個已生成建築實例。"),
        ("Enables or disables custom structure generation.", "【自定義結構】啟用或禁用自定義建築生成。"),
        ("Reloads structure and custom layer files without restarting.", "【自定義結構】無需重啟即可重新加載建築與自定義層級文件。"),
        ("Sets a multiplier for all structure spawn rates. Fractional results become probabilities.", "【自定義結構】設置所有建築生成率的倍率，小數結果按概率處理。"),
        ("Dispatches a MoreStructures signal ID to listeners.", "【自定義結構】向監聽器派發一個 MoreStructures 信號 ID。"),
        ("Prints maxWeight/maxWeightPerItem for known non-liquid container prefabs.", "【自定義結構】打印已知非液體容器預製體的 maxWeight/maxWeightPerItem。"),
        ("Controls the in-game community structure browser UI. Usage: structurebrowser [toggle|refresh]", "【自定義結構】控制遊戲內社區建築瀏覽器 UI。用法：structurebrowser [toggle|refresh]"),
        ("float multiplier", "浮點 倍率"),
        ("string signalId", "文本 信號ID"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Container caps:", "容器上限："),
        ("Structure browser refresh requested.", "已請求刷新結構瀏覽器。"),
        ("Structure browser opened.", "結構瀏覽器已打開。"),
        ("Structure browser closed.", "結構瀏覽器已關閉。"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("Requested host spawn for '{0}' at {1} ({2})", "已請求主機在 {1}（{2}）生成「{0}」"),
        ("Spawned '{0}' at {1} ({2})", "已在 {1}（{2}）生成「{0}」"),
        ("Teleported to nearest '{0}' at {1} ({2:F1}m away).", "已傳送到最近的「{0}」，位於 {1}（距離 {2:F1} 米）。"),
        ("More Structures set to: {0}. (Changes apply on next generation/restart)", "更多結構已設為：{0}。（下次生成/重啟後生效）"),
        ("Reloaded {0} structures and {1} World layer files from disk.", "已從磁盤重新加載 {0} 個建築和 {1} 個世界層級文件。"),
        ("Structure spawn multiplier set to {0:F2}x. (e.g., 16 spawns -> ~{1} spawns, changes apply on next generation)", "建築生成倍率已設為 {0:F2}x。（例如：16 次生成 → 約 {1} 次，下次生成時生效）"),
        ("Signal '{0}' dispatched to {1} listener(s).", "信號「{0}」已派發給 {1} 個監聽器。"),
        ("dumpcontainercaps complete. found={0}, missing={1}", "dumpcontainercaps 完成。找到={0}，缺失={1}"),
        ("Disabled '{0}' by removing {1} file(s). Loaded structures: {2}.", "已通過移除 {1} 個文件禁用「{0}」。已加載建築：{2}。"),
        ("Showing {0} of {1} loaded structure(s).{2}", "正在顯示已加載的 {0}/{1} 個建築。{2}"),
        ("Catalog cache loaded: {0} entries. Scroll down or refresh for more.", "目錄緩存已加載：{0} 個條目。向下滾動或刷新查看更多。"),
        ("Catalog cache loaded: {0} entries.", "目錄緩存已加載：{0} 個條目。"),
    };
    public static readonly (string En, string Zh)[] Alerts =
    {
        ("Structure sync failed. Rejoin the host before continuing.", "結構同步失敗。請重新加入主機後再繼續。"),
        ("The host is not running.", "主機未在運行。"),
        ("The host world is not ready.", "主機的世界尚未就緒。"),
        ("Structure ID does not match its definition.", "結構 ID 與其定義不匹配。"),
        ("The host could not spawn the structure. See host log.", "主機無法生成該結構。請查看主機日誌。"),
        ("Host has sv_cheats or client commands disabled.", "主機已禁用 sv_cheats 或客戶端命令。"),
        ("Invalid More Structures spawn payload.", "無效的 More Structures 生成數據。"),
        ("More Structures command accepted.", "More Structures 命令已接受。"),
        ("More Structures command denied.", "More Structures 命令被拒絕。"),
    };
    public static readonly (string En, string Zh)[] AlertFormats =
    {
        ("Host spawned '{0}'.", "主機已生成「{0}」。"),
        ("Host could not register structure '{0}'.", "主機無法註冊結構「{0}」。"),
    };
    public static readonly (string En, string Zh)[] Literals =
    {
        ("Refreshing community catalog...", "正在刷新社區目錄..."),
        ("Searching...", "正在搜索..."),
        ("No cached matches yet. Search will keep loading more.", "暫無緩存匹配，搜索將繼續加載更多。"),
        ("No entries found. Refresh catalog or adjust search.", "未找到條目，請刷新目錄或調整搜索。"),
        ("No matches in the loaded catalog pages. Refine or clear the search to browse farther.", "已加載的目錄頁中沒有匹配項。請細化或清空搜索以繼續瀏覽。"),
        (" Scroll down for more.", " 向下滾動查看更多。"),
        ("Loading more community structures...", "正在加載更多社區結構..."),
        ("\n<color=grey>By ", "\n<color=grey>作者 "),
        ("Spawns ", "生成 "),
        ("Ready.", "就緒。"),
        ("Disable", "禁用"),
        ("Enable", "啟用"),
        ("Community browser ready.", "社區瀏覽器已就緒。"),
        ("Search name:, author:, id:, score>=, installed:, enabled:", "搜索 name:、author:、id:、score>=、installed:、enabled:"),
        ("Structure ID cannot be empty.", "建築 ID 不能為空。"),
        ("A structure download/install is already running.", "已有建築下載/安裝正在進行。"),
        ("Another structure disable operation is already running.", "已有建築禁用操作正在進行。"),
        ("A structure disable operation is already running.", "已有建築禁用操作正在進行。"),
        ("Catalog has not been loaded yet.", "目錄尚未加載。"),
        ("A catalog request is already running.", "已有目錄請求正在進行。"),
        ("All loaded catalog entries are already shown.", "所有已加載目錄條目均已顯示。"),
        ("A catalog refresh is already running.", "已有目錄刷新正在進行。"),
        ("Catalog refresh already running.", "目錄刷新已在運行。"),
        ("Remote catalog source reset to default (Firebase).", "遠程目錄源已重置為默認（Firebase）。"),
        ("Invalid URL. Use a full http/https URL.", "URL 無效，請使用完整的 http/https URL。"),
        ("Remote catalog source updated to: ", "遠程目錄源已更新為："),
        ("Untitled", "未命名"),
        ("Anonymous", "匿名"),
        ("Structure Browser", "結構瀏覽器"),
        ("Could not send host spawn request for '", "無法發送主機生成請求：'"),
        ("Structure browser failed to open for refresh. ", "建築瀏覽器無法打開以進行刷新。"),
        ("Structure browser closed or failed to open. ", "建築瀏覽器已關閉或無法打開。"),
        ("Disabling '", "正在禁用 '"),
        ("Installing '", "正在安裝 '"),
        ("No local downloaded files were found for '", "未找到 ' 的本地下載文件："),
        ("Failed disabling '", "禁用失敗：'"),
        ("Size {0}x{1}", "尺寸 {0}x{1}"),
        ("Objects {0}", "物體 {0}"),
        ("Items {0}", "物品 {0}"),
        ("<size=12><color=grey>Global Structure Multiplier ({0}, {1}/chunk)</color></size>", "<size=12><color=grey>全局結構倍率 ({0}, {1}/chunk)</color></size>"),
        ("Generating Custom Structures.. \n Acquiring data (", "正在生成自定義結構.. \n 正在獲取數據（"),
        (")\n\n", "）\n\n"),
        ("Generating Custom Structures.. \n Generating {0} ({1}/{2})\n\n", "正在生成自定義結構.. \n 正在生成 {0}（{1}/{2}）\n\n"),
        ("Generating Custom Structures.. \n {0} ({1}/{2})\n\n", "正在生成自定義結構.. \n {0}（{1}/{2}）\n\n"),
        ("checking host", "正在檢查主機"),
        ("host structures", "主機結構"),
        ("Custom Layer {0}", "自定義層級 {0}"),
        ("\n\nProperties: ", "\n\n屬性："),
    };
    public static readonly (string En, string Zh)[] CrystalPropertyNames =
    {
        ("Irradiated", "輻射"),
        ("Fragile", "脆弱"),
        ("Gravity", "重力扭曲"),
        ("Electric", "電擊"),
        ("Burning", "燃燒"),
        ("Temperature", "溫度"),
        ("Septic", "感染"),
        ("Unstable", "不穩定"),
        ("Mimic", "擬態"),
        ("Teleport", "位置錯亂"),
        ("Dripping", "融化"),
        ("Kinetic", "動能"),
        ("EMP", "電磁脈衝"),
        ("Blinding", "強光"),
        ("Metamorphic", "蛻變"),
        ("Healing", "治療"),
        ("Shy", "怯生"),
    };
    public static readonly (string En, string Zh)[] Settings =
    {
        ("Enable custom structures", "啟用自定義結構"),
        ("Whether to enable the Custom Structures mod during world generation. Requires a new game/layer to be loaded to take effect.", "是否在世界生成期間啟用自定義結構模組。需要加載新遊戲/新層級才能生效。"),
    };
    public static readonly (string En, string Zh)[] Ui =
    {
        ("Community Structure Browser", "社區結構瀏覽器"),
        ("Search by name or author...", "按名稱或作者搜索..."),
        ("Freq.", "頻率"),
        ("Refresh", "刷新"),
        ("Close", "關閉"),
        ("Exit", "退出"),
        ("Download", "下載"),
    };
}
