# 多模组汉化 Mods Chinese Translation

一个“未知伤亡（Casualties Unknown）”的多模组汉化

> **当前版本 1.3.8**（1080 KB）· 已汉化 **41** 个模组 + 游戏本体

> **本仓库全由 AI 管理**：提交与 Release 都由 AI 完成；我很少查看 GitHub，有事请到 [N 网](https://www.nexusmods.com/games/scavprototype/mods/516) 或其他渠道联系我。

> [!NOTE]
> 本汉化为个人制作，非官方翻译。
>
> 　　本人早已不寻找模组汉化，你有什么模组想叫我汉化请直接向我提出，最好带链接。

[下载](#下载) · [安装](#安装) · [支持的模组](#支持的模组) · [设置项](#设置项) · [文本与翻译](#文本与翻译) · [注意事项](#注意事项) · [已知问题](#已知问题) · [更新日志](#更新日志)

## ！有什么想汉化的模组或文本错误，欢迎联系我

***

## 下载

| 渠道          | 链接                                                                                                           | 备注         |
| :---------- | :----------------------------------------------------------------------------------------------------------- | :--------- |
| **N 网**（推荐） | [Multi-Mod Chinese Localization](https://www.nexusmods.com/scavprototype/mods/516)                           | Nexus Mods |
| **GitHub**  | [直接下载压缩包](https://github.com/031fox-ui/a.chs.mod/releases/latest/download/Mods.Chinese.Translation.1.3.8.zip) | 比较吃网络      |
| **蓝奏云**     | [蓝奏云下载](https://wwann.lanzout.com/irwyq4fq6uqd)                                                              | 密码：9urs    |

## 安装

下载得到的是**压缩包**（`.zip`），解压出 `多模组汉化.dll` 后放入游戏的 `Casualties Unknown\BepInEx\plugins` 文件夹即可（试玩版同理，换对应目录）。

> 所有渠道的压缩包内都是 `多模组汉化.dll`（与 Nexus / 蓝奏云一致）。若你之前装过旧版
> `Mods.Chinese.Translation.dll` 或 `A.Multi_Mod.Chinese.Localization.dll`，**请先删除旧文件再放新版**，
> 避免重复加载（BepInEx 会保留版本号更高的那份，日志里会有 `Skipping … because a newer version exists`）。
>
> GitHub 链接带版本号（与线上 `update.json` 的 `github` 字段一致），**每次发版都要同步改这里的版本号**。

## 支持的模组

支持 **41** 个被汉化模组（按模组名称 A–Z 排序）。**模组版本**：为汉化时使用的版本；**翻译版本**：为本汉化模组一侧的更新版本。

| 汉化模组                                                                             | 模组版本         | 翻译版本     |
| :----------------------------------------------------------------------------------- | :--------------- | :----------- |
| [Alexx's Medical Brutalism](https://www.nexusmods.com/scavprototype/mods/452)        | 5.9.11           | 1.3.8        |
| [Alexx\_'s Mod Manager](https://www.nexusmods.com/scavprototype/mods/31)             | 1.1.12           | 1.2.7        |
| [Auto's Arsenal](https://www.nexusmods.com/scavprototype/mods/81)                    | 2.1.1            | 1.1.0        |
| [Better Crafting Logic](https://www.nexusmods.com/scavprototype/mods/344)            | 1.0.4            | 1.2.7        |
| [Casualties Consumed](https://example.com/)                                          | 1.3.0.0          | 1.2.7        |
| [Casualties Inside (Organs Mod)](https://www.nexusmods.com/scavprototype/mods/819)   | 0.19.15          | 1.2.7        |
| [Casualties Together](https://www.nexusmods.com/scavprototype/mods/67)               | 5.5.4            | 1.3.8        |
| [Casualties XL](https://example.com/)                                                | experimental-1   | 1.3.8        |
| [Casualty Psychology](https://www.nexusmods.com/scavprototype/mods/730)              | 0.8.3            | 1.3.8        |
| [Casualty Vitals](https://www.nexusmods.com/scavprototype/mods/388)                  | 1.5.4            | 1.2.7        |
| [CatPatch](https://www.nexusmods.com/scavprototype/mods/69)                          | 1.1.2            | 1.3.8        |
| [Comforts Unknown - Performance](https://www.nexusmods.com/scavprototype/mods/925)   | 0.1.4            | 1.3.8 新增   |
| [Crafting Tweaks](https://www.nexusmods.com/scavprototype/mods/370)                  | 0.3.4            | 1.2.7        |
| [CUCoreLib](https://www.nexusmods.com/scavprototype/mods/341)                        | 1.1              | 1.3.8        |
| [Custom Structures](https://www.nexusmods.com/scavprototype/mods/9)                  | 1.3.0            | 1.2.7        |
| [Exo-Suit MK1 Last Heartbeat](https://www.nexusmods.com/scavprototype/mods/844)      | 3.5.8            | 1.3.8 新增   |
| [Extra Medicaments](https://www.nexusmods.com/scavprototype/mods/448)                | 0.3              | 1.1.0        |
| [extraDialogues](https://www.nexusmods.com/scavprototype/mods/432)                   | 1.0.1            | 1.2.7        |
| [Gunsaw Genetics](https://www.nexusmods.com/scavprototype/mods/324)                  | 2.1.0            | 1.3.8        |
| [GunUI' New Firearms](https://www.nexusmods.com/scavprototype/mods/122)              | 2.0.2 + 1.0.2    | 1.3.8        |
| [Killer's Clothing and Armor](https://www.nexusmods.com/scavprototype/mods/59)       | —                | 1.3.8        |
| [Killer's Guns](https://www.nexusmods.com/scavprototype/mods/68)                     | —                | 1.1.0        |
| [Makeshift Prosthetics](https://www.nexusmods.com/scavprototype/mods/460)            | 1.0.2            | 1.3.8 新增   |
| [Mod Settings](https://www.nexusmods.com/scavprototype/mods/333)                     | 1.0.2.1          | 1.1.0        |
| [More Amputation](https://www.nexusmods.com/scavprototype/mods/407)                  | 0.4.2            | 1.2.5        |
| [Multiplayer Sprite Replacer](https://www.nexusmods.com/scavprototype/mods/74)       | 1.2.0            | 1.2.7        |
| [NeurotraumaModik](https://www.nexusmods.com/scavprototype/mods/440)                 | 2.4.1            | 1.2.7        |
| [New Clothing](https://www.nexusmods.com/scavprototype/mods/43)                      | 1.7.0            | 1.3.8        |
| [New Descents](https://www.nexusmods.com/scavprototype/mods/662)                     | 1.1.0            | 1.3.8        |
| [New Gun Loader (super beta)](https://www.nexusmods.com/scavprototype/mods/57)       | 2.0.1            | 1.1.0        |
| [Over The Top Realism](https://www.nexusmods.com/scavprototype/mods/330)             | 1.0.1            | 1.1.0        |
| [Performance Unknown](https://www.nexusmods.com/scavprototype/mods/342)              | 1.1.0            | 1.1.0        |
| [Pi's Food Overhaul](https://www.nexusmods.com/scavprototype/mods/560)               | 1.2              | 1.2.5        |
| [Prosthetics](https://www.nexusmods.com/scavprototype/mods/40)                       | 1.1.4            | 1.3.8        |
| [QoL Unknown](https://www.nexusmods.com/scavprototype/mods/7)                        | 1.1.5            | 1.3.8        |
| [Re-Growth Serums](https://www.nexusmods.com/scavprototype/mods/38)                  | 1.7.2            | 1.2.7        |
| [RshLib](https://www.nexusmods.com/scavprototype/mods/32)                            | 3.1.1            | 1.2.7        |
| [Say Again - hearing protection](https://www.nexusmods.com/scavprototype/mods/532)   | 0.1.1            | 1.1.0        |
| [ScavSetLib](https://www.nexusmods.com/scavprototype/mods/338)                       | 1.0.1            | 1.1.0        |
| [Simple QoL](https://www.nexusmods.com/scavprototype/mods/320)                       | 2.3.3            | 1.3.8        |
| [Thigh Highs](https://www.nexusmods.com/scavprototype/mods/33)                       | 3.0.1            | 1.1.0        |

## 设置项

配置文件：`BepInEx\config\Mods.Chinese.Translation.cfg`

### [General] 通用设置

| 设置 | 默认值 |
| :--- | :--- |
| 使用什么语言 | `auto` |
| 阻止 QoL Unknown 模组自带的字体 Fallback | 打开 |
| 阻止 QoL Unknown 向暂停菜单句子池注入 | 关闭 |
| 翻译 Together 改写后的窗口标题梗后缀 | 打开 |
| 输入指令提示换行 | 打开 |
| 跳过开屏内容警告 | 关闭 |

### [Mods] 各模组汉化开关

**可独立控制关闭哪个模组的翻译，默认全部开启。**

## 文本与翻译

模组提取出来的**原文 / 译文对照**就在本仓库里，按目录分：

| 范围       | 目录                                                                    | 内容             |
| :------- | :-------------------------------------------------------------------- | :------------- |
| **游戏本体** | [`Game/`](https://github.com/031fox-ui/a.chs.mod/tree/main/Game)      | 游戏自带文本、台词、界面   |
| **各模组**  | [`Mods/<模组>/`](https://github.com/031fox-ui/a.chs.mod/tree/main/Mods) | 每个模组一个目录，见下方结构 |

单个模组目录的结构（以 Say Again 为例）：

```text
Mods/SayAgain/
├── SayAgainTr.cs          简体译文表（编译进插件的嵌入翻译）
├── SayAgainTr.zh-TW.cs    繁体译文表（由简体自动转换）
└── Locales/
    ├── EN.json            英文原文对照
    ├── zh-CN.json         简体（游戏内 ID → 译文）
    └── zh-TW.json         繁体（由简体自动转换）
```

繁体中文使用 Python `opencc-python-reimplemented` 的 s2tw 转换，**未做校对**。

## 注意事项

**关于「阻止 QoL Unknown 模组自带的字体」这个设置**（建议读一下）：

发现 QoL 的 fallback 可以减轻游戏计算 unifont 字体的性能消耗，但是字体会变成 1.0 倍大小，游戏默认 1.3 倍——默认 1.3 倍对于中文阅读非常友好。如果其他模组字非常多，或你想看游戏剧情，推荐保持默认，这是游戏原汁原味的卡顿、原始的字体显示。

如果你想流畅些，可以前往 `BepInEx\config\Mods.Chinese.Translation.cfg` 关闭此设置。如果你安装了 [QoL Unknown](https://www.nexusmods.com/scavprototype/mods/7) 的话。

<details>
<summary>旧记录：第一次打开制作界面 / 鼠标指向物品时会小卡一下（点击展开）</summary>

~~！每次启动游戏，在游玩中，打开制作界面和鼠标指向物品等，第一次会小卡一下，自动建立缓存后不会小卡一下，关闭游戏后缓存清空~~　8月3日：我还以为是模组优化问题，结果去掉模组加载器也是这样：打开制作界面和鼠标指向物品等第一次显示文字也会卡顿。。。切换英文完全没这个卡顿，原来是游戏代码问题啊。 fallback 字体 unifont 问题，实际上在游戏中显示任何 fallback 字体都会卡顿，纯拼设备性能了

</details>

## 已知问题

暂无。

## 更新日志

| 版本        | 内容                                                                                                                                                                                                                                        |
| :-------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **1.3.8** | **新增 3 个模组汉化**：[Exo-Suit MK1 Last Heartbeat](https://www.nexusmods.com/scavprototype/mods/844)、[Makeshift Prosthetics](https://www.nexusmods.com/scavprototype/mods/460)、[Comforts Unknown: Performance](https://www.nexusmods.com/scavprototype/mods/925)。同步更新 14 个模组的翻译：Casualties Together 5.5.4、GunUI' New Firearms 2.0.2 + Gun Minigame 1.0.2、New Clothing 1.7.0、New Descents 1.1.0、Gunsaw Genetics 2.1.0、Casualty Psychology 0.8.3、CatPatch 1.1.2、QoL Unknown 1.1.5、Simple QoL 2.3.3、Prosthetics 1.1.4、Alexx's Medical Brutalism 5.9.11、CUCoreLib 1.1、Casualties XL、Killer's Clothing and Armor 等。**控制台**：长段提示自动换行、超长输出可滑动，新增「输入指令提示换行」开关（默认开）；**内容警告页**：新增「跳过开屏内容警告」开关（默认关）。按正式版官方字典统一 15 个概念、全项目标点统一为中文直引号。**修 bug**：更新说明面板只显示「已装版本 → 线上最新」之间的日志（此前会把历史版本全部列出） |
| **1.2.7** | **新增 2 个模组汉化**：Casualties Inside (Organs Mod)、Crafting Tweaks。**插件改名为「Mods.Chinese.Translation.dll」**，GUID 与命名空间变更，配置文件名变为 `Mods.Chinese.Translation.cfg`（旧配置不继承，设置需重调）。同步更新 24 个模组的翻译，其中 Medical Brutalism 跨大版本适配 v5.9.11（状况分级体系重写、新增 CO₂/O₃ 中毒等）；修复 Alexx's Mod Manager 主界面按钮在点击前保持英文的问题 |
| **1.2.5** | **新增 1 个模组汉化**：[More Amputation](https://www.nexusmods.com/scavprototype/mods/407)。更新翻译 12 个模组：CUCoreLib v1.0.6.1、Casualty Psychology v0.4.13、CatPatch v1.0.6、Custom Structures v1.2.5、Casualties Together v5.0.2、Medical Brutalism v4.7.10、Gunsaw Genetics v2.0.0、NeurotraumaModik v2.4.1、New Firearms v1.6.5、Pi's Food Overhaul v1.2、Prosthetics v1.0.5、QoL Unknown v1.0.5.0 |
| **1.2.4** | **新增 1 个模组汉化**：Casualty Psychology。**联机框架模组改名为 Together**，适配 Casualties Together v5.0.0；修复：窗口标题梗后缀翻译漏掉多数随机标题形态的问题；模组改名后旧配置键自动迁移，玩家设置不再重置。更新翻译 14 个模组：Casualties Together v5.0.0、Gunsaw Genetics v2.0.0、Medical Brutalism v4.6.9、New Firearms v1.6.5、CatPatch v1.0.4、CUCoreLib v1.0.6、Custom Structures v1.2.4、Casualty Vitals v1.5.4、RshLib v3.1.1、Simple QoL v13、Casualties Consumed v1.3.0.0、Alexx's Mod Manager v1.1.12、extraDialogues v1.0.1、QoL Unknown v1.0.4.8 |
| **1.1.0** | **更新弹窗新增更新说明**（模组本体更新内容 + 本次更新翻译的模组列表）。**新增 3 个模组汉化**：Casualties Consumed、Casualties XL、Pi's Food Overhaul。**重大更新：每个模组的汉化都有独立开关**（见上方[设置项](#设置项)）。更新翻译 Casualties Together v5.0.0、Prosthetics v1.0.4、Medical Brutalism v4.4.9、Casualty Vitals v1.5.3、Custom Structures v1.2.4、New Firearms v1.6.4、New Descents v1.0.3.2、Say Again v0.1.1；统一术语（废弃燃料、棕菌盖、地菱树等）；添加 QoL Unknown 的下载失败提示漏翻；新增 KrokMP 窗口标题梗后缀翻译（开关默认开） |
| **1.0.2** | **新增 2 个模组汉化**：Gunsaw Genetics、New Descents；更新翻译 Custom Structures v1.2.3、CUCoreLib v1.0.6、KrokMP、Medical Brutalism、New Firearms、Prosthetics、Simple QoL；统一术语（moodle→状态图标、抗性→韧性等）；修复 Simple QoL 误译与 Medical Brutalism 的 3 条俄语控制台漏翻 |
| **1.0.1** | 尝试修复多人联机中控制台自动补全不显示“玩家名字”和“@c 等”的问题。自己能正常显示，没测试别人名字是否显示                                                                                                                                                                                   |
| 更早        | 见 [Releases](https://github.com/031fox-ui/a.chs.mod/releases)                                                                                                                                                                             |
