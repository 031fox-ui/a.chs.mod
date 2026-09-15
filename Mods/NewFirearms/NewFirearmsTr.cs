internal static class NewFirearmsTr
{
    public static readonly (string En, string Zh)[] Talks =
    {
        ("Welcome to the firearm handling course", "欢迎来到枪械操作训练课程"),
        ("Starting off from treating firearms related injuries", "从治疗枪械相关损伤开始"),
    };
    public static readonly (string En, string Zh)[] CommandDescs =
    {
        ("You must have a loaded gun. Prevents last stand", "【新枪械】你必须有一把装好弹的枪。防止进入背水一战。"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("you dont have a gun. you are gonna suffer.", "你没有枪。你有得受了。"),
        ("Gun is not ready. Try remove safety?", "枪械未就绪。试试解除保险？"),
    };
    public static readonly (string En, string Zh)[] Alerts =
    {
        ("Denied gun suicide", "枪械自杀请求被拒绝"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("<color=yellow>Removing casing from magazine :hmm:; {0}", "<color=yellow>从弹匣取出弹壳 :hmm:; {0}"),
        ("[NewFirearms] Replace recipe at {0} for {1}", "[NewFirearms] 在位置 {0} 将配方替换为 {1}"),
        ("[NewFirearms] Added recipe at {0} for {1}", "[NewFirearms] 在位置 {0} 添加配方 : {1}"),
        ("<color=red>[NewFirearms] Unable to patch recipes! No replacment left.; {0}", "<color=red>[NewFirearms] 无法修补配方！无可用替换资源。; {0}"),
        ("<color=yellow>[GunMinigame] Target magazine doesnt implement IMinigameMag!; {0}", "<color=yellow>[GunMinigame] 目标弹匣未实现 IMinigameMag！; {0}"),
        ("<color=yellow>[GunMinigame] Expected item doesnt have a AmmoScript :tourniqet:; {0}", "<color=yellow>[GunMinigame] 目标物品没有 AmmoScript :tourniqet:; {0}"),
        ("<color=yellow>[GunMinigame-NewFirearms] Expected item doesnt have a RshMag :tourniqet:; {0}", "<color=yellow>[GunMinigame-NewFirearms] 目标物品没有 RshMag :tourniqet:; {0}"),
        ("<color=yellow>[NewFirearms] Magazine {0} doesnt have a ammo fillup for {1}; {2}", "<color=yellow>[NewFirearms] 弹匣 {0} 没有适用于 {1} 的弹药装填 ; {2}"),
        ("<color=red>[NewFirearms] Gunsaw Genetics integration failed! Send a bug report.; {0}", "<color=red>[NewFirearms] 与 Gunsaw Genetics 的集成失败！请提交错误报告。; {0}"),
    };
}
