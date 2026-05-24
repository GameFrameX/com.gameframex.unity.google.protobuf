<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Google Protocol Buffers

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

  [Documentation](https://gameframex.doc.alianblank.com) | [Quick Start](#quick-start)

  **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## Project Overview

protobuf-net is a contract based serializer for .NET code that writes data in the "protocol buffers" serialization format engineered by Google. The API follows typical .NET patterns (broadly comparable to XmlSerializer, DataContractSerializer, etc). It works for most .NET languages that write standard types and can use attributes.

This library primarily serves as a submodule of the `https://github.com/GameFrameX/GameFrameX` project.

## Features

- **Contract Based** - Uses .NET attributes for serialization contracts
- **High Performance** - Efficient binary serialization format
- **Cross Platform** - Works across all .NET platforms
- **.NET Patterns** - Follows typical .NET serialization patterns
- **Unity Package Support** - Added Unity Package Manager support

## Installation

### Via Git URL (Recommended)

1. Open Package Manager in Unity Editor
2. Click the "+" button and select "Add package from git URL"
3. Enter the following URL:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git
   ```

### Via manifest.json

Add the following to your project's `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.gameframex.unity.google.protobuf": "https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git"
  }
}
```

### Manual Installation

1. Download the latest release package
2. Extract it to your project's `Packages` directory
3. Unity will automatically recognize and load the package

## Documentation

For protobuf-net usage documentation, visit [protobuf-net/protobuf-net](https://github.com/protobuf-net/protobuf-net).

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for details.

## License

This project is licensed under the MIT License - see [LICENSE.md](LICENSE.md) for details.
