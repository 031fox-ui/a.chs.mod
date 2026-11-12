internal static class GameReleaseTr
{
    public static readonly (string En, string Zh)[] Exact =
    {
        ("Deletes PlayerPrefs settings. This will delete all progress!", "删除 PlayerPrefs 设置。这会删除所有进度！"),
        ("Applies a specific modifier for the layer.", "为当前地层应用指定的地层随机效果。"),
        ("Reattaches a dismembered limb.", "重新连接一条已被截断的肢体。"),
        ("Spawns a chosen character.", "生成一个指定的角色。"),
        ("we are duned (This is permanent until you close the game!)", "我们被沙丘化了（关闭游戏前永久生效！）"),
        ("Unlocks achievement.", "解锁成就。"),
        ("Index of the modifier to apply", "要应用的地层随机效果序号"),
        ("Where to spawn the character", "生成角色的位置"),
        ("Index of the character", "角色序号"),
        ("The dunepocalypse is already ongoing.", "沙丘末日正在持续。"),
        ("The dunepocalypse has begun. This is irreversible until the program is restarted.", "沙丘末日已经降临。在重启程序之前无法逆转。"),
        ("Cannot save the game at WHERE WE MUST REACH and beyond!", "在「必 须 抵 达 之 地」及更深处无法保存游戏！"),
        ("Welcome to the console! You can safely use any command in the sandbox. Press (~) to exit.", "欢迎来到控制台！在沙盒中可以安全使用任何命令。按「~」退出。"),
        ("<color=#ff006a>WARNING: You used a cheat command. Achievements are disabled until you restart the game.</color>", "<color=#ff006a>警告：你使用了作弊命令。在重启游戏之前成就将被禁用。</color>"),
        ("<color=#ff006a>WARNING: This save was previously cheated. Achievements are disabled until you restart the game.</color>", "<color=#ff006a>警告：此存档此前被作弊修改过。在重启游戏之前成就将被禁用。</color>"),
        ("Cannot find minibarrel on player..?", "在玩家身上找不到小型桶……？"),
    };
    public static readonly (string En, string Zh)[] ArgShort =
    {
        ("bool ignoreDismember", "真假 忽略断肢"),
        ("int character", "整数 角色"),
        ("achievement", "成就"),
    };
    public static readonly (string En, string Zh)[] ArgLong =
    {
        ("If true, will not reattach dismembered limbs.", "若为 true，不会重新接上断肢。"),
        ("achievement ID", "成就 ID"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Can only amputate extremities!", "只能截断末端肢体！"),
    };
    public static readonly (string En, string Zh)[] Formats =
    {
        ("Created \"{0}\" at {1}.", "已在 {1} 处创建「{0}」。"),
        ("There are only {0} modifiers available, index {1} is invalid!", "可用的地层随机效果仅有 {0} 个，索引 {1} 无效！"),
    };
    public static readonly (string En, string Zh)[] ReleaseUi =
    {
        ("At the deciding moment", "决定性时刻"),
        ("<color=\"red\">Save is corrupted!", "<color=\"red\">存档已损坏！"),
        ("   (ALMOST THERE)", "   （就快到了）"),
        ("   (RETURN--BASE)", "   （返回基地）"),
    };
    public static readonly (string En, string Zh)[] Credits =
    {
        ("A game by Orsoniks\n<size=20><color=#9999>hi! thank you for playing and supporting this project of mine.\nit started out as a small vent game around mid-2024 and it is amazing to see how far it has gotten since, with so many eyes looking at it.\ni hope it can mean to you as much as it does to me!!\n", "由 Orsoniks 制作的游戏\n<size=20><color=#9999>嗨！感谢你游玩并支持我的这个项目。\n它始于 2024 年年中一个用于宣泄情绪的小游戏，看到它如今走到这一步、被这么多人关注，真的非常惊人。\n希望它对你而言，也能像对我一样意义非凡！！\n"),
        ("With non-pixel art by WickFlix\n<size=20><color=#9999>I found out about the game right at the start of 2025 and quickly felt enraptured by the atmosphere and themes, and ended up making tons of fanart in the community as an outlet for my appreciation of the project. Somewhere along the way I offered to help with art assets, and I've been working together with Moffee since! Seeing the game take shape and being there to help it along has been lovely, and I hope to carry on doing it <3", "非像素美术：WickFlix\n<size=20><color=#9999>我在 2025 年初发现了这款游戏，很快就被它的氛围和主题深深吸引，于是在社区里画了大量同人图，作为我对这个项目喜爱的表达。后来我主动提出帮忙制作美术素材，从那时起就一直和 Moffee 合作！看着游戏逐渐成形并参与其中，是一段非常美好的经历，希望我能继续下去 <3"),
        ("With menu art by Gatotacato<size=80%>", "菜单美术：Gatotacato<size=80%>"),
        ("With Steam art by miimows", "Steam 美术：miimows"),
        ("With other creative assistance from goip (Connor Marr)\n<size=20><color=#9999>I worked on the game in mostly 2025, previously just doing fanart until Orson took interest in my work. I prototyped art for the game such as for earlier iterations of the death screen, among giving feedback for general creative design among thematic / narrative stuff. It’s been a privilege to help bring the game’s vision to light, and I look forward to maybe helping in another someday.", "其他创意协助：goip（Connor Marr）\n<size=20><color=#9999>我主要在 2025 年参与这款游戏的工作，此前只是画同人图，直到 Orson 对我的作品产生了兴趣。我为游戏做过美术原型，比如死亡画面的早期版本，也在整体创意设计、主题与叙事方面提供反馈。能帮忙把这款游戏的构想呈现出来是一种荣幸，也希望将来还有机会再出一份力。"),
        ("Thanks to everyone in the community who has followed along, shared thoughts, and supported the project along the way. Casualties: Unknown wouldn't be what it is without your support, and I'm grateful to have you.\n", "感谢社区里一路关注、分享想法并支持这个项目的每一个人。《未知伤亡》没有你们的支持就不会是今天这个样子，很感激有你们。\n"),
        ("Bonus thanks:\n- JimmyKing for coding help\n- Pocky for support\n- Multiple friends for playtesting and plush sprites\n- Griff & the community for writing help", "特别感谢：\n- JimmyKing 提供编码帮助\n- Pocky 的支持\n- 多位朋友参与试玩测试与玩偶贴图制作\n- Griff 与社区提供文案帮助"),
    };
}
