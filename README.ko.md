<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX Google Protocol Buffers

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

protobuf-net은 .NET 코드를 위한 계약 기반 직렬화 도구로, Google이 설계한 "protocol buffers" 직렬화 형식으로 데이터를 작성합니다. API는 일반적인 .NET 패턴을 따르며 (XmlSerializer, DataContractSerializer 등과 광범위하게 비교 가능), 표준 유형을 작성하고 속성을 사용할 수 있는 대부분의 .NET 언어에서 작동합니다.

이 라이브러리는 주로 `https://github.com/GameFrameX/GameFrameX` 프로젝트의 서브모듈로 사용됩니다.

본 패키지는 `ProtobufMessageSerializer`를 제공하며, 이는 `com.gameframex.unity.network`의 `IMessageSerializer` 인터페이스 구현체입니다. Unity 런타임 로드 시 `MessageSerializerRegistry.RegisterGlobal()`을 통해 전역 기본 직렬화 도구로 자동 등록되므로, 하위 호환성을 위해 코드를 변경할 필요가 없습니다.

## 특징

- **계약 기반** - .NET 속성을 사용한 직렬화 계약 정의
- **고성능** - 효율적인 바이너리 직렬화 형식
- **크로스 플랫폼** - 모든 .NET 플랫폼에서 작동
- **.NET 패턴** - 일반적인 .NET 직렬화 패턴을 따름
- **Unity Package 지원** - Unity Package Manager 지원 추가
- **IMessageSerializer 통합** - 네트워크 패키지의 플러그형 직렬화를 위한 `IMessageSerializer` 구현
- **자동 등록** - 로드 시 전역 기본 직렬화 도구로 자동 등록 (제로 설정 하위 호환)

## 설치

> **참고:** 본 패키지는 `com.gameframex.unity.network`(>= 2.5.1)에 종속되며, 해당 패키지가 `IMessageSerializer` 인터페이스를 제공합니다. Unity Package Manager가 자동으로 종속성을 해결합니다.

### Git URL을 통해 설치 (권장)

1. Unity 에디터에서 Package Manager 열기
2. "+" 버튼을 클릭하고 "Add package from git URL" 선택
3. 다음 URL 입력:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git
   ```

### manifest.json을 통해 설치

프로젝트의 `Packages/manifest.json`에 다음을 추가:

```json
{
  "dependencies": {
    "com.gameframex.unity.google.protobuf": "https://github.com/GameFrameX/com.gameframex.unity.google.protobuf.git"
  }
}
```

### 수동 설치

1. 최신 릴리스 패키지 다운로드
2. 프로젝트의 `Packages` 디렉토리에 압축 해제
3. Unity가 자동으로 패키지를 인식하고 로드합니다

## 문서

protobuf-net 사용 문서는 [protobuf-net/protobuf-net](https://github.com/protobuf-net/protobuf-net)을 방문하세요.

### 수동 직렬화 도구 등록

`ProtobufMessageSerializer`는 로드 시 자동 등록됩니다. 교체하거나 수동으로 등록해야 하는 경우:

```csharp
// 수동 등록 (예: 전역 직렬화 도구를 재설정한 후)
MessageSerializerRegistry.RegisterGlobal(new ProtobufMessageSerializer());

// 채널별 오버라이드로 사용
var helper = new DefaultNetworkChannelHelper();
helper.SetChannelSerializer(new ProtobufMessageSerializer()); // Initialize() 전에 호출해야 합니다
```

## 변경 로그

자세한 내용은 [CHANGELOG.md](CHANGELOG.md)를 참조하세요.

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE.md](LICENSE.md)를 참조하세요.
