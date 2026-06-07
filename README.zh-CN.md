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

## 快速开始

### 安装

选择以下任一方式：

1. 编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.google.protobuf": "3.4.1"
     }
   }
   ```

   `scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

2. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：
   ```json
   {
      "com.gameframex.unity.google.protobuf": "https://github.com/gameframex/com.gameframex.unity.google.protobuf.git"
   }
   ```
3. 在 Unity 的 `Package Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/gameframex/com.gameframex.unity.google.protobuf.git`
4. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。
### 安装

编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

```json
{
  "scopedRegistries": [
    {
      "name": "GameFrameX",
      "url": "https://gameframex.upm.alianblank.uk",
      "scopes": [
        "com.gameframex"
      ]
    }
  ]
}
```

`scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.google.protobuf": "3.4.1"
  }
}
```

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


## 依赖

| 包 | 说明 |
|----|------|
| `com.gameframex.unity.network` | 2.6.0 |

## 文档与资源

- [官方文档](https://gameframex.doc.alianblank.com)

## 社区与支持

- QQ群: 467608841 / 233840761
## 开源协议

详见 [LICENSE.md](LICENSE.md) 文件。
