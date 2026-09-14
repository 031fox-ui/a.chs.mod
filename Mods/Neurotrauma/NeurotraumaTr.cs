using A.Multi_Mod.Chinese.Localization.Core;
namespace A.Multi_Mod.Chinese.Localization.Mods.Neurotrauma;
internal static class NeurotraumaTr
{
    public static readonly (string En, string Zh)[] Commands =
    {
        ("Neurotrauma: list afflictions on target. Usage: nt_list [player].", "【神经创伤】列出目标身上的症状。用法 : nt_list [玩家名]"),
        ("Neurotrauma: add affliction severity. Usage: nt_add <id> [amount=50] [player] [#limb].", "【神经创伤】增加症状严重度。用法 : nt_add <ID> [数值=50] [玩家名] [肢体]"),
        ("Neurotrauma: set affliction severity. Usage: nt_set <id> <amount> [player] [#limb].", "【神经创伤】设置症状严重度。用法 : nt_set <ID> <数值> [玩家名] [肢体]"),
        ("Neurotrauma: clear affliction(s). Usage: nt_clear [id] [player] [#limb].", "【神经创伤】清除症状。用法 : nt_clear [ID] [玩家名] [肢体]"),
        ("Neurotrauma: print target/netid diagnostics. Usage: nt_diag [player].", "【神经创伤】打印目标/网络ID诊断信息。用法 : nt_diag [玩家名]"),
        ("Neurotrauma: list body parts (limb indices) of the target. Usage: nt_limbs [player].", "【神经创伤】列出目标的身体部位（肢体索引）。用法 : nt_limbs [玩家名]"),
        ("Neurotrauma: show or set your blood type. Usage: nt_bloodtype [A+|B+|O+|AB+|…|random].", "【神经创伤】显示或设置血型。用法 : nt_bloodtype [A+|B+|O+|AB+|…|random]"),
        ("id", "ID"),
        ("amount", "数值"),
        ("type", "类型"),
        ("#limb", "#肢体"),
        ("optional MP player name", "（可选）多人玩家名称"),
        ("optional MP player name or @a", "（可选）多人玩家名称或 @a"),
        ("0..100, default 50", "0..100（默认 50）"),
        ("0..100", "0..100"),
        ("affliction id", "症状ID"),
        ("affliction id (omit to clear all)", "症状ID（省略以清除全部）"),
        ("optional body part: #sel, #head, #lower, #lhand, #lfoot, #<index>...", "（可选）身体部位 : #sel选定、#head头、#lower下身、#lhand左手、#lfoot左脚、#<索引>..."),
        ("optional body part", "（可选）身体部位"),
        ("blood type (A+, O-, …) or random; omit to print current", "血型（A+、O- 等）或 random；省略以显示当前血型"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Only the host can change afflictions while HostAuthoritative is on.", "主机权威开启时，只有主机能更改病症。"),
        ("Cheats are disabled (enable sv_cheats in lobby rules)", "作弊已禁用（在大厅规则中启用 sv_cheats）"),
        ("No target body.", "未找到目标身体。"),
        ("No affliction state.", "没有病症状态。"),
        ("No living players.", "没有存活的玩家。"),
        ("Player/body not found.", "未找到玩家/身体。"),
        ("usage: nt_add <id> [amount=50] [player] [#limb]", "用法 : nt_add <id> [数值=50] [玩家] [#肢体]"),
        ("usage: nt_set <id> <amount> [player] [#limb]", "用法 : nt_set <id> <数值> [玩家] [#肢体]"),
        ("amount must be a number.", "数值必须是数字。"),
        ("no limbs on body", "身体上没有肢体"),
        ("empty limb token", "空的肢体标记"),
        ("no limb selected in heal view (open UNI-HEALTH and hover a body part)", "治疗界面中未选择肢体（打开 UNI-HEALTH 并悬停身体部位）"),
        ("sv_cheats required", "需要 sv_cheats"),
        ("cleared ALL afflictions", "已清除所有病症"),
        ("no local body.", "没有本地身体。"),
        ("blood type rerolled → {0}", "血型已重掷 → {0}"),
        ("blood type set → {0}", "血型已设置 → {0}"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("Player/body not found for '{0}'. Online: {1}", "未找到玩家/身体「{0}」。在线 : {1}"),
        ("limb index {0} out of range (0..{1})", "肢体索引 {0} 超出范围（0..{1}）"),
        ("no limb matches '#{0}' (try nt_limbs)", "没有与「#{0}」匹配的肢体（试试 nt_limbs）"),
        ("cleared '{0}'", "已清除「{0}」"),
        ("unknown affliction '{0}'. Try nt_list.", "未知病症「{0}」。试试 nt_list。"),
        ("Registered afflictions ({0}):", "已注册病症（{0}） : "),
        ("blood type: {0}  (set with nt_bloodtype A+|B+|O+|AB+|… or nt_bloodtype random)", "血型 : {0}（用 nt_bloodtype A+|B+|O+|AB+|… 或 nt_bloodtype random 设置）"),
        ("unknown blood type '{0}'. Use: {1}, or random.", "未知血型「{0}」。可用 : {1} 或 random。"),
        ("skip {0}: netId=0", "跳过 {0} : netId=0"),
        ("{0}  (target={1}, netId={2}){3}", "{0}（目标={1}，netId={2}）{3}"),
    };
    public static readonly (string En, string Zh)[] Ui =
    {
        ("Open the mod page on Nexus Mods", "在Ｎ网上打开模组页面"),
        ("Open the mod releases page on GitHub", "打开 GitHub 上的模组发布页面"),
    };
    public static readonly (string En, string Zh)[] Literals =
    {
        ("<b><color=#FFCC66>Update available</color>  <color=#9FB4C7>(Обновление)</color></b>", "<b><color=#FFCC66>发现新版本</color></b>"),
        (" is available.</color>", " 可用。</color>"),
        (" — доступна новая версия.)</color>", " 的新版本可用。）</color>"),
        ("<b><color=#FFFFFF>Update now?</color>  <color=#9FB4C7>(Обновить сейчас?)</color></b>", "<b><color=#FFFFFF>立即更新？</color></b>"),
        ("<color=#D0D0D0>Later (Позже)</color>", "<color=#D0D0D0>稍后</color>"),
        ("<color=#CDE8B5>Yes (Да)</color>", "<color=#CDE8B5>是</color>"),
    };
}
