[![](https://img.shields.io/nuget/v/soenneker.libraries.whisper.ctranslate.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.whisper.ctranslate/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.runners.whisper.ctranslate/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.runners.whisper.ctranslate/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libraries.whisper.ctranslate.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.whisper.ctranslate/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Libraries.Whisper.CTranslate

## What is Whisper?
Whisper is an automatic speech recognition (ASR) system developed by OpenAI, designed to transcribe and translate audio efficiently and accurately. It supports multiple languages and use cases, ranging from real-time transcription to audio-based translation.

## About This Executable
The `Soenneker.Libraries.Whisper.CTranslate` package provides a Windows executable version of Whisper using the Faster-Whisper implementation with CTranslate2. This implementation is up to **4 times faster** than OpenAI’s original Whisper system, maintaining the same accuracy while requiring less memory.

## Features
- **No Python installation is needed**: Simple to deploy and use for Windows users.
- **Daily Updates**: This package is updated daily, including updates from its entire dependency chain and the [source repository](https://github.com/Softcatala/whisper-ctranslate2).
- **CUDA Support**: GPU transcoding via CUDA is fully supported for faster processing on compatible systems.

## Installation Options
You can obtain the executable in the following ways:

### 1. Release Installation
Download the latest release directly from the [Releases section](https://github.com/soenneker/soenneker.libraries.whisper.cTranslate/releases) on GitHub.

### 2. NuGet Package Installation

```powershell
dotnet install Soenneker.Libraries.Whisper.CTranslate
```

After installing via NuGet, the executable will be located at `/Resources/whisper_ctranslate2.exe` within your project.

## Usage Examples
The following examples demonstrate how to use the executable:

### Basic Transcription
Use the following command in PowerShell to transcribe an input audio file:

```powershell
./whisper_ctranslate2.exe input.mp3 --model medium
```
This command will automatically download the required model from HuggingFace if it’s not already available locally.

### Subtitles Generation
Generate subtitles (in SRT format) from an input audio file:

```powershell
./whisper-ctranslate2 input.mp3 --model medium --output-format srt
```

### Specify a Language
If you know the language of the input audio, specify it to improve accuracy and speed:

```powershell
./whisper-ctranslate2 input.mp3 --model medium --language en
```

### Help Command
To see all available options and arguments:

```powershell
./whisper_ctranslate2 --help
```

## Source Code and Custom Builds
The source code and instructions for building the executable yourself can be found in the [Soenneker.Runners.Whisper.CTranslate](https://github.com/soenneker/soenneker.runners.whisper.ctranslate) repository.
