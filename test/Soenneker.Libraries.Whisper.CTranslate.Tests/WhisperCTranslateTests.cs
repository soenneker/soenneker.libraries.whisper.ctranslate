using Soenneker.Tests.HostedUnit;

namespace Soenneker.Libraries.Whisper.CTranslate.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class WhisperCTranslateTests : HostedUnitTest
{
    public WhisperCTranslateTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
