<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Google Protocol Buffers

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

  [文檔](https://gameframex.doc.alianblank.com) | [快速開始](#快速開始)

  [English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## 項目簡介

protobuf-net 是一個基於契約的 .NET 程式碼序列化器，使用 Google 設計的 "protocol buffers" 序列化格式寫入資料。其 API 遵循典型的 .NET 模式（與 XmlSerializer、DataContractSerializer 等廣泛可比）。它適用於大多數撰寫標準型別並可以使用特性的 .NET 語言。

該庫主要服務於 `https://github.com/GameFrameX/GameFrameX` 專案作為子庫使用。

## 特性

- **基於契約** - 使用 .NET 特性進行序列化契約定義
- **高效能** - 高效的二進位序列化格式
- **跨平台** - 適用於所有 .NET 平台
- **.NET 模式** - 遵循典型的 .NET 序列化模式
- **Unity Package 支援** - 新增了 Unity Package Manager 支援

## 安裝

### 透過 Git URL 安裝（推薦）

1. 在 Unity 編輯器中開啟 Package Manager
2. 點擊 "+" 按鈕選擇 "Add package from git URL"
3. 輸入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git
   ```

### 透過 manifest.json 安裝

在專案的 `Packages/manifest.json` 檔案中新增：

```json
{
  "dependencies": {
    "com.gameframex.unity.google.protobuf": "https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git"
  }
}
```

### 手動安裝

1. 下載最新版本發佈包
2. 解壓縮到專案的 `Packages` 目錄下
3. Unity 會自動辨識並載入包

## 使用文檔

protobuf-net 使用文檔請造訪 [protobuf-net/protobuf-net](https://github.com/protobuf-net/protobuf-net)。

## 更新日誌

詳見 [CHANGELOG.md](CHANGELOG.md)。

## 開源協議

本專案基於 MIT 協議開源，詳見 [LICENSE.md](LICENSE.md)。
