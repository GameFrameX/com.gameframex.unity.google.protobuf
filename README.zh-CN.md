<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Google Protocol Buffers

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 项目简介

protobuf-net 是一个基于契约的 .NET 代码序列化器，使用 Google 设计的 "protocol buffers" 序列化格式写入数据。其 API 遵循典型的 .NET 模式（与 XmlSerializer、DataContractSerializer 等广泛可比）。它适用于大多数编写标准类型并可以使用特性的 .NET 语言。

该库主要服务于 `https://github.com/GameFrameX/GameFrameX` 项目作为子库使用。

本包提供了 `ProtobufMessageSerializer`，它是 `com.gameframex.unity.network` 中 `IMessageSerializer` 接口的实现。在 Unity 运行时加载时，会通过 `MessageSerializerRegistry.RegisterGlobal()` 自动注册为全局默认序列化器，无需修改任何代码即可实现向后兼容。

## 特性

- **基于契约** - 使用 .NET 特性进行序列化契约定义
- **高性能** - 高效的二进制序列化格式
- **跨平台** - 适用于所有 .NET 平台
- **.NET 模式** - 遵循典型的 .NET 序列化模式
- **Unity Package 支持** - 添加了 Unity Package Manager 支持
- **IMessageSerializer 集成** - 实现了 `IMessageSerializer` 接口，支持网络包的可插拔序列化
- **自动注册** - 加载时自动注册为全局默认序列化器（零配置向后兼容）

## 安装

> **注意：** 本包依赖于 `com.gameframex.unity.network`（>= 2.5.1），该包提供了 `IMessageSerializer` 接口。Unity Package Manager 会自动解析此依赖。

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

### 手动注册序列化器

`ProtobufMessageSerializer` 会在加载时自动注册。如果需要替换或手动注册：

```csharp
// 手动注册（例如在重置全局序列化器之后）
MessageSerializerRegistry.RegisterGlobal(new ProtobufMessageSerializer());

// 作为单通道覆盖使用
var helper = new DefaultNetworkChannelHelper();
helper.SetChannelSerializer(new ProtobufMessageSerializer()); // 必须在 Initialize() 之前调用
```

## 更新日志

详见 [CHANGELOG.md](CHANGELOG.md)。

## 开源协议

本项目基于 MIT 协议开源，详见 [LICENSE.md](LICENSE.md)。
