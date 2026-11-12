internal static class GameReleaseTrTw
{
    public static readonly (string En, string Zh)[] Exact =
    {
        ("Deletes PlayerPrefs settings. This will delete all progress!", "刪除 PlayerPrefs 設置。這會刪除所有進度！"),
        ("Applies a specific modifier for the layer.", "為當前地層應用指定的地層隨機效果。"),
        ("Reattaches a dismembered limb.", "重新連接一條已被截斷的肢體。"),
        ("Spawns a chosen character.", "生成一個指定的角色。"),
        ("we are duned (This is permanent until you close the game!)", "我們被沙丘化了（關閉遊戲前永久生效！）"),
        ("Unlocks achievement.", "解鎖成就。"),
        ("Index of the modifier to apply", "要應用的地層隨機效果序號"),
        ("Where to spawn the character", "生成角色的位置"),
        ("Index of the character", "角色序號"),
        ("The dunepocalypse is already ongoing.", "沙丘末日正在持續。"),
        ("The dunepocalypse has begun. This is irreversible until the program is restarted.", "沙丘末日已經降臨。在重啟程序之前無法逆轉。"),
        ("Cannot save the game at WHERE WE MUST REACH and beyond!", "在「必 須 抵 達 之 地」及更深處無法保存遊戲！"),
        ("Welcome to the console! You can safely use any command in the sandbox. Press (~) to exit.", "歡迎來到控制檯！在沙盒中可以安全使用任何命令。按「~」退出。"),
        ("<color=#ff006a>WARNING: You used a cheat command. Achievements are disabled until you restart the game.</color>", "<color=#ff006a>警告：你使用了作弊命令。在重啟遊戲之前成就將被禁用。</color>"),
        ("<color=#ff006a>WARNING: This save was previously cheated. Achievements are disabled until you restart the game.</color>", "<color=#ff006a>警告：此存檔此前被作弊修改過。在重啟遊戲之前成就將被禁用。</color>"),
        ("Cannot find minibarrel on player..?", "在玩家身上找不到小型桶……？"),
    };
    public static readonly (string En, string Zh)[] ArgShort =
    {
        ("bool ignoreDismember", "真假 忽略斷肢"),
        ("int character", "整數 角色"),
        ("achievement", "成就"),
    };
    public static readonly (string En, string Zh)[] ArgLong =
    {
        ("If true, will not reattach dismembered limbs.", "若為 true，不會重新接上斷肢。"),
        ("achievement ID", "成就 ID"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("Can only amputate extremities!", "只能截斷末端肢體！"),
    };
    public static readonly (string En, string Zh)[] Formats =
    {
        ("Created \"{0}\" at {1}.", "已在 {1} 處創建「{0}」。"),
        ("There are only {0} modifiers available, index {1} is invalid!", "可用的地層隨機效果僅有 {0} 個，索引 {1} 無效！"),
    };
    public static readonly (string En, string Zh)[] ReleaseUi =
    {
        ("At the deciding moment", "決定性時刻"),
        ("<color=\"red\">Save is corrupted!", "<color=\"red\">存檔已損壞！"),
        ("   (ALMOST THERE)", "   （就快到了）"),
        ("   (RETURN--BASE)", "   （返回基地）"),
    };
    public static readonly (string En, string Zh)[] Credits =
    {
        ("A game by Orsoniks\n<size=20><color=#9999>hi! thank you for playing and supporting this project of mine.\nit started out as a small vent game around mid-2024 and it is amazing to see how far it has gotten since, with so many eyes looking at it.\ni hope it can mean to you as much as it does to me!!\n", "由 Orsoniks 製作的遊戲\n<size=20><color=#9999>嗨！感謝你遊玩並支持我的這個項目。\n它始於 2024 年年中一個用於宣洩情緒的小遊戲，看到它如今走到這一步、被這麼多人關注，真的非常驚人。\n希望它對你而言，也能像對我一樣意義非凡！！\n"),
        ("With non-pixel art by WickFlix\n<size=20><color=#9999>I found out about the game right at the start of 2025 and quickly felt enraptured by the atmosphere and themes, and ended up making tons of fanart in the community as an outlet for my appreciation of the project. Somewhere along the way I offered to help with art assets, and I've been working together with Moffee since! Seeing the game take shape and being there to help it along has been lovely, and I hope to carry on doing it <3", "非像素美術：WickFlix\n<size=20><color=#9999>我在 2025 年初發現了這款遊戲，很快就被它的氛圍和主題深深吸引，於是在社區裡畫了大量同人圖，作為我對這個項目喜愛的表達。後來我主動提出幫忙製作美術素材，從那時起就一直和 Moffee 合作！看著遊戲逐漸成形並參與其中，是一段非常美好的經歷，希望我能繼續下去 <3"),
        ("With menu art by Gatotacato<size=80%>", "菜單美術：Gatotacato<size=80%>"),
        ("With Steam art by miimows", "Steam 美術：miimows"),
        ("With other creative assistance from goip (Connor Marr)\n<size=20><color=#9999>I worked on the game in mostly 2025, previously just doing fanart until Orson took interest in my work. I prototyped art for the game such as for earlier iterations of the death screen, among giving feedback for general creative design among thematic / narrative stuff. It’s been a privilege to help bring the game’s vision to light, and I look forward to maybe helping in another someday.", "其他創意協助：goip（Connor Marr）\n<size=20><color=#9999>我主要在 2025 年參與這款遊戲的工作，此前只是畫同人圖，直到 Orson 對我的作品產生了興趣。我為遊戲做過美術原型，比如死亡畫面的早期版本，也在整體創意設計、主題與敘事方面提供反饋。能幫忙把這款遊戲的構想呈現出來是一種榮幸，也希望將來還有機會再出一份力。"),
        ("Thanks to everyone in the community who has followed along, shared thoughts, and supported the project along the way. Casualties: Unknown wouldn't be what it is without your support, and I'm grateful to have you.\n", "感謝社區裡一路關注、分享想法並支持這個項目的每一個人。《未知傷亡》沒有你們的支持就不會是今天這個樣子，很感激有你們。\n"),
        ("Bonus thanks:\n- JimmyKing for coding help\n- Pocky for support\n- Multiple friends for playtesting and plush sprites\n- Griff & the community for writing help", "特別感謝：\n- JimmyKing 提供編碼幫助\n- Pocky 的支持\n- 多位朋友參與試玩測試與玩偶貼圖製作\n- Griff 與社區提供文案幫助"),
    };
}
