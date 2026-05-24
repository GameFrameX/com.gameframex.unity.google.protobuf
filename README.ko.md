<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Google Protocol Buffers

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.google.protobuf)](https://github.com/GameFrameX/com.gameframex.unity.google.protobuf/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

  [문서](https://gameframex.doc.alianblank.com) | [빠른 시작](#빠른-시작)

  [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**
</div>

---

## 프로젝트 개요

protobuf-net은 .NET 코드를 위한 계약 기반 직렬화 도구로, Google이 설계한 "protocol buffers" 직렬화 형식으로 데이터를 작성합니다. API는 일반적인 .NET 패턴을 따르며 (XmlSerializer, DataContractSerializer 등과 광범위하게 비교 가능), 표준 유형을 작성하고 속성을 사용할 수 있는 대부분의 .NET 언어에서 작동합니다.

이 라이브러리는 주로 `https://github.com/GameFrameX/GameFrameX` 프로젝트의 서브모듈로 사용됩니다.

## 특징

- **계약 기반** - .NET 속성을 사용한 직렬화 계약 정의
- **고성능** - 효율적인 바이너리 직렬화 형식
- **크로스 플랫폼** - 모든 .NET 플랫폼에서 작동
- **.NET 패턴** - 일반적인 .NET 직렬화 패턴을 따름
- **Unity Package 지원** - Unity Package Manager 지원 추가

## 설치

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

## 변경 로그

자세한 내용은 [CHANGELOG.md](CHANGELOG.md)를 참조하세요.

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE.md](LICENSE.md)를 참조하세요.
