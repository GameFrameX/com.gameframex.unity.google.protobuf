<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Google Protocol Buffers

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

protobuf-net 是一個基於契約的 .NET 程式碼序列化器，使用 Google 設計的 "protocol buffers" 序列化格式寫入資料。其 API 遵循典型的 .NET 模式（與 XmlSerializer、DataContractSerializer 等廣泛可比）。它適用於大多數撰寫標準型別並可以使用特性的 .NET 語言。

該庫主要服務於 `https://github.com/GameFrameX/GameFrameX` 專案作為子庫使用。

本套件提供了 `ProtobufMessageSerializer`，它是 `com.gameframex.unity.network` 中 `IMessageSerializer` 介面的實作。在 Unity 執行階段載入時，會透過 `MessageSerializerRegistry.RegisterGlobal()` 自動註冊為全域預設序列化器，無需修改任何程式碼即可實現向下相容。

## 特性

- **基於契約** - 使用 .NET 特性進行序列化契約定義
- **高效能** - 高效的二進位序列化格式
- **跨平台** - 適用於所有 .NET 平台
- **.NET 模式** - 遵循典型的 .NET 序列化模式
- **Unity Package 支援** - 新增了 Unity Package Manager 支援
- **IMessageSerializer 整合** - 實作了 `IMessageSerializer` 介面，支援網路套件的可插拔序列化
- **自動註冊** - 載入時自動註冊為全域預設序列化器（零配置向下相容）

## 快速開始

### 安裝

### 安裝

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.google.protobuf": "3.4.1"
  }
}
```

## 使用文檔

protobuf-net 使用文檔請造訪 [protobuf-net/protobuf-net](https://github.com/protobuf-net/protobuf-net)。

### 手動註冊序列化器

`ProtobufMessageSerializer` 會在載入時自動註冊。如果需要替換或手動註冊：

```csharp
// 手動註冊（例如在重設全域序列化器之後）
MessageSerializerRegistry.RegisterGlobal(new ProtobufMessageSerializer());

// 作為單通道覆蓋使用
var helper = new DefaultNetworkChannelHelper();
helper.SetChannelSerializer(new ProtobufMessageSerializer()); // 必須在 Initialize() 之前呼叫
```

## 更新日誌

詳見 [CHANGELOG.md](CHANGELOG.md)。


## 依賴

| 套件 | 說明 |
|------|------|
| `com.gameframex.unity.network` | 2.6.0 |

## 文檔與資源

- [官方文檔](https://gameframex.doc.alianblank.com)

## 社區與支援

- QQ群: 467608841 / 233840761
## 開源協議

詳見 [LICENSE.md](LICENSE.md) 檔案。
