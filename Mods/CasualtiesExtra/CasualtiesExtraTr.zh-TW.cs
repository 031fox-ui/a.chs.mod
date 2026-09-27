internal static class CasualtiesExtraTrTw
{
    public static readonly (string En, string Zh)[] Ui =
    {
        ("Milder/Stream Safe (Hides+disables extra-NSFW options)", "溫和／直播安全模式（隱藏並禁用額外的 NSFW 選項）"),
        ("Gameplay Tweaks", "玩法調整"),
        ("Speech Options", "語音選項"),
        ("Adjustments for how speaking is affected by weight and brainrot.", "調整體重與腦腐對說話方式的影響。"),
        ("Bloating Options", "脹氣選項"),
        ("Misc Options", "雜項選項"),
        ("Food Weight Gain Multiplier", "食物增重倍率"),
        ("Food Crate Spawn Rate", "食物箱生成率"),
        ("Weight Movement Penalty", "體重移動懲罰"),
        ("Weight Stamina Penalty", "體重耐力懲罰"),
        ("Cardiovascular Protection", "心血管保護"),
        ("Overheat Protection", "過熱保護"),
        ("Overfilled Sickness Protection", "過飽致病保護"),
        ("Weight Based Heart Attack Protection", "體重相關心臟病保護"),
        ("Immobility Stages", "無法行動階段"),
        ("Workouts Lose Weight", "鍛鍊減重"),
        ("Weight Based Hitboxes", "體重相關碰撞體"),
        ("Gluttony Mechanics", "暴食機制"),
        ("Extra gain while over capacity", "超容量時的額外增重"),
        ("Feeder Plants", "餵食植物"),
        ("Feeder Plants Spawn on All Floors", "餵食植物生成於所有樓層"),
        ("Weight Limits Minimum Happiness", "體重限制最低心情"),
        ("Weight Limits Maximum Consciousness", "體重限制最高意識"),
        ("Eating Happiness Bonus", "進食心情加成"),
        ("Weight Stage-related Dialogue", "體重階段相關臺詞"),
        ("Blobspeech Stuttering", "肉團語結巴"),
        ("Blobspeech Slurring", "肉團語含糊"),
        ("Blobspeech Heavy Breathing", "肉團語粗重喘息"),
        ("Blobspeech Moaning", "肉團語呻吟"),
        ("Whether the player might moan when talking at high brainrot.", "高腦腐時玩家說話是否會發出呻吟。"),
        ("Blobspeech Multiplier", "肉團語倍率"),
        ("How likely it is for blob speech effects to occur.", "肉團語效果發生的概率。"),
        ("Bloating", "脹氣"),
        ("Burping", "打嗝"),
        ("Farting", "放屁"),
        ("Burp SFX", "打嗝音效"),
        ("Fart SFX", "放屁音效"),
        ("Slosh SFX", "晃盪音效"),
        ("Gurgle SFX", "咕嚕音效"),
        ("Use Imperial Units", "使用英制單位"),
        ("Stomping SFX", "跺步音效"),
        ("Screen Shake Multiplier", "屏幕震動倍率"),
        ("Character: ", "角色："),
        ("Change the character you are playing as.", "更換你正在扮演的角色。"),
        ("Locale: ", "語言："),
    };
    public static readonly (string En, string Zh)[] Others =
    {
        ("XL Options", "XL 選項"),
        ("Open the XL Options menu.", "打開 XL 選項菜單。"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("<color=yellow>More bloating bar outline sprites than fill sprites.</color>", "<color=yellow>脹氣條的外框貼圖數量多於填充貼圖。</color>"),
        ("<color=yellow>More bloating bar fill sprites than outline sprites.</color>", "<color=yellow>脹氣條的填充貼圖數量多於外框貼圖。</color>"),
        ("<color=yellow>AudioManager not initialized yet, call AudioManager.Initialize() before trying to get audio clips.</color>", "<color=yellow>AudioManager 尚未初始化，獲取音頻片段前請先調用 AudioManager.Initialize()。</color>"),
        ("<color=yellow>RshLib assembly types could not be fully resolved via reflection.</color>", "<color=yellow>無法通過反射完整解析 RshLib 程序集中的類型。</color>"),
        ("<color=red>Tried to call DelayAction, but the event system is currently null!</color>", "<color=red>嘗試調用 DelayAction，但事件系統當前為 null！</color>"),
        ("<color=red>Failed to parse ClothesDefs.json!</color>", "<color=red>解析 ClothesDefs.json 失敗！</color>"),
        ("<color=red>Failed to load locale! Falling back to en.json.</color>", "<color=red>語言文件加載失敗！將回退至 en.json。</color>"),
        ("<color=red>Failed to find pause menu button in options menu prefab.</color>", "<color=red>在選項菜單預製體中找不到暫停菜單按鈕。</color>"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("<color=red>Field not found in ExpieData or LocalExpieData: {0}</color>", "<color=red>在 ExpieData 或 LocalExpieData 中找不到字段：{0}</color>"),
        ("<color=red>Failed to load Harmony Patches: {0}</color>", "<color=red>Harmony 補丁加載失敗：{0}</color>"),
        ("<color=red>Audio folder is empty or does not exist: {0}</color>", "<color=red>音頻文件夾為空或不存在：{0}</color>"),
        ("<color=red>Failed to load sprite or fallback for item {0}.</color>", "<color=red>物品 {0} 的貼圖與備用貼圖均加載失敗。</color>"),
        ("<color=red>Failed to parse ClothesDefs.json: {0}</color>", "<color=red>解析 ClothesDefs.json 失敗：{0}</color>"),
        ("<color=red>Failed to initialize RshLib reflection: {0}</color>", "<color=red>RshLib 反射初始化失敗：{0}</color>"),
        ("<color=red>Failed to resolve RshLib sprite {0} via reflection: {1}</color>", "<color=red>通過反射解析 RshLib 貼圖 {0} 失敗：{1}</color>"),
        ("<color=red>Locale file not found: {0}</color>", "<color=red>找不到語言文件：{0}</color>"),
        ("<color=red>Invalid key found: {0}</color>", "<color=red>發現無效鍵：{0}</color>"),
        ("<color=red>Failed to save config file: {0}</color>", "<color=red>保存配置文件失敗：{0}</color>"),
        ("<color=yellow>Audio clip not found: {0}\\{1}</color>", "<color=yellow>找不到音頻片段：{0}\\{1}</color>"),
        ("<color=yellow>File at {0} is of type .oga, this is not recommended for Vorbis files according to the Xiph.org standard. Use .ogg instead.</color>", "<color=yellow>{0} 的文件類型為 .oga，按 Xiph.org 標準並不推薦用於 Vorbis 文件。請改用 .ogg。</color>"),
        ("<color=yellow>ClothesDefs.json not found at {0}, using default ClothesDefs.json</color>", "<color=yellow>在 {0} 找不到 ClothesDefs.json，改用默認的 ClothesDefs.json</color>"),
        ("<color=yellow>Locale {0} is out of date and missing item localizations. Falling back to en.json for items.</color>", "<color=yellow>語言 {0} 已過期且缺少物品本地化。物品將回退至 en.json。</color>"),
        ("<color=yellow>Failed to load locale {0} from {1} with error: {2}</color>", "<color=yellow>從 {1} 加載語言 {0} 失敗，錯誤：{2}</color>"),
        ("<color=yellow>Couldn't load sprite asset for character {0} from path {1}. Falling back to default.</color>", "<color=yellow>無法從路徑 {1} 加載角色 {0} 的貼圖資源。將回退至默認值。</color>"),
    };
    public static readonly (string En, string Zh)[] CommandDescs =
    {
        ("Sets a variable in the C:XL data class.", "【XL】設置 C:XL 數據類中的變量。"),
        ("The field you want to set", "你想設置的字段"),
        ("Value to set the field to", "要寫入該字段的值"),
    };
}
