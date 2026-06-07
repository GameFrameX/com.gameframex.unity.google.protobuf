<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Google Protocol Buffers

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>
## プロジェクト概要

protobuf-net は、.NET コード向けのコントラクトベースのシリアライザで、Google が開発した "protocol buffers" シリアライゼーション形式でデータを書き込みます。API は典型的な .NET パターンに従い（XmlSerializer、DataContractSerializer などと広く比較可能）、標準型を記述し属性を使用できるほとんどの .NET 言語で動作します。

このライブラリは主に `https://github.com/GameFrameX/GameFrameX` プロジェクトのサブモジュールとして使用されています。

本パッケージは `ProtobufMessageSerializer` を提供しており、これは `com.gameframex.unity.network` の `IMessageSerializer` インターフェースの実装です。Unity ランタイムのロード時に `MessageSerializerRegistry.RegisterGlobal()` を介してグローバルデフォルトシリアライザとして自動登録されるため、後方互換性のためにコードの変更は不要です。

## 特徴

- **コントラクトベース** - .NET 属性を使用したシリアライゼーションコントラクト
- **高性能** - 効率的なバイナリシリアライゼーション形式
- **クロスプラットフォーム** - すべての .NET プラットフォームで動作
- **.NET パターン** - 典型的な .NET シリアライゼーションパターンに従う
- **Unity Package サポート** - Unity Package Manager サポートを追加
- **IMessageSerializer 統合** - ネットワークパッケージのプラグイン可能なシリアライゼーションのための `IMessageSerializer` を実装
- **自動登録** - ロード時にグローバルデフォルトシリアライザとして自動登録（ゼロ設定で後方互換）

## インストール

> **注意:** 本パッケージは `com.gameframex.unity.network`（>= 2.5.1）に依存しており、このパッケージが `IMessageSerializer` インターフェースを提供しています。Unity Package Manager が自動的に依存関係を解決します。

### Git URL 経由（推奨）

1. Unity エディタで Package Manager を開く
2. "+" ボタンをクリックし "Add package from git URL" を選択
3. 以下の URL を入力：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git
   ```

### manifest.json 経由

プロジェクトの `Packages/manifest.json` に以下を追加：

```json
{
  "dependencies": {
    "com.gameframex.unity.google.protobuf": "https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git"
  }
}
```

### 手動インストール

1. 最新のリリースパッケージをダウンロード
2. プロジェクトの `Packages` ディレクトリに展開
3. Unity が自動的にパッケージを認識して読み込みます

## ドキュメント

protobuf-net の使用ドキュメントは [protobuf-net/protobuf-net](https://github.com/protobuf-net/protobuf-net) をご覧ください。

### 手動シリアライザ登録

`ProtobufMessageSerializer` はロード時に自動登録されます。置き換えや手動登録が必要な場合：

```csharp
// 手動登録（例：グローバルシリアライザをリセットした後）
MessageSerializerRegistry.RegisterGlobal(new ProtobufMessageSerializer());

// チャネル単位のオーバーライドとして使用
var helper = new DefaultNetworkChannelHelper();
helper.SetChannelSerializer(new ProtobufMessageSerializer()); // Initialize() の前に呼び出す必要があります
```

## 変更履歴

詳細は [CHANGELOG.md](CHANGELOG.md) をご覧ください。

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE.md](LICENSE.md) をご覧ください。
