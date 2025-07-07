using System.Diagnostics;
using System.Reflection;

using Igenius.DesktopDevOPInt.Sample.Contracts.Services;

namespace Igenius.DesktopDevOPInt.Sample.Services;

public class ApplicationInfoService : IApplicationInfoService
{
    public ApplicationInfoService()
    {
    }

    public Version GetVersion()
    {
        // Set the app version in Igenius.DesktopDevOPInt.Sample > Properties > Package > PackageVersion
        string assemblyLocation = Assembly.GetExecutingAssembly().Location;
        var version = FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
        return new Version(version);
    }
}
