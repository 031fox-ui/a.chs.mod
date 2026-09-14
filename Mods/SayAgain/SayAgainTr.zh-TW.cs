internal static class SayAgainTrTw
{
    public static readonly (string En, string Zh)[] Moodles =
    {
        ("Ear Protection", "耳部防護"),
        ("Hearing is amplified. Some of what was lost is restored.", "聽力被放大，部分失去的聽力得到了恢復。"),
    };
    public static readonly (string En, string Zh)[] MoodleFormats =
    {
        ("Hearing is protected. Incoming noise damage reduced by {0}%. External sound is muffled while worn.", "聽力受到保護，傳入噪音的傷害降低 {0}%。佩戴期間外界聲音會被悶住。"),
    };
    public static readonly (string En, string Zh)[] Commands =
    {
        ("Hearing protection test", "聽力防護測試"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("no body", "角色不存在"),
        ("unknown item; try: expie give <id> or just 'hearing give'", "未知物品；試試：hearing give <id> 或直接輸入 'hearing give'"),
        ("worn: nothing", "已穿戴：無"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("hearingLoss {0} (effective {1})   protection {2}%   muffle {3}", "聽力損失 {0}（有效 {1}）   防護 {2}%   悶音 {3}"),
        ("hearingLoss {0}   protection {1}%   muffle none", "聽力損失 {0}   防護 {1}%   悶音 無"),
        ("hearingLoss {0}   protection {1}%   muffle {2}", "聽力損失 {0}   防護 {1}%   悶音 {2}"),
        ("hearingLoss now {0}", "聽力損失現為 {0}"),
        ("spawned {0} item(s) at your feet", "已在你腳邊生成 {0} 個物品"),
        ("worn: {0}", "已穿戴：{0}"),
    };
}
