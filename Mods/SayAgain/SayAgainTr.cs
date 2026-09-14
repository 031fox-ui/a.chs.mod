internal static class SayAgainTr
{
    public static readonly (string En, string Zh)[] Moodles =
    {
        ("Ear Protection", "耳部防护"),
        ("Hearing is amplified. Some of what was lost is restored.", "听力被放大，部分失去的听力得到了恢复。"),
    };
    public static readonly (string En, string Zh)[] MoodleFormats =
    {
        ("Hearing is protected. Incoming noise damage reduced by {0}%. External sound is muffled while worn.", "听力受到保护，传入噪音的伤害降低 {0}%。佩戴期间外界声音会被闷住。"),
    };
    public static readonly (string En, string Zh)[] Commands =
    {
        ("Hearing protection test", "听力防护测试"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("no body", "角色不存在"),
        ("unknown item; try: expie give <id> or just 'hearing give'", "未知物品；试试：hearing give <id> 或直接输入 'hearing give'"),
        ("worn: nothing", "已穿戴：无"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("hearingLoss {0} (effective {1})   protection {2}%   muffle {3}", "听力损失 {0}（有效 {1}）   防护 {2}%   闷音 {3}"),
        ("hearingLoss {0}   protection {1}%   muffle none", "听力损失 {0}   防护 {1}%   闷音 无"),
        ("hearingLoss {0}   protection {1}%   muffle {2}", "听力损失 {0}   防护 {1}%   闷音 {2}"),
        ("hearingLoss now {0}", "听力损失现为 {0}"),
        ("spawned {0} item(s) at your feet", "已在你脚边生成 {0} 个物品"),
        ("worn: {0}", "已穿戴：{0}"),
    };
}
