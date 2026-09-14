internal static class NeurotraumaTrTw
{
    public static readonly (string En, string Zh)[] Commands =
    {
        ("Neurotrauma: list afflictions on target. Usage: nt_list [player].", "【神經創傷】列出目標身上的症狀。用法 : nt_list [玩家名]"),
        ("Neurotrauma: add affliction severity. Usage: nt_add <id> [amount=50] [player] [#limb].", "【神經創傷】增加症狀嚴重度。用法 : nt_add <ID> [數值=50] [玩家名] [肢體]"),
        ("Neurotrauma: set affliction severity. Usage: nt_set <id> <amount> [player] [#limb].", "【神經創傷】設置症狀嚴重度。用法 : nt_set <ID> <數值> [玩家名] [肢體]"),
        ("Neurotrauma: clear affliction(s). Usage: nt_clear [id] [player] [#limb].", "【神經創傷】清除症狀。用法 : nt_clear [ID] [玩家名] [肢體]"),
        ("Neurotrauma: print target/netid diagnostics. Usage: nt_diag [player].", "【神經創傷】打印目標/網絡ID診斷信息。用法 : nt_diag [玩家名]"),
        ("Neurotrauma: list body parts (limb indices) of the target. Usage: nt_limbs [player].", "【神經創傷】列出目標的身體部位（肢體索引）。用法 : nt_limbs [玩家名]"),
        ("Neurotrauma: show or set your blood type. Usage: nt_bloodtype [A+|B+|O+|AB+|…|random].", "【神經創傷】顯示或設置血型。用法 : nt_bloodtype [A+|B+|O+|AB+|…|random]"),
        ("id", "ID"),
        ("amount", "數值"),
        ("type", "類型"),
        ("#limb", "#肢體"),
        ("optional MP player name", "（可選）多人玩家名稱"),
        ("optional MP player name or @a", "（可選）多人玩家名稱或 @a"),
        ("0..100, default 50", "0..100（默認 50）"),
        ("0..100", "0..100"),
        ("affliction id", "症狀ID"),
        ("affliction id (omit to clear all)", "症狀ID（省略以清除全部）"),
        ("optional body part: #sel, #head, #lower, #lhand, #lfoot, #<index>...", "（可選）身體部位 : #sel選定、#head頭、#lower下身、#lhand左手、#lfoot左腳、#<索引>..."),
        ("optional body part", "（可選）身體部位"),
        ("blood type (A+, O-, …) or random; omit to print current", "血型（A+、O- 等）或 random；省略以顯示當前血型"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Only the host can change afflictions while HostAuthoritative is on.", "主機權威開啟時，只有主機能更改病症。"),
        ("Cheats are disabled (enable sv_cheats in lobby rules)", "作弊已禁用（在大廳規則中啟用 sv_cheats）"),
        ("No target body.", "未找到目標身體。"),
        ("No affliction state.", "沒有病症狀態。"),
        ("No living players.", "沒有存活的玩家。"),
        ("Player/body not found.", "未找到玩家/身體。"),
        ("usage: nt_add <id> [amount=50] [player] [#limb]", "用法 : nt_add <id> [數值=50] [玩家] [#肢體]"),
        ("usage: nt_set <id> <amount> [player] [#limb]", "用法 : nt_set <id> <數值> [玩家] [#肢體]"),
        ("amount must be a number.", "數值必須是數字。"),
        ("no limbs on body", "身體上沒有肢體"),
        ("empty limb token", "空的肢體標記"),
        ("no limb selected in heal view (open UNI-HEALTH and hover a body part)", "治療界面中未選擇肢體（打開 UNI-HEALTH 並懸停身體部位）"),
        ("sv_cheats required", "需要 sv_cheats"),
        ("cleared ALL afflictions", "已清除所有病症"),
        ("no local body.", "沒有本地身體。"),
        ("blood type rerolled → {0}", "血型已重擲 → {0}"),
        ("blood type set → {0}", "血型已設置 → {0}"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("Player/body not found for '{0}'. Online: {1}", "未找到玩家/身體「{0}」。在線 : {1}"),
        ("limb index {0} out of range (0..{1})", "肢體索引 {0} 超出範圍（0..{1}）"),
        ("no limb matches '#{0}' (try nt_limbs)", "沒有與「#{0}」匹配的肢體（試試 nt_limbs）"),
        ("cleared '{0}'", "已清除「{0}」"),
        ("unknown affliction '{0}'. Try nt_list.", "未知病症「{0}」。試試 nt_list。"),
        ("Registered afflictions ({0}):", "已註冊病症（{0}） : "),
        ("blood type: {0}  (set with nt_bloodtype A+|B+|O+|AB+|… or nt_bloodtype random)", "血型 : {0}（用 nt_bloodtype A+|B+|O+|AB+|… 或 nt_bloodtype random 設置）"),
        ("unknown blood type '{0}'. Use: {1}, or random.", "未知血型「{0}」。可用 : {1} 或 random。"),
        ("skip {0}: netId=0", "跳過 {0} : netId=0"),
        ("{0}  (target={1}, netId={2}){3}", "{0}（目標={1}，netId={2}）{3}"),
    };
    public static readonly (string En, string Zh)[] Ui =
    {
        ("Open the mod page on Nexus Mods", "在Ｎ網上打開模組頁面"),
        ("Open the mod releases page on GitHub", "打開 GitHub 上的模組發佈頁面"),
    };
    public static readonly (string En, string Zh)[] Literals =
    {
        ("<b><color=#FFCC66>Update available</color>  <color=#9FB4C7>(Обновление)</color></b>", "<b><color=#FFCC66>發現新版本</color></b>"),
        (" is available.</color>", " 可用。</color>"),
        (" — доступна новая версия.)</color>", " 的新版本可用。）</color>"),
        ("<b><color=#FFFFFF>Update now?</color>  <color=#9FB4C7>(Обновить сейчас?)</color></b>", "<b><color=#FFFFFF>立即更新？</color></b>"),
        ("<color=#D0D0D0>Later (Позже)</color>", "<color=#D0D0D0>稍後</color>"),
        ("<color=#CDE8B5>Yes (Да)</color>", "<color=#CDE8B5>是</color>"),
    };
}
