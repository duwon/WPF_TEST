using System.Diagnostics;
using System.Reflection;

using WPF_TEST.Contracts.Services;

namespace WPF_TEST.Services;

public class ApplicationInfoService : IApplicationInfoService
{
    public ApplicationInfoService()
    {
    }

    public Version GetVersion()
    {
        // Set the app version in WPF_TEST > Properties > Package > PackageVersion
        string assemblyLocation = Assembly.GetExecutingAssembly().Location;
        var version = FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
        return new Version(version);
    }
}
