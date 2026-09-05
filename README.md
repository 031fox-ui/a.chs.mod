# 多模组汉化 A.Multi-Mod.Chinese.Localization
一个“未知伤亡（Casualties Unknown）”的多模组汉化

[这边有此模组提取的文本、翻译：https://github.com/031fox-ui/a.chs.mod-translations](https://github.com/031fox-ui/a.chs.mod-translations)

直接把下载好的 .dll 文件放入游戏的“Casualties Unknown Demo\BepInEx\plugins”文件夹即可。

繁体中文使用 Python opencc-python-reimplemented s2tw 转换，未做校对

！有什么想汉化的模组或 文本错误欢迎联系我

~~！每次启动游戏，在游玩中，打开制作界面和鼠标指向物品等，第一次会小卡一下，自动建立缓存后不会小卡一下，关闭游戏后缓存清空，~~ 正在优化　8月3日：我还以为是模组优化问题，结果去掉模组加载器也是这样：打开制作界面和鼠标指向物品等第一次显示文字也会卡顿。。。切换英文完全没这个卡顿，原来是游戏代码问题啊。 fallback 字体 unifont 问题，实际上在游戏中显示任何 fallback 字体都会卡顿，纯拼设备性能了

---

检查更新：优先从 pages 托管获取更新，连接失败再从 github 获取更新；游戏中有 github、n网、蓝奏云三个分流下载按钮跳转。

！！注意“阻止 QoL Unknown 模组自带的字体”设置，发现 QoL 的 fallback 可以减轻游戏计算 unifont 字体的性能消耗，但是字体会变成 1.0 倍大小，游戏默认 1.3 倍，默认 1.3 倍对于中文阅读非常友好，如果其他模组字非常多，或你想看游戏剧情，推荐保持默认，这是游戏原汁原味的卡顿、原始的字体显示。如果你想流畅些，可以前往【BepInEx\config\A.Multi_Mod.Chinese.Localization.cfg】关闭此设置。

目前：1.0.1  852KB

[N网下载：Multi-Mod Chinese Localization](https://www.nexusmods.com/scavprototype/mods/516)

[蓝奏云下载](https://wwann.lanzout.com/iI38E46udwcd)　　密码：544i（先复制密码再点击链接

[GitHub 直接下载（比较吃网络）](https://github.com/031fox-ui/a.chs.mod/raw/refs/heads/main/A.Multi_Mod.Chinese.Localization.dll)

---

问题：

Simple QoL 模组有小错误翻译

Medical Brutalism 模组向控制台打印的这几个漏了：

Кнопка добавлена в меню (X=…, Y=…, W=…, H=…) 菜单按钮已添加（X=…, Y=…, W=…, H=…）

Панель меню не найдена. 未找到菜单面板。

Не найдена эталонная кнопка Radio/TutorialRadio. 未找到参考按钮 Radio/TutorialRadio。

下次更新修复。

更新日志：

1.0.1 版本

本模组有 3 个设置：

使用什么语言　　默认 auto

阻止 QoL Unknown 模组自带的字体 Fallback　　默认打开

阻止 QoL Unknown 向暂停菜单句子池注入　　默认关闭

.

支持 29 个被汉化模组（本模组内部命名字母顺序。数字为本模组的翻译版本更新）：

[Alexx_'s Mod Manager](https://www.nexusmods.com/scavprototype/mods/31)　1.0.0

[Auto's Arsenal](https://www.nexusmods.com/scavprototype/mods/81)　1.0.0

[Casualty Vitals](https://www.nexusmods.com/scavprototype/mods/388)　1.0.1

[CatPatch](https://www.nexusmods.com/scavprototype/mods/69)　1.0.0

[Better Crafting Logic](https://www.nexusmods.com/scavprototype/mods/344)　1.0.0

[CUCoreLib](https://www.nexusmods.com/scavprototype/mods/341)　1.0.0

[Mod Settings](https://www.nexusmods.com/scavprototype/mods/333)　1.0.0

[Custom Structures](https://www.nexusmods.com/scavprototype/mods/9)　1.0.0

[extraDialogues](https://www.nexusmods.com/scavprototype/mods/432)　1.0.0

[Extra Medicaments](https://www.nexusmods.com/scavprototype/mods/448)　1.0.0

[Killer's Clothing and Armor](https://www.nexusmods.com/scavprototype/mods/59)　1.0.0

[Killer's Guns](https://www.nexusmods.com/scavprototype/mods/68)　1.0.0

[Casualties Together](https://www.nexusmods.com/scavprototype/mods/67)　1.0.0　（请配合此模组使用：[KrokMP Chinese Supplement - Simplified Chinese Translation](https://www.nexusmods.com/scavprototype/mods/183)）

[Alexx_'s Medical Brutalism](https://www.nexusmods.com/scavprototype/mods/452)　1.0.1

[Multiplayer Sprite Replacer](https://www.nexusmods.com/scavprototype/mods/74)　1.0.0

[NeurotraumaModik](https://www.nexusmods.com/scavprototype/mods/440)　1.0.0

[New Clothing](https://www.nexusmods.com/scavprototype/mods/43)　1.0.0

[New Firearms](https://www.nexusmods.com/scavprototype/mods/122)　1.0.1

[New Gun Loader (super beta)](https://www.nexusmods.com/scavprototype/mods/57)　1.0.0

[Over The Top Realism](https://www.nexusmods.com/scavprototype/mods/330)　1.0.0

[Prosthetics](https://www.nexusmods.com/scavprototype/mods/40)　1.0.1

[QoL Unknown](https://www.nexusmods.com/scavprototype/mods/7)　1.0.0

[Re-Growth Serums](https://www.nexusmods.com/scavprototype/mods/38)　1.0.0

[RshLib](https://www.nexusmods.com/scavprototype/mods/32)　1.0.0

[Say Again - hearing protection](https://www.nexusmods.com/scavprototype/mods/532)　1.0.1

[ScavSetLib](https://www.nexusmods.com/scavprototype/mods/338)　1.0.0

[Simple QoL](https://www.nexusmods.com/scavprototype/mods/320)　1.0.1

[Thigh Highs](https://www.nexusmods.com/scavprototype/mods/33)　1.0.0

[Performance Unknown](https://www.nexusmods.com/scavprototype/mods/342)　1.0.0
