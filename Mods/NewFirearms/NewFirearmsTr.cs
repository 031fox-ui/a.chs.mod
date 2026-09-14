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
    };
}
