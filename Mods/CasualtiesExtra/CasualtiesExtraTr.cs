internal static class CasualtiesExtraTr
{
    public static readonly (string En, string Zh)[] Ui =
    {
        ("Milder/Stream Safe (Hides+disables extra-NSFW options)", "温和／直播安全模式（隐藏并禁用额外的 NSFW 选项）"),
        ("Gameplay Tweaks", "玩法调整"),
        ("Speech Options", "语音选项"),
        ("Adjustments for how speaking is affected by weight and brainrot.", "调整体重与脑腐对说话方式的影响。"),
        ("Bloating Options", "胀气选项"),
        ("Misc Options", "杂项选项"),
        ("Food Weight Gain Multiplier", "食物增重倍率"),
        ("Food Crate Spawn Rate", "食物箱生成率"),
        ("Weight Movement Penalty", "体重移动惩罚"),
        ("Weight Stamina Penalty", "体重耐力惩罚"),
        ("Cardiovascular Protection", "心血管保护"),
        ("Overheat Protection", "过热保护"),
        ("Overfilled Sickness Protection", "过饱致病保护"),
        ("Weight Based Heart Attack Protection", "体重相关心脏病保护"),
        ("Immobility Stages", "无法行动阶段"),
        ("Workouts Lose Weight", "锻炼减重"),
        ("Weight Based Hitboxes", "体重相关碰撞体"),
        ("Gluttony Mechanics", "暴食机制"),
        ("Extra gain while over capacity", "超容量时的额外增重"),
        ("Feeder Plants", "喂食植物"),
        ("Feeder Plants Spawn on All Floors", "喂食植物生成于所有楼层"),
        ("Weight Limits Minimum Happiness", "体重限制最低心情"),
        ("Weight Limits Maximum Consciousness", "体重限制最高意识"),
        ("Eating Happiness Bonus", "进食心情加成"),
        ("Weight Stage-related Dialogue", "体重阶段相关台词"),
        ("Blobspeech Stuttering", "肉团语结巴"),
        ("Blobspeech Slurring", "肉团语含糊"),
        ("Blobspeech Heavy Breathing", "肉团语粗重喘息"),
        ("Blobspeech Moaning", "肉团语呻吟"),
        ("Whether the player might moan when talking at high brainrot.", "高脑腐时玩家说话是否会发出呻吟。"),
        ("Blobspeech Multiplier", "肉团语倍率"),
        ("How likely it is for blob speech effects to occur.", "肉团语效果发生的概率。"),
        ("Bloating", "胀气"),
        ("Burping", "打嗝"),
        ("Farting", "放屁"),
        ("Burp SFX", "打嗝音效"),
        ("Fart SFX", "放屁音效"),
        ("Slosh SFX", "晃荡音效"),
        ("Gurgle SFX", "咕噜音效"),
        ("Use Imperial Units", "使用英制单位"),
        ("Stomping SFX", "跺步音效"),
        ("Screen Shake Multiplier", "屏幕震动倍率"),
        ("Character: ", "角色："),
        ("Change the character you are playing as.", "更换你正在扮演的角色。"),
        ("Locale: ", "语言："),
    };
    public static readonly (string En, string Zh)[] Others =
    {
        ("XL Options", "XL 选项"),
        ("Open the XL Options menu.", "打开 XL 选项菜单。"),
    };
    public static readonly (string En, string Zh)[] Logs =
    {
        ("<color=yellow>More bloating bar outline sprites than fill sprites.</color>", "<color=yellow>胀气条的外框贴图数量多于填充贴图。</color>"),
        ("<color=yellow>More bloating bar fill sprites than outline sprites.</color>", "<color=yellow>胀气条的填充贴图数量多于外框贴图。</color>"),
        ("<color=yellow>AudioManager not initialized yet, call AudioManager.Initialize() before trying to get audio clips.</color>", "<color=yellow>AudioManager 尚未初始化，获取音频片段前请先调用 AudioManager.Initialize()。</color>"),
        ("<color=yellow>RshLib assembly types could not be fully resolved via reflection.</color>", "<color=yellow>无法通过反射完整解析 RshLib 程序集中的类型。</color>"),
        ("<color=red>Tried to call DelayAction, but the event system is currently null!</color>", "<color=red>尝试调用 DelayAction，但事件系统当前为 null！</color>"),
        ("<color=red>Failed to parse ClothesDefs.json!</color>", "<color=red>解析 ClothesDefs.json 失败！</color>"),
        ("<color=red>Failed to load locale! Falling back to en.json.</color>", "<color=red>语言文件加载失败！将回退至 en.json。</color>"),
        ("<color=red>Failed to find pause menu button in options menu prefab.</color>", "<color=red>在选项菜单预制体中找不到暂停菜单按钮。</color>"),
    };
    public static readonly (string En, string Zh)[] LogFormats =
    {
        ("<color=red>Field not found in ExpieData or LocalExpieData: {0}</color>", "<color=red>在 ExpieData 或 LocalExpieData 中找不到字段：{0}</color>"),
        ("<color=red>Failed to load Harmony Patches: {0}</color>", "<color=red>Harmony 补丁加载失败：{0}</color>"),
        ("<color=red>Audio folder is empty or does not exist: {0}</color>", "<color=red>音频文件夹为空或不存在：{0}</color>"),
        ("<color=red>Failed to load sprite or fallback for item {0}.</color>", "<color=red>物品 {0} 的贴图与备用贴图均加载失败。</color>"),
        ("<color=red>Failed to parse ClothesDefs.json: {0}</color>", "<color=red>解析 ClothesDefs.json 失败：{0}</color>"),
        ("<color=red>Failed to initialize RshLib reflection: {0}</color>", "<color=red>RshLib 反射初始化失败：{0}</color>"),
        ("<color=red>Failed to resolve RshLib sprite {0} via reflection: {1}</color>", "<color=red>通过反射解析 RshLib 贴图 {0} 失败：{1}</color>"),
        ("<color=red>Locale file not found: {0}</color>", "<color=red>找不到语言文件：{0}</color>"),
        ("<color=red>Invalid key found: {0}</color>", "<color=red>发现无效键：{0}</color>"),
        ("<color=red>Failed to save config file: {0}</color>", "<color=red>保存配置文件失败：{0}</color>"),
        ("<color=yellow>Audio clip not found: {0}\\{1}</color>", "<color=yellow>找不到音频片段：{0}\\{1}</color>"),
        ("<color=yellow>File at {0} is of type .oga, this is not recommended for Vorbis files according to the Xiph.org standard. Use .ogg instead.</color>", "<color=yellow>{0} 的文件类型为 .oga，按 Xiph.org 标准并不推荐用于 Vorbis 文件。请改用 .ogg。</color>"),
        ("<color=yellow>ClothesDefs.json not found at {0}, using default ClothesDefs.json</color>", "<color=yellow>在 {0} 找不到 ClothesDefs.json，改用默认的 ClothesDefs.json</color>"),
        ("<color=yellow>Locale {0} is out of date and missing item localizations. Falling back to en.json for items.</color>", "<color=yellow>语言 {0} 已过期且缺少物品本地化。物品将回退至 en.json。</color>"),
        ("<color=yellow>Failed to load locale {0} from {1} with error: {2}</color>", "<color=yellow>从 {1} 加载语言 {0} 失败，错误：{2}</color>"),
        ("<color=yellow>Couldn't load sprite asset for character {0} from path {1}. Falling back to default.</color>", "<color=yellow>无法从路径 {1} 加载角色 {0} 的贴图资源。将回退至默认值。</color>"),
    };
    public static readonly (string En, string Zh)[] CommandDescs =
    {
        ("Sets a variable in the C:XL data class.", "【XL】设置 C:XL 数据类中的变量。"),
        ("The field you want to set", "你想设置的字段"),
        ("Value to set the field to", "要写入该字段的值"),
    };
}
