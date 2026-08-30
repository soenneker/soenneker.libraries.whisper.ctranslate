[![](https://img.shields.io/nuget/v/soenneker.libraries.whisper.ctranslate.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.whisper.ctranslate/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libraries.whisper.ctranslate/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libraries.whisper.ctranslate/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libraries.whisper.ctranslate.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.whisper.ctranslate/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libraries.whisper.ctranslate/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.libraries.whisper.ctranslate/actions/workflows/codeql.yml)

# Soenneker.Libraries.Whisper.CTranslate

The Windows `whisper-ctranslate2` executable packaged as a .NET content asset.

## Install

```bash
dotnet add package Soenneker.Libraries.Whisper.CTranslate
```

The executable is copied beneath the application output directory:

```csharp
string whisper = Path.Combine(
    AppContext.BaseDirectory,
    "Resources", "whisper_ctranslate2.exe");

var startInfo = new ProcessStartInfo(whisper)
{
    UseShellExecute = false,
    RedirectStandardOutput = true,
    RedirectStandardError = true
};

startInfo.ArgumentList.Add(audioPath);
startInfo.ArgumentList.Add("--model");
startInfo.ArgumentList.Add("medium");
startInfo.ArgumentList.Add("--output_format");
startInfo.ArgumentList.Add("srt");
startInfo.ArgumentList.Add("--output_dir");
startInfo.ArgumentList.Add(outputDirectory);
```

Start the process, drain both redirected streams, wait for completion, and reject a non-zero exit code. Pass paths and other variable values through `ArgumentList` rather than concatenating a command string.

Named models may be downloaded on first use, so the process needs network access and writable model-cache storage unless the model is already available locally. Model size, CPU/GPU selection, and audio duration materially affect runtime and memory use.

This package supplies the executable; it does not manage models, start processes, parse transcripts, or enforce time and output-size limits.
