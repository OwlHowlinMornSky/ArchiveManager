# ArchiveManager

帮助管理资料副本的简单程序

## 已存档 Archived

### 原因 Reason

感觉……不如 [FreeFileSync](https://freefilesync.org/) ……。

## 作用

可以建立多个 `仓库` ，每个仓库都可以一键将 一个`领流(Leader Stream)` 的变动覆写到 另外数个`随流(Follower Streams)` 。

可以用作简单的本地冗余备份，例如：

- 将放置在 SSD 的工作文件夹设为 `领流` ，同时在 HDD 里设置一个 `随流` ，从而降低 SSD 损失数据的风险。
- ~~还可以把 `随流` 放在移动介质，快捷携带数据。~~（尚未实现）

