using System.Runtime.CompilerServices;
using VerifyTests.DiffPlex;

namespace DragoAnt.Extensions.T4.Tests.Common;

public static class ModuleInitializer
{

    [ModuleInitializer]
    public static void Initialize() =>
        VerifyDiffPlex.Initialize(OutputType.Compact);


    [ModuleInitializer]
    public static void OtherInitialize()
    {
        VerifierSettings.InitializePlugins();
        VerifierSettings.ScrubLinesContaining("DiffEngineTray");
        VerifierSettings.IgnoreStackTrace();
    }
}