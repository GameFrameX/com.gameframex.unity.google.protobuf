<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Google Protocol Buffers

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

  [ドキュメント](https://gameframex.doc.alianblank.com) | [クイックスタート](#クイックスタート)

  [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)
</div>

---

## プロジェクト概要

protobuf-net は、.NET コード向けのコントラクトベースのシリアライザで、Google が開発した "protocol buffers" シリアライゼーション形式でデータを書き込みます。API は典型的な .NET パターンに従い（XmlSerializer、DataContractSerializer などと広く比較可能）、標準型を記述し属性を使用できるほとんどの .NET 言語で動作します。

このライブラリは主に `https://github.com/GameFrameX/GameFrameX` プロジェクトのサブモジュールとして使用されています。

## 特徴

- **コントラクトベース** - .NET 属性を使用したシリアライゼーションコントラクト
- **高性能** - 効率的なバイナリシリアライゼーション形式
- **クロスプラットフォーム** - すべての .NET プラットフォームで動作
- **.NET パターン** - 典型的な .NET シリアライゼーションパターンに従う
- **Unity Package サポート** - Unity Package Manager サポートを追加

## インストール

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

## 変更履歴

詳細は [CHANGELOG.md](CHANGELOG.md) をご覧ください。

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE.md](LICENSE.md) をご覧ください。
