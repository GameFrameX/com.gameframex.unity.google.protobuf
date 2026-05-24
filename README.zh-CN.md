<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Google Protocol Buffers

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

  [文档](https://gameframex.doc.alianblank.com) | [快速开始](#快速开始)

  [English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## 项目简介

protobuf-net 是一个基于契约的 .NET 代码序列化器，使用 Google 设计的 "protocol buffers" 序列化格式写入数据。其 API 遵循典型的 .NET 模式（与 XmlSerializer、DataContractSerializer 等广泛可比）。它适用于大多数编写标准类型并可以使用特性的 .NET 语言。

该库主要服务于 `https://github.com/GameFrameX/GameFrameX` 项目作为子库使用。

## 特性

- **基于契约** - 使用 .NET 特性进行序列化契约定义
- **高性能** - 高效的二进制序列化格式
- **跨平台** - 适用于所有 .NET 平台
- **.NET 模式** - 遵循典型的 .NET 序列化模式
- **Unity Package 支持** - 添加了 Unity Package Manager 支持

## 安装

### 通过 Git URL 安装（推荐）

1. 在 Unity 编辑器中打开 Package Manager
2. 点击 "+" 按钮选择 "Add package from git URL"
3. 输入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git
   ```

### 通过 manifest.json 安装

在项目的 `Packages/manifest.json` 文件中添加：

```json
{
  "dependencies": {
    "com.gameframex.unity.google.protobuf": "https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git"
  }
}
```

### 手动安装

1. 下载最新版本发布包
2. 解压到项目的 `Packages` 目录下
3. Unity 会自动识别并加载包

## 使用文档

protobuf-net 使用文档请访问 [protobuf-net/protobuf-net](https://github.com/protobuf-net/protobuf-net)。

## 更新日志

详见 [CHANGELOG.md](CHANGELOG.md)。

## 开源协议

本项目基于 MIT 协议开源，详见 [LICENSE.md](LICENSE.md)。
